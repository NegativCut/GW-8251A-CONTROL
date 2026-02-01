# GW-8251A Control

PC control application for the GW Instek GDM-8251A Digital Multimeter.

## Features

- Connect via USB or RS-232C (both appear as COM ports)
- Real-time measurement display with continuous read mode
- Full function selection (DCV, ACV, DCA, ACA, Resistance, Frequency, etc.)
- Detection rate control (Fast/Medium/Slow)
- Auto range toggle
- Advanced functions (Relative, Min/Max, Hold)
- Manual SCPI command input
- Communication log

## Requirements

- Windows 10/11
- .NET 8.0 Runtime
- GW Instek GDM-8251A or compatible GDM-8200A series multimeter

## Building

Open `src/GW8251A_Control.sln` in Visual Studio 2022 and build.

Or use the .NET CLI:
```bash
cd src/GW8251A_Control
dotnet build
dotnet run
```

## Connection Setup

### USB Connection
1. Connect USB cable to the rear panel (upper port)
2. Install USB drivers if prompted
3. The device will appear as a virtual COM port

### RS-232C Connection
1. Use a null-modem cable (TxD/RxD crossed)
2. Configure baud rate on the multimeter: Menu > I/O > RS232 > Baud Rate
3. Match the baud rate in the application

### Pin Assignment (RS-232C)
- Pin 2: RxD
- Pin 3: TxD
- Pin 5: GND

## Usage

1. Select the COM port and baud rate
2. Click **Connect**
3. Select a measurement function (DCV, ACV, etc.)
4. Click **Read Once** or **Continuous** to view measurements

## SCPI Commands

Send manual commands in the command box. Queries (ending with `?`) will display responses in the log.

Examples:
- `*idn?` - Get device identity
- `conf:volt:dc 10` - Set DC Voltage, 10V range
- `val1?` - Read primary display value
- `*rst` - Reset device

## Protocol Reference

See `DATASHEET/GW8251A_COMMS.pdf` for full SCPI command documentation.

## License

MIT
