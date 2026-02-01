namespace GW8251A_Control;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        // Connection group
        grpConnection = new GroupBox();
        cmbPort = new ComboBox();
        cmbBaudRate = new ComboBox();
        btnRefreshPorts = new Button();
        btnConnect = new Button();
        lblPortLabel = new Label();
        lblBaudLabel = new Label();

        // Measurement display
        grpMeasurement = new GroupBox();
        lblPrimaryLabel = new Label();
        lblPrimaryValue = new Label();
        lblSecondaryLabel = new Label();
        lblSecondaryValue = new Label();
        btnReadOnce = new Button();
        btnContinuousRead = new Button();

        // Function selection
        grpFunction = new GroupBox();
        btnDCV = new Button();
        btnACV = new Button();
        btnDCA = new Button();
        btnACA = new Button();
        btnRes2W = new Button();
        btnRes4W = new Button();
        btnFreq = new Button();
        btnCont = new Button();
        btnDiode = new Button();
        btnTemp = new Button();

        // Advanced options
        grpAdvanced = new GroupBox();
        lblRateLabel = new Label();
        cmbDetectionRate = new ComboBox();
        chkAutoRange = new CheckBox();
        btnRelative = new Button();
        btnMinMax = new Button();
        btnHold = new Button();
        btnReset = new Button();
        btnLocal = new Button();

        // Manual command
        grpCommand = new GroupBox();
        txtCommand = new TextBox();
        btnSendCommand = new Button();

        // Log
        grpLog = new GroupBox();
        txtLog = new TextBox();
        btnClearLog = new Button();

        // Status
        lblStatus = new Label();

        SuspendLayout();

        // === Connection Group ===
        grpConnection.Location = new Point(12, 12);
        grpConnection.Size = new Size(360, 80);
        grpConnection.Text = "Connection";

        lblPortLabel.Location = new Point(10, 25);
        lblPortLabel.Size = new Size(35, 20);
        lblPortLabel.Text = "Port:";

        cmbPort.Location = new Point(50, 22);
        cmbPort.Size = new Size(90, 23);
        cmbPort.DropDownStyle = ComboBoxStyle.DropDownList;

        btnRefreshPorts.Location = new Point(145, 21);
        btnRefreshPorts.Size = new Size(25, 25);
        btnRefreshPorts.Text = "R";
        btnRefreshPorts.Click += btnRefreshPorts_Click;

        lblBaudLabel.Location = new Point(175, 25);
        lblBaudLabel.Size = new Size(40, 20);
        lblBaudLabel.Text = "Baud:";

        cmbBaudRate.Location = new Point(220, 22);
        cmbBaudRate.Size = new Size(70, 23);
        cmbBaudRate.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbBaudRate.Items.AddRange(new object[] { "115200", "57600", "38400", "19200", "9600" });
        cmbBaudRate.SelectedIndex = 0;

        btnConnect.Location = new Point(10, 50);
        btnConnect.Size = new Size(340, 25);
        btnConnect.Text = "Connect";
        btnConnect.Click += btnConnect_Click;

        grpConnection.Controls.AddRange(new Control[] { lblPortLabel, cmbPort, btnRefreshPorts, lblBaudLabel, cmbBaudRate, btnConnect });

        // === Measurement Group ===
        grpMeasurement.Location = new Point(12, 98);
        grpMeasurement.Size = new Size(360, 130);
        grpMeasurement.Text = "Measurement";

        lblPrimaryLabel.Location = new Point(10, 22);
        lblPrimaryLabel.Size = new Size(60, 20);
        lblPrimaryLabel.Text = "Primary:";

        lblPrimaryValue.Location = new Point(10, 42);
        lblPrimaryValue.Size = new Size(340, 35);
        lblPrimaryValue.Text = "----";
        lblPrimaryValue.Font = new Font("Consolas", 20F, FontStyle.Bold);
        lblPrimaryValue.ForeColor = Color.DarkBlue;
        lblPrimaryValue.TextAlign = ContentAlignment.MiddleRight;
        lblPrimaryValue.BorderStyle = BorderStyle.FixedSingle;
        lblPrimaryValue.BackColor = Color.White;

        lblSecondaryLabel.Location = new Point(10, 80);
        lblSecondaryLabel.Size = new Size(70, 20);
        lblSecondaryLabel.Text = "Secondary:";

        lblSecondaryValue.Location = new Point(85, 80);
        lblSecondaryValue.Size = new Size(150, 20);
        lblSecondaryValue.Text = "----";
        lblSecondaryValue.Font = new Font("Consolas", 11F);
        lblSecondaryValue.ForeColor = Color.DarkGreen;

        btnReadOnce.Location = new Point(10, 102);
        btnReadOnce.Size = new Size(100, 23);
        btnReadOnce.Text = "Read Once";
        btnReadOnce.Click += btnReadOnce_Click;

        btnContinuousRead.Location = new Point(115, 102);
        btnContinuousRead.Size = new Size(100, 23);
        btnContinuousRead.Text = "Continuous";
        btnContinuousRead.Click += btnContinuousRead_Click;

        grpMeasurement.Controls.AddRange(new Control[] { lblPrimaryLabel, lblPrimaryValue, lblSecondaryLabel, lblSecondaryValue, btnReadOnce, btnContinuousRead });

        // === Function Group ===
        grpFunction.Location = new Point(12, 234);
        grpFunction.Size = new Size(360, 90);
        grpFunction.Text = "Function";

        int btnW = 65, btnH = 28, gap = 5;
        int row1Y = 20, row2Y = 52;

        btnDCV.Location = new Point(10, row1Y);
        btnDCV.Size = new Size(btnW, btnH);
        btnDCV.Text = "DCV";
        btnDCV.Click += btnDCV_Click;

        btnACV.Location = new Point(10 + (btnW + gap), row1Y);
        btnACV.Size = new Size(btnW, btnH);
        btnACV.Text = "ACV";
        btnACV.Click += btnACV_Click;

        btnDCA.Location = new Point(10 + 2 * (btnW + gap), row1Y);
        btnDCA.Size = new Size(btnW, btnH);
        btnDCA.Text = "DCA";
        btnDCA.Click += btnDCA_Click;

        btnACA.Location = new Point(10 + 3 * (btnW + gap), row1Y);
        btnACA.Size = new Size(btnW, btnH);
        btnACA.Text = "ACA";
        btnACA.Click += btnACA_Click;

        btnRes2W.Location = new Point(10 + 4 * (btnW + gap), row1Y);
        btnRes2W.Size = new Size(btnW, btnH);
        btnRes2W.Text = "2W\u03A9";
        btnRes2W.Click += btnRes2W_Click;

        btnRes4W.Location = new Point(10, row2Y);
        btnRes4W.Size = new Size(btnW, btnH);
        btnRes4W.Text = "4W\u03A9";
        btnRes4W.Click += btnRes4W_Click;

        btnFreq.Location = new Point(10 + (btnW + gap), row2Y);
        btnFreq.Size = new Size(btnW, btnH);
        btnFreq.Text = "Freq";
        btnFreq.Click += btnFreq_Click;

        btnCont.Location = new Point(10 + 2 * (btnW + gap), row2Y);
        btnCont.Size = new Size(btnW, btnH);
        btnCont.Text = "Cont";
        btnCont.Click += btnCont_Click;

        btnDiode.Location = new Point(10 + 3 * (btnW + gap), row2Y);
        btnDiode.Size = new Size(btnW, btnH);
        btnDiode.Text = "Diode";
        btnDiode.Click += btnDiode_Click;

        btnTemp.Location = new Point(10 + 4 * (btnW + gap), row2Y);
        btnTemp.Size = new Size(btnW, btnH);
        btnTemp.Text = "Temp";
        btnTemp.Click += btnTemp_Click;

        grpFunction.Controls.AddRange(new Control[] { btnDCV, btnACV, btnDCA, btnACA, btnRes2W, btnRes4W, btnFreq, btnCont, btnDiode, btnTemp });

        // === Advanced Group ===
        grpAdvanced.Location = new Point(12, 330);
        grpAdvanced.Size = new Size(360, 85);
        grpAdvanced.Text = "Advanced";

        lblRateLabel.Location = new Point(10, 25);
        lblRateLabel.Size = new Size(40, 20);
        lblRateLabel.Text = "Rate:";

        cmbDetectionRate.Location = new Point(55, 22);
        cmbDetectionRate.Size = new Size(80, 23);
        cmbDetectionRate.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbDetectionRate.Items.AddRange(new object[] { "Fast", "Medium", "Slow" });
        cmbDetectionRate.SelectedIndex = 1;
        cmbDetectionRate.SelectedIndexChanged += cmbDetectionRate_SelectedIndexChanged;

        chkAutoRange.Location = new Point(145, 24);
        chkAutoRange.Size = new Size(90, 20);
        chkAutoRange.Text = "Auto Range";
        chkAutoRange.Checked = true;
        chkAutoRange.CheckedChanged += chkAutoRange_CheckedChanged;

        btnRelative.Location = new Point(10, 52);
        btnRelative.Size = new Size(60, 25);
        btnRelative.Text = "REL";
        btnRelative.Click += btnRelative_Click;

        btnMinMax.Location = new Point(75, 52);
        btnMinMax.Size = new Size(70, 25);
        btnMinMax.Text = "Min/Max";
        btnMinMax.Click += btnMinMax_Click;

        btnHold.Location = new Point(150, 52);
        btnHold.Size = new Size(60, 25);
        btnHold.Text = "Hold";
        btnHold.Click += btnHold_Click;

        btnReset.Location = new Point(240, 22);
        btnReset.Size = new Size(55, 25);
        btnReset.Text = "Reset";
        btnReset.Click += btnReset_Click;

        btnLocal.Location = new Point(300, 22);
        btnLocal.Size = new Size(50, 25);
        btnLocal.Text = "Local";
        btnLocal.Click += btnLocal_Click;

        grpAdvanced.Controls.AddRange(new Control[] { lblRateLabel, cmbDetectionRate, chkAutoRange, btnRelative, btnMinMax, btnHold, btnReset, btnLocal });

        // === Command Group ===
        grpCommand.Location = new Point(12, 420);
        grpCommand.Size = new Size(360, 55);
        grpCommand.Text = "Manual Command";

        txtCommand.Location = new Point(10, 22);
        txtCommand.Size = new Size(270, 23);
        txtCommand.KeyDown += txtCommand_KeyDown;

        btnSendCommand.Location = new Point(285, 21);
        btnSendCommand.Size = new Size(65, 25);
        btnSendCommand.Text = "Send";
        btnSendCommand.Click += btnSendCommand_Click;

        grpCommand.Controls.AddRange(new Control[] { txtCommand, btnSendCommand });

        // === Log Group ===
        grpLog.Location = new Point(12, 480);
        grpLog.Size = new Size(360, 150);
        grpLog.Text = "Log";

        txtLog.Location = new Point(10, 20);
        txtLog.Size = new Size(340, 95);
        txtLog.Multiline = true;
        txtLog.ScrollBars = ScrollBars.Vertical;
        txtLog.ReadOnly = true;
        txtLog.Font = new Font("Consolas", 8F);
        txtLog.BackColor = Color.White;

        btnClearLog.Location = new Point(10, 120);
        btnClearLog.Size = new Size(80, 23);
        btnClearLog.Text = "Clear Log";
        btnClearLog.Click += btnClearLog_Click;

        grpLog.Controls.AddRange(new Control[] { txtLog, btnClearLog });

        // === Status Label ===
        lblStatus.Location = new Point(12, 635);
        lblStatus.Size = new Size(360, 20);
        lblStatus.Text = "Disconnected";
        lblStatus.ForeColor = Color.Gray;

        // === Main Form ===
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(384, 661);
        Controls.AddRange(new Control[] { grpConnection, grpMeasurement, grpFunction, grpAdvanced, grpCommand, grpLog, lblStatus });
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "GW-8251A Control";
        FormClosing += MainForm_FormClosing;

        ResumeLayout(false);
    }

    #endregion

    private GroupBox grpConnection;
    private ComboBox cmbPort;
    private ComboBox cmbBaudRate;
    private Button btnRefreshPorts;
    private Button btnConnect;
    private Label lblPortLabel;
    private Label lblBaudLabel;

    private GroupBox grpMeasurement;
    private Label lblPrimaryLabel;
    private Label lblPrimaryValue;
    private Label lblSecondaryLabel;
    private Label lblSecondaryValue;
    private Button btnReadOnce;
    private Button btnContinuousRead;

    private GroupBox grpFunction;
    private Button btnDCV;
    private Button btnACV;
    private Button btnDCA;
    private Button btnACA;
    private Button btnRes2W;
    private Button btnRes4W;
    private Button btnFreq;
    private Button btnCont;
    private Button btnDiode;
    private Button btnTemp;

    private GroupBox grpAdvanced;
    private Label lblRateLabel;
    private ComboBox cmbDetectionRate;
    private CheckBox chkAutoRange;
    private Button btnRelative;
    private Button btnMinMax;
    private Button btnHold;
    private Button btnReset;
    private Button btnLocal;

    private GroupBox grpCommand;
    private TextBox txtCommand;
    private Button btnSendCommand;

    private GroupBox grpLog;
    private TextBox txtLog;
    private Button btnClearLog;

    private Label lblStatus;
}
