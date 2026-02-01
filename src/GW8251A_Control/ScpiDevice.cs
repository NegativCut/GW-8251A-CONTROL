using System.IO.Ports;

namespace GW8251A_Control;

/// <summary>
/// SCPI communication layer for GW Instek GDM-8251A multimeter.
/// Handles serial port communication and command/response protocol.
/// </summary>
public class ScpiDevice : IDisposable
{
    private SerialPort? _port;
    private bool _disposed;

    public bool IsConnected => _port?.IsOpen ?? false;
    public string? PortName => _port?.PortName;

    public event EventHandler<string>? CommandSent;
    public event EventHandler<string>? ResponseReceived;
    public event EventHandler<string>? ErrorOccurred;

    /// <summary>
    /// Get available COM ports on the system.
    /// </summary>
    public static string[] GetAvailablePorts() => SerialPort.GetPortNames();

    /// <summary>
    /// Connect to the multimeter.
    /// </summary>
    public bool Connect(string portName, int baudRate = 115200)
    {
        try
        {
            Disconnect();

            _port = new SerialPort(portName)
            {
                BaudRate = baudRate,
                DataBits = 8,
                Parity = Parity.None,
                StopBits = StopBits.One,
                Handshake = Handshake.None,
                ReadTimeout = 2000,
                WriteTimeout = 1000,
                NewLine = "\r\n"
            };

            _port.Open();
            return true;
        }
        catch (Exception ex)
        {
            ErrorOccurred?.Invoke(this, $"Connection failed: {ex.Message}");
            return false;
        }
    }

    /// <summary>
    /// Disconnect from the multimeter.
    /// </summary>
    public void Disconnect()
    {
        if (_port?.IsOpen == true)
        {
            try
            {
                SendCommand("syst:loc"); // Return to local control
                _port.Close();
            }
            catch { }
        }
        _port?.Dispose();
        _port = null;
    }

    /// <summary>
    /// Send a command without expecting a response.
    /// </summary>
    public bool SendCommand(string command)
    {
        if (_port?.IsOpen != true)
        {
            ErrorOccurred?.Invoke(this, "Not connected");
            return false;
        }

        try
        {
            _port.WriteLine(command);
            CommandSent?.Invoke(this, command);
            return true;
        }
        catch (Exception ex)
        {
            ErrorOccurred?.Invoke(this, $"Send failed: {ex.Message}");
            return false;
        }
    }

    /// <summary>
    /// Send a query command and return the response.
    /// </summary>
    public string? Query(string command)
    {
        if (_port?.IsOpen != true)
        {
            ErrorOccurred?.Invoke(this, "Not connected");
            return null;
        }

        try
        {
            _port.DiscardInBuffer();
            _port.WriteLine(command);
            CommandSent?.Invoke(this, command);

            string response = _port.ReadLine().Trim();
            ResponseReceived?.Invoke(this, response);
            return response;
        }
        catch (TimeoutException)
        {
            ErrorOccurred?.Invoke(this, $"Timeout waiting for response to: {command}");
            return null;
        }
        catch (Exception ex)
        {
            ErrorOccurred?.Invoke(this, $"Query failed: {ex.Message}");
            return null;
        }
    }

    #region Identity & System Commands

    public string? GetIdentity() => Query("*idn?");
    public string? GetVersion() => Query("syst:vers?");
    public bool Reset() => SendCommand("*rst");
    public bool ClearStatus() => SendCommand("*cls");
    public bool SetRemoteMode() => SendCommand("syst:rem");
    public bool SetLocalMode() => SendCommand("syst:loc");
    public string? GetError() => Query("syst:err?");

    #endregion

    #region Measurement Reading

    public string? ReadPrimaryDisplay() => Query("val1?");
    public string? ReadSecondaryDisplay() => Query("val2?");
    public string? ReadBothDisplays() => Query("read?");

    public double? ReadPrimaryValue()
    {
        var response = ReadPrimaryDisplay();
        if (double.TryParse(response, out double value))
            return value;
        return null;
    }

    public double? ReadSecondaryValue()
    {
        var response = ReadSecondaryDisplay();
        if (double.TryParse(response, out double value))
            return value;
        return null;
    }

    #endregion

    #region Configuration Commands

    // Voltage
    public bool ConfigureDCVoltage(double range) => SendCommand($"conf:volt:dc {range}");
    public bool ConfigureDCVoltageAuto() => SendCommand("conf:volt:dc min");
    public bool ConfigureACVoltage(double range) => SendCommand($"conf:volt:ac {range}");
    public bool ConfigureACVoltageAuto() => SendCommand("conf:volt:ac min");
    public bool ConfigureDCACVoltage(double range) => SendCommand($"conf:volt:dcac {range}");

    // Current
    public bool ConfigureDCCurrent(double range) => SendCommand($"conf:curr:dc {range}");
    public bool ConfigureDCCurrentAuto() => SendCommand("conf:curr:dc min");
    public bool ConfigureACCurrent(double range) => SendCommand($"conf:curr:ac {range}");
    public bool ConfigureACCurrentAuto() => SendCommand("conf:curr:ac min");
    public bool ConfigureDCACCurrent(double range) => SendCommand($"conf:curr:dcac {range}");

    // Resistance
    public bool ConfigureResistance2W(double range) => SendCommand($"conf:res {range}");
    public bool ConfigureResistance2WAuto() => SendCommand("conf:res min");
    public bool ConfigureResistance4W(double range) => SendCommand($"conf:fres {range}");
    public bool ConfigureResistance4WAuto() => SendCommand("conf:fres min");

    // Other
    public bool ConfigureFrequency() => SendCommand("conf:freq");
    public bool ConfigurePeriod() => SendCommand("conf:per");
    public bool ConfigureContinuity() => SendCommand("conf:cont");
    public bool ConfigureDiode() => SendCommand("conf:diod");
    public bool ConfigureTemperature() => SendCommand("conf:temp");

    // Auto range
    public bool SetAutoRange(bool enable) => SendCommand($"conf:auto {(enable ? 1 : 0)}");
    public string? GetAutoRangeStatus() => Query("conf:auto?");

    // Query current function and range
    public string? GetCurrentFunction() => Query("conf:stat:func?");
    public string? GetCurrentRange() => Query("conf:stat:rang?");

    #endregion

    #region Sense Commands

    public bool SetDetectionRate(char rate) => SendCommand($"sens:det:rate {rate}"); // s=slow, m=medium, f=fast
    public string? GetDetectionRate() => Query("sens:det:rate?");

    public bool SetThermocoupleType(char type) => SendCommand($"sens:temp:tco:type {type}"); // j, k, t
    public string? GetThermocoupleType() => Query("sens:temp:tco:type?");

    public bool SetDigitalFilter(bool enable) => SendCommand($"sens:aver:stat {(enable ? 1 : 0)}");
    public string? GetDigitalFilterStatus() => Query("sens:aver:stat?");
    public bool SetDigitalFilterCount(int count) => SendCommand($"sens:aver:coun {count}");
    public string? GetDigitalFilterCount() => Query("sens:aver:coun?");
    public bool SetDigitalFilterType(string type) => SendCommand($"sens:aver:tcon {type}"); // mov or rep
    public string? GetDigitalFilterType() => Query("sens:aver:tcon?");

    #endregion

    #region Calculate Commands

    public bool ActivateFunction(string func) => SendCommand($"calc:func {func}"); // rel, max, hold, dbm, db, math, comp
    public string? GetActiveFunction() => Query("calc:func?");

    public bool SetMathEnabled(bool enable) => SendCommand($"calc:stat {(enable ? 1 : 0)}");
    public string? GetMathStatus() => Query("calc:stat?");

    public string? GetMinValue() => Query("calc:aver:min?");
    public string? GetMaxValue() => Query("calc:aver:max?");
    public string? GetAverageValue() => Query("calc:aver:aver?");
    public string? GetDataCount() => Query("calc:aver:coun?");

    public bool SetRelativeReference(double value) => SendCommand($"calc:rel:ref {value}");
    public string? GetRelativeReference() => Query("calc:rel:ref?");

    public bool SetCompareLowerLimit(double value) => SendCommand($"calc:lim:low {value}");
    public bool SetCompareUpperLimit(double value) => SendCommand($"calc:lim:upp {value}");
    public string? GetCompareLowerLimit() => Query("calc:lim:low?");
    public string? GetCompareUpperLimit() => Query("calc:lim:upp?");

    #endregion

    #region Trigger Commands

    public bool SetTriggerSource(string source) => SendCommand($"trig:sour {source}"); // int or ext
    public string? GetTriggerSource() => Query("trig:sour?");

    public bool SetTriggerDelay(int ms) => SendCommand($"trig:del {ms}");
    public string? GetTriggerDelay() => Query("trig:del?");

    public bool SetTriggerAuto(bool enable) => SendCommand($"trig:auto {(enable ? 1 : 0)}");
    public string? GetTriggerAuto() => Query("trig:auto?");

    public bool SetSampleCount(int count) => SendCommand($"samp:coun {count}");
    public string? GetSampleCount() => Query("samp:coun?");

    public bool ManualTrigger() => SendCommand("*trg");

    public string? GetBufferData() => Query("trac:data?");
    public bool ClearBuffer() => SendCommand("trac:cle");

    #endregion

    #region Secondary Display Commands

    public bool ConfigureSecondaryDCVoltage(double range) => SendCommand($"conf2:volt:dc {range}");
    public bool ConfigureSecondaryACVoltage(double range) => SendCommand($"conf2:volt:ac {range}");
    public bool ConfigureSecondaryDCCurrent(double range) => SendCommand($"conf2:curr:dc {range}");
    public bool ConfigureSecondaryACCurrent(double range) => SendCommand($"conf2:curr:ac {range}");
    public bool ConfigureSecondaryResistance2W(double range) => SendCommand($"conf2:res {range}");
    public bool ConfigureSecondaryResistance4W(double range) => SendCommand($"conf2:fres {range}");
    public bool ConfigureSecondaryFrequency() => SendCommand("conf2:freq");
    public bool ConfigureSecondaryPeriod() => SendCommand("conf2:per");
    public bool ConfigureSecondaryTemperature() => SendCommand("conf2:temp");
    public bool DisableSecondaryDisplay() => SendCommand("conf2:off");
    public string? GetSecondaryFunction() => Query("conf2:stat:func?");
    public string? GetSecondaryRange() => Query("conf2:stat:rang?");

    #endregion

    #region Unit Commands

    public bool SetTemperatureUnit(char unit) => SendCommand($"unit:temp {unit}"); // c or f
    public string? GetTemperatureUnit() => Query("unit:temp?");

    #endregion

    #region Display Commands

    public bool SetDisplayEnabled(bool enable) => SendCommand($"syst:disp {(enable ? 1 : 0)}");
    public string? GetDisplayStatus() => Query("syst:disp?");

    public bool SetBeepMode(int mode) => SendCommand($"syst:beep:stat {mode}"); // 0=off, 1=pass, 2=fail
    public string? GetBeepMode() => Query("syst:beep:stat?");

    #endregion

    public void Dispose()
    {
        if (!_disposed)
        {
            Disconnect();
            _disposed = true;
        }
        GC.SuppressFinalize(this);
    }
}
