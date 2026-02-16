namespace GW8251A_Control;

public partial class MainForm : Form
{
    private readonly ScpiDevice _device = new();
    private System.Windows.Forms.Timer? _readTimer;
    private bool _continuousRead;

    public MainForm()
    {
        InitializeComponent();
        SetupEventHandlers();
        RefreshPortList();
        cmbBaudRate.SelectedItem = "9600";
        cmbDetectionRate.SelectedItem = "Slow";
        UpdateConnectionState();
    }

    private void SetupEventHandlers()
    {
        _device.CommandSent += (s, cmd) => LogMessage($"TX: {cmd}");
        _device.ResponseReceived += (s, resp) => LogMessage($"RX: {resp}");
        _device.ErrorOccurred += (s, err) => LogMessage($"ERROR: {err}");

        _readTimer = new System.Windows.Forms.Timer { Interval = 500 };
        _readTimer.Tick += ReadTimer_Tick;
    }

    private void RefreshPortList()
    {
        cmbPort.Items.Clear();
        cmbPort.Items.AddRange(ScpiDevice.GetAvailablePorts());
        if (cmbPort.Items.Count > 0)
            cmbPort.SelectedIndex = 0;
    }

    private void UpdateConnectionState()
    {
        bool connected = _device.IsConnected;

        btnConnect.Text = connected ? "Disconnect" : "Connect";
        btnConnect.BackColor = connected ? Color.Green : SystemColors.ControlDarkDark;

        cmbPort.Enabled = !connected;
        cmbBaudRate.Enabled = !connected;
        btnRefreshPorts.Enabled = !connected;

        grpMeasurement.Enabled = connected;
        grpFunction.Enabled = connected;
        grpAdvanced.Enabled = connected;
        grpCommand.Enabled = connected;
        grpLog.Enabled = connected;
        btnReadOnce.Enabled = connected;
        btnContinuousRead.Enabled = connected;

        lblStatus.Text = connected ? $"Connected to {_device.PortName}" : "Disconnected";
        lblStatus.ForeColor = connected ? Color.Green : Color.DarkGray;
    }

    private void LogMessage(string message)
    {
        if (InvokeRequired)
        {
            Invoke(() => LogMessage(message));
            return;
        }

        txtLog.AppendText($"[{DateTime.Now:HH:mm:ss}] {message}\r\n");
        txtLog.ScrollToCaret();
    }

    private void UpdateDisplay(string? primary, string? secondary = null)
    {
        if (InvokeRequired)
        {
            Invoke(() => UpdateDisplay(primary, secondary));
            return;
        }

        lblPrimaryValue.Text = FormatMeasurement(primary);
        if (secondary != null)
            lblSecondaryValue.Text = FormatMeasurement(secondary);
    }

    private static string FormatMeasurement(string? value)
    {
        if (string.IsNullOrEmpty(value))
            return "----";

        if (double.TryParse(value, out double num))
        {
            return Math.Abs(num) >= 1000 ? $"{num:E4}" : $"{num:F6}";
        }
        return value;
    }

    #region Event Handlers

    private void btnRefreshPorts_Click(object sender, EventArgs e)
    {
        RefreshPortList();
    }

    private void btnConnect_Click(object sender, EventArgs e)
    {
        if (_device.IsConnected)
        {
            StopContinuousRead();
            _device.Disconnect();
            LogMessage("Disconnected");
        }
        else
        {
            if (cmbPort.SelectedItem == null)
            {
                MessageBox.Show("Please select a COM port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string port = cmbPort.SelectedItem.ToString()!;
            int baudRate = int.Parse(cmbBaudRate.SelectedItem?.ToString() ?? "115200");

            if (_device.Connect(port, baudRate))
            {
                LogMessage($"Connected to {port} at {baudRate} baud");

                // Initialize: remote mode, reset to known state, clear status
                _device.SetRemoteMode();
                _device.Reset();
                Thread.Sleep(6000);
                _device.ClearStatus();

                // Get device identity
                var id = _device.GetIdentity();
                if (id != null)
                    LogMessage($"Device: {id}");
            }
        }
        UpdateConnectionState();
    }

    private void btnReadOnce_Click(object sender, EventArgs e)
    {
        var primary = _device.ReadPrimaryDisplay();
        var secondary = _device.ReadSecondaryDisplay();
        UpdateDisplay(primary, secondary);
    }

    private void btnContinuousRead_Click(object sender, EventArgs e)
    {
        _continuousRead = !_continuousRead;

        if (_continuousRead)
        {
            _readTimer?.Start();
            btnContinuousRead.Text = "Stop";
            btnContinuousRead.BackColor = Color.DarkGray;
        }
        else
        {
            StopContinuousRead();
        }
    }

    private void StopContinuousRead()
    {
        _readTimer?.Stop();
        _continuousRead = false;
        btnContinuousRead.Text = "Continuous";
        btnContinuousRead.BackColor = SystemColors.ControlDarkDark;
    }

    private void ReadTimer_Tick(object? sender, EventArgs e)
    {
        if (!_device.IsConnected)
        {
            StopContinuousRead();
            return;
        }

        var primary = _device.ReadPrimaryDisplay();
        var secondary = _device.ReadSecondaryDisplay();
        UpdateDisplay(primary, secondary);
    }

    // Function selection buttons
    private void btnDCV_Click(object sender, EventArgs e)
    {
        _device.ConfigureDCVoltageAuto();
        _device.SetAutoRange(true);
    }

    private void btnACV_Click(object sender, EventArgs e)
    {
        _device.ConfigureACVoltageAuto();
        _device.SetAutoRange(true);
    }

    private void btnDCA_Click(object sender, EventArgs e)
    {
        _device.ConfigureDCCurrentAuto();
        _device.SetAutoRange(true);
    }

    private void btnACA_Click(object sender, EventArgs e)
    {
        _device.ConfigureACCurrentAuto();
        _device.SetAutoRange(true);
    }

    private void btnRes2W_Click(object sender, EventArgs e)
    {
        _device.ConfigureResistance2WAuto();
        _device.SetAutoRange(true);
    }

    private void btnRes4W_Click(object sender, EventArgs e)
    {
        _device.ConfigureResistance4WAuto();
        _device.SetAutoRange(true);
    }

    private void btnFreq_Click(object sender, EventArgs e)
    {
        _device.ConfigureFrequency();
    }

    private void btnCont_Click(object sender, EventArgs e)
    {
        _device.ConfigureContinuity();
    }

    private void btnDiode_Click(object sender, EventArgs e)
    {
        _device.ConfigureDiode();
    }

    private void btnTemp_Click(object sender, EventArgs e)
    {
        _device.ConfigureTemperature();
    }

    private void btnDCACV_Click(object sender, EventArgs e)
    {
        _device.ConfigureDCACVoltageAuto();
        _device.SetAutoRange(true);
    }

    private void btnDCACI_Click(object sender, EventArgs e)
    {
        _device.ConfigureDCACCurrentAuto();
        _device.SetAutoRange(true);
    }

    private void btnPeriod_Click(object sender, EventArgs e)
    {
        _device.ConfigurePeriod();
    }

    private void cmbTCType_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (!_device.IsConnected || cmbTCType.SelectedItem == null) return;
        char type = cmbTCType.SelectedItem.ToString()!.ToLower()[0];
        _device.SetThermocoupleType(type);
    }

    private void cmbSecDisplay_SelectedIndexChanged(object sender, EventArgs e)
    {
    }

    private void btnSetSecDisplay_Click(object sender, EventArgs e)
    {
        if (!_device.IsConnected || cmbSecDisplay.SelectedItem == null) return;

        string selection = cmbSecDisplay.SelectedItem.ToString()!;
        switch (selection)
        {
            case "Off":   _device.DisableSecondaryDisplay(); break;
            case "DCV":   _device.ConfigureSecondaryDCVoltage(0); break;
            case "ACV":   _device.ConfigureSecondaryACVoltage(0); break;
            case "DCI":   _device.ConfigureSecondaryDCCurrent(0); break;
            case "ACI":   _device.ConfigureSecondaryACCurrent(0); break;
            case "2WΩ":   _device.ConfigureSecondaryResistance2W(0); break;
            case "4WΩ":   _device.ConfigureSecondaryResistance4W(0); break;
            case "Freq":  _device.ConfigureSecondaryFrequency(); break;
            case "Period": _device.ConfigureSecondaryPeriod(); break;
            case "Temp":  _device.ConfigureSecondaryTemperature(); break;
        }
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
        _device.Reset();
        LogMessage("Device reset");
    }

    private void btnLocal_Click(object sender, EventArgs e)
    {
        _device.SetLocalMode();
        LogMessage("Returned to local mode");
    }

    private void btnSendCommand_Click(object sender, EventArgs e)
    {
        string cmd = txtCommand.Text.Trim();
        if (string.IsNullOrEmpty(cmd))
            return;

        if (cmd.EndsWith("?"))
        {
            var response = _device.Query(cmd);
            if (response != null)
                LogMessage($"Response: {response}");
        }
        else
        {
            _device.SendCommand(cmd);
        }
    }

    private void txtCommand_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            btnSendCommand_Click(sender, e);
            e.Handled = true;
            e.SuppressKeyPress = true;
        }
    }

    private void btnClearLog_Click(object sender, EventArgs e)
    {
        txtLog.Clear();
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        StopContinuousRead();
        _device.Dispose();
    }

    private void cmbDetectionRate_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (!_device.IsConnected) return;

        char rate = cmbDetectionRate.SelectedIndex switch
        {
            0 => 'f',
            1 => 'm',
            2 => 's',
            _ => 'm'
        };
        _device.SetDetectionRate(rate);
    }

    private void chkAutoRange_CheckedChanged(object sender, EventArgs e)
    {
        if (!_device.IsConnected) return;
        _device.SetAutoRange(chkAutoRange.Checked);
    }

    private void btnRelative_Click(object sender, EventArgs e)
    {
        _device.ActivateFunction("rel");
    }

    private void btnMinMax_Click(object sender, EventArgs e)
    {
        _device.ActivateFunction("max");
    }

    private void btnHold_Click(object sender, EventArgs e)
    {
        _device.ActivateFunction("hold");
    }

    #endregion

    private void grpAdvanced_Enter(object sender, EventArgs e)
    {

    }

    private void cmbBaudRate_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
