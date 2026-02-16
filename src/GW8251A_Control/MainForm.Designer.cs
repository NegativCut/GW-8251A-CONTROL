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
        grpConnection = new GroupBox();
        lblPortLabel = new Label();
        cmbPort = new ComboBox();
        btnRefreshPorts = new Button();
        lblBaudLabel = new Label();
        cmbBaudRate = new ComboBox();
        btnConnect = new Button();
        grpMeasurement = new GroupBox();
        lblPrimaryLabel = new Label();
        lblPrimaryValue = new Label();
        lblSecondaryLabel = new Label();
        lblSecondaryValue = new Label();
        btnReadOnce = new Button();
        btnContinuousRead = new Button();
        grpFunction = new GroupBox();
        btnDCV = new Button();
        btnACV = new Button();
        btnDCA = new Button();
        btnHold = new Button();
        btnMinMax = new Button();
        btnRelative = new Button();
        btnACA = new Button();
        btnRes2W = new Button();
        btnRes4W = new Button();
        btnFreq = new Button();
        btnCont = new Button();
        btnDiode = new Button();
        btnTemp = new Button();
        btnDCACV = new Button();
        btnDCACI = new Button();
        btnPeriod = new Button();
        lblTCType = new Label();
        cmbTCType = new ComboBox();
        lblSecDisplay = new Label();
        cmbSecDisplay = new ComboBox();
        btnSetSecDisplay = new Button();
        grpAdvanced = new GroupBox();
        lblRateLabel = new Label();
        cmbDetectionRate = new ComboBox();
        chkAutoRange = new CheckBox();
        btnReset = new Button();
        btnLocal = new Button();
        grpCommand = new GroupBox();
        txtCommand = new TextBox();
        btnSendCommand = new Button();
        grpLog = new GroupBox();
        txtLog = new TextBox();
        btnClearLog = new Button();
        grpDataLog = new GroupBox();
        btnLogCsv = new Button();
        btnGraph = new Button();
        lblCsvPath = new Label();
        txtCsvPath = new TextBox();
        btnBrowseCsv = new Button();
        lblLogStatus = new Label();
        grpConnection.SuspendLayout();
        grpMeasurement.SuspendLayout();
        grpFunction.SuspendLayout();
        grpAdvanced.SuspendLayout();
        grpCommand.SuspendLayout();
        grpLog.SuspendLayout();
        grpDataLog.SuspendLayout();
        SuspendLayout();
        // 
        // grpConnection
        // 
        grpConnection.Controls.Add(lblPortLabel);
        grpConnection.Controls.Add(cmbPort);
        grpConnection.Controls.Add(btnRefreshPorts);
        grpConnection.Controls.Add(lblBaudLabel);
        grpConnection.Controls.Add(cmbBaudRate);
        grpConnection.Controls.Add(btnConnect);
        grpConnection.ForeColor = SystemColors.ButtonFace;
        grpConnection.Location = new Point(14, 4);
        grpConnection.Margin = new Padding(3, 4, 3, 4);
        grpConnection.Name = "grpConnection";
        grpConnection.Padding = new Padding(3, 4, 3, 4);
        grpConnection.Size = new Size(601, 114);
        grpConnection.TabIndex = 0;
        grpConnection.TabStop = false;
        grpConnection.Text = "Connection";
        // 
        // lblPortLabel
        // 
        lblPortLabel.Location = new Point(134, 32);
        lblPortLabel.Name = "lblPortLabel";
        lblPortLabel.Size = new Size(40, 27);
        lblPortLabel.TabIndex = 0;
        lblPortLabel.Text = "Port:";
        // 
        // cmbPort
        // 
        cmbPort.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbPort.Location = new Point(180, 28);
        cmbPort.Margin = new Padding(3, 4, 3, 4);
        cmbPort.Name = "cmbPort";
        cmbPort.Size = new Size(102, 28);
        cmbPort.TabIndex = 1;
        // 
        // btnRefreshPorts
        // 
        btnRefreshPorts.Location = new Point(289, 27);
        btnRefreshPorts.Margin = new Padding(3, 4, 3, 4);
        btnRefreshPorts.Name = "btnRefreshPorts";
        btnRefreshPorts.Size = new Size(29, 33);
        btnRefreshPorts.TabIndex = 2;
        btnRefreshPorts.Text = "R";
        btnRefreshPorts.Click += btnRefreshPorts_Click;
        // 
        // lblBaudLabel
        // 
        lblBaudLabel.Location = new Point(323, 32);
        lblBaudLabel.Name = "lblBaudLabel";
        lblBaudLabel.Size = new Size(46, 27);
        lblBaudLabel.TabIndex = 3;
        lblBaudLabel.Text = "Baud:";
        // 
        // cmbBaudRate
        // 
        cmbBaudRate.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbBaudRate.Items.AddRange(new object[] { "115200", "57600", "38400", "19200", "9600" });
        cmbBaudRate.Location = new Point(374, 28);
        cmbBaudRate.Margin = new Padding(3, 4, 3, 4);
        cmbBaudRate.Name = "cmbBaudRate";
        cmbBaudRate.Size = new Size(79, 28);
        cmbBaudRate.TabIndex = 4;
        cmbBaudRate.SelectedIndexChanged += cmbBaudRate_SelectedIndexChanged;
        // 
        // btnConnect
        // 
        btnConnect.BackColor = SystemColors.ControlDarkDark;
        btnConnect.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnConnect.ForeColor = Color.Yellow;
        btnConnect.Location = new Point(17, 67);
        btnConnect.Margin = new Padding(3, 4, 3, 4);
        btnConnect.Name = "btnConnect";
        btnConnect.Size = new Size(567, 33);
        btnConnect.TabIndex = 5;
        btnConnect.Text = "Connect";
        btnConnect.UseVisualStyleBackColor = false;
        btnConnect.Click += btnConnect_Click;
        // 
        // grpMeasurement
        // 
        grpMeasurement.Controls.Add(lblPrimaryLabel);
        grpMeasurement.Controls.Add(lblPrimaryValue);
        grpMeasurement.Controls.Add(lblSecondaryLabel);
        grpMeasurement.Controls.Add(lblSecondaryValue);
        grpMeasurement.Controls.Add(btnReadOnce);
        grpMeasurement.Controls.Add(btnContinuousRead);
        grpMeasurement.ForeColor = SystemColors.ButtonFace;
        grpMeasurement.Location = new Point(14, 126);
        grpMeasurement.Margin = new Padding(3, 4, 3, 4);
        grpMeasurement.Name = "grpMeasurement";
        grpMeasurement.Padding = new Padding(3, 4, 3, 4);
        grpMeasurement.Size = new Size(601, 190);
        grpMeasurement.TabIndex = 1;
        grpMeasurement.TabStop = false;
        grpMeasurement.Text = "Measurement";
        // 
        // lblPrimaryLabel
        // 
        lblPrimaryLabel.Location = new Point(11, 19);
        lblPrimaryLabel.Name = "lblPrimaryLabel";
        lblPrimaryLabel.Size = new Size(69, 27);
        lblPrimaryLabel.TabIndex = 0;
        lblPrimaryLabel.Text = "Primary:";
        // 
        // lblPrimaryValue
        // 
        lblPrimaryValue.BackColor = Color.White;
        lblPrimaryValue.BorderStyle = BorderStyle.FixedSingle;
        lblPrimaryValue.Font = new Font("Consolas", 40F, FontStyle.Bold);
        lblPrimaryValue.ForeColor = Color.FromArgb(0, 192, 0);
        lblPrimaryValue.Location = new Point(11, 57);
        lblPrimaryValue.Name = "lblPrimaryValue";
        lblPrimaryValue.Size = new Size(573, 85);
        lblPrimaryValue.TabIndex = 1;
        lblPrimaryValue.Text = "----";
        lblPrimaryValue.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lblSecondaryLabel
        // 
        lblSecondaryLabel.Location = new Point(271, 17);
        lblSecondaryLabel.Name = "lblSecondaryLabel";
        lblSecondaryLabel.Size = new Size(84, 27);
        lblSecondaryLabel.TabIndex = 2;
        lblSecondaryLabel.Text = "Secondary:";
        // 
        // lblSecondaryValue
        // 
        lblSecondaryValue.Font = new Font("Consolas", 20F);
        lblSecondaryValue.ForeColor = Color.Chartreuse;
        lblSecondaryValue.Location = new Point(361, 12);
        lblSecondaryValue.Name = "lblSecondaryValue";
        lblSecondaryValue.Size = new Size(223, 45);
        lblSecondaryValue.TabIndex = 3;
        lblSecondaryValue.Text = "----";
        // 
        // btnReadOnce
        // 
        btnReadOnce.BackColor = SystemColors.ControlDarkDark;
        btnReadOnce.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnReadOnce.ForeColor = Color.Yellow;
        btnReadOnce.Location = new Point(175, 152);
        btnReadOnce.Margin = new Padding(3, 4, 3, 4);
        btnReadOnce.Name = "btnReadOnce";
        btnReadOnce.Size = new Size(114, 31);
        btnReadOnce.TabIndex = 4;
        btnReadOnce.Text = "Read Once";
        btnReadOnce.UseVisualStyleBackColor = false;
        btnReadOnce.Click += btnReadOnce_Click;
        // 
        // btnContinuousRead
        // 
        btnContinuousRead.BackColor = SystemColors.ControlDarkDark;
        btnContinuousRead.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnContinuousRead.ForeColor = Color.Yellow;
        btnContinuousRead.Location = new Point(301, 151);
        btnContinuousRead.Margin = new Padding(3, 4, 3, 4);
        btnContinuousRead.Name = "btnContinuousRead";
        btnContinuousRead.Size = new Size(114, 31);
        btnContinuousRead.TabIndex = 5;
        btnContinuousRead.Text = "Continuous";
        btnContinuousRead.UseVisualStyleBackColor = false;
        btnContinuousRead.Click += btnContinuousRead_Click;
        // 
        // grpFunction
        // 
        grpFunction.Controls.Add(btnDCV);
        grpFunction.Controls.Add(btnACV);
        grpFunction.Controls.Add(btnDCA);
        grpFunction.Controls.Add(btnHold);
        grpFunction.Controls.Add(btnMinMax);
        grpFunction.Controls.Add(btnRelative);
        grpFunction.Controls.Add(btnACA);
        grpFunction.Controls.Add(btnRes2W);
        grpFunction.Controls.Add(btnRes4W);
        grpFunction.Controls.Add(btnFreq);
        grpFunction.Controls.Add(btnCont);
        grpFunction.Controls.Add(btnDiode);
        grpFunction.Controls.Add(btnTemp);
        grpFunction.Controls.Add(btnDCACV);
        grpFunction.Controls.Add(btnDCACI);
        grpFunction.Controls.Add(btnPeriod);
        grpFunction.Controls.Add(lblTCType);
        grpFunction.Controls.Add(cmbTCType);
        grpFunction.Controls.Add(lblSecDisplay);
        grpFunction.Controls.Add(cmbSecDisplay);
        grpFunction.Controls.Add(btnSetSecDisplay);
        grpFunction.ForeColor = SystemColors.ButtonFace;
        grpFunction.Location = new Point(14, 317);
        grpFunction.Margin = new Padding(3, 4, 3, 4);
        grpFunction.Name = "grpFunction";
        grpFunction.Padding = new Padding(3, 4, 3, 4);
        grpFunction.Size = new Size(682, 160);
        grpFunction.TabIndex = 2;
        grpFunction.TabStop = false;
        grpFunction.Text = "Function";
        // 
        // btnDCV
        // 
        btnDCV.BackColor = SystemColors.ControlDarkDark;
        btnDCV.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnDCV.ForeColor = Color.Yellow;
        btnDCV.Location = new Point(90, 24);
        btnDCV.Margin = new Padding(3, 4, 3, 4);
        btnDCV.Name = "btnDCV";
        btnDCV.Size = new Size(74, 37);
        btnDCV.TabIndex = 0;
        btnDCV.Text = "DCV";
        btnDCV.UseVisualStyleBackColor = false;
        btnDCV.Click += btnDCV_Click;
        // 
        // btnACV
        // 
        btnACV.BackColor = SystemColors.ControlDarkDark;
        btnACV.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnACV.ForeColor = Color.Yellow;
        btnACV.Location = new Point(9, 24);
        btnACV.Margin = new Padding(3, 4, 3, 4);
        btnACV.Name = "btnACV";
        btnACV.Size = new Size(74, 37);
        btnACV.TabIndex = 1;
        btnACV.Text = "ACV";
        btnACV.UseVisualStyleBackColor = false;
        btnACV.Click += btnACV_Click;
        // 
        // btnDCA
        // 
        btnDCA.BackColor = SystemColors.ControlDarkDark;
        btnDCA.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnDCA.ForeColor = Color.Yellow;
        btnDCA.Location = new Point(254, 24);
        btnDCA.Margin = new Padding(3, 4, 3, 4);
        btnDCA.Name = "btnDCA";
        btnDCA.Size = new Size(74, 37);
        btnDCA.TabIndex = 2;
        btnDCA.Text = "DCI";
        btnDCA.UseVisualStyleBackColor = false;
        btnDCA.Click += btnDCA_Click;
        // 
        // btnHold
        // 
        btnHold.BackColor = SystemColors.ControlDarkDark;
        btnHold.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnHold.ForeColor = Color.Yellow;
        btnHold.Location = new Point(590, 69);
        btnHold.Margin = new Padding(3, 4, 3, 4);
        btnHold.Name = "btnHold";
        btnHold.Size = new Size(74, 37);
        btnHold.TabIndex = 5;
        btnHold.Text = "Hold";
        btnHold.UseVisualStyleBackColor = false;
        btnHold.Click += btnHold_Click;
        // 
        // btnMinMax
        // 
        btnMinMax.BackColor = SystemColors.ControlDarkDark;
        btnMinMax.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnMinMax.ForeColor = Color.Yellow;
        btnMinMax.Location = new Point(498, 69);
        btnMinMax.Margin = new Padding(3, 4, 3, 4);
        btnMinMax.Name = "btnMinMax";
        btnMinMax.Size = new Size(84, 37);
        btnMinMax.TabIndex = 4;
        btnMinMax.Text = "Min/Max";
        btnMinMax.UseVisualStyleBackColor = false;
        btnMinMax.Click += btnMinMax_Click;
        // 
        // btnRelative
        // 
        btnRelative.BackColor = SystemColors.ControlDarkDark;
        btnRelative.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnRelative.ForeColor = Color.Yellow;
        btnRelative.Location = new Point(417, 69);
        btnRelative.Margin = new Padding(3, 4, 3, 4);
        btnRelative.Name = "btnRelative";
        btnRelative.Size = new Size(74, 37);
        btnRelative.TabIndex = 3;
        btnRelative.Text = "REL";
        btnRelative.UseVisualStyleBackColor = false;
        btnRelative.Click += btnRelative_Click;
        // 
        // btnACA
        // 
        btnACA.BackColor = SystemColors.ControlDarkDark;
        btnACA.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnACA.ForeColor = Color.Yellow;
        btnACA.Location = new Point(172, 24);
        btnACA.Margin = new Padding(3, 4, 3, 4);
        btnACA.Name = "btnACA";
        btnACA.Size = new Size(74, 37);
        btnACA.TabIndex = 3;
        btnACA.Text = "ACI";
        btnACA.UseVisualStyleBackColor = false;
        btnACA.Click += btnACA_Click;
        // 
        // btnRes2W
        // 
        btnRes2W.BackColor = SystemColors.ControlDarkDark;
        btnRes2W.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnRes2W.ForeColor = Color.Yellow;
        btnRes2W.Location = new Point(335, 24);
        btnRes2W.Margin = new Padding(3, 4, 3, 4);
        btnRes2W.Name = "btnRes2W";
        btnRes2W.Size = new Size(74, 37);
        btnRes2W.TabIndex = 4;
        btnRes2W.Text = "2WΩ";
        btnRes2W.UseVisualStyleBackColor = false;
        btnRes2W.Click += btnRes2W_Click;
        // 
        // btnRes4W
        // 
        btnRes4W.BackColor = SystemColors.ControlDarkDark;
        btnRes4W.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnRes4W.ForeColor = Color.Yellow;
        btnRes4W.Location = new Point(416, 24);
        btnRes4W.Margin = new Padding(3, 4, 3, 4);
        btnRes4W.Name = "btnRes4W";
        btnRes4W.Size = new Size(74, 37);
        btnRes4W.TabIndex = 5;
        btnRes4W.Text = "4WΩ";
        btnRes4W.UseVisualStyleBackColor = false;
        btnRes4W.Click += btnRes4W_Click;
        // 
        // btnFreq
        // 
        btnFreq.BackColor = SystemColors.ControlDarkDark;
        btnFreq.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnFreq.ForeColor = Color.Yellow;
        btnFreq.Location = new Point(255, 69);
        btnFreq.Margin = new Padding(3, 4, 3, 4);
        btnFreq.Name = "btnFreq";
        btnFreq.Size = new Size(74, 37);
        btnFreq.TabIndex = 6;
        btnFreq.Text = "Freq";
        btnFreq.UseVisualStyleBackColor = false;
        btnFreq.Click += btnFreq_Click;
        // 
        // btnCont
        // 
        btnCont.BackColor = SystemColors.ControlDarkDark;
        btnCont.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnCont.ForeColor = Color.Yellow;
        btnCont.Location = new Point(173, 69);
        btnCont.Margin = new Padding(3, 4, 3, 4);
        btnCont.Name = "btnCont";
        btnCont.Size = new Size(74, 37);
        btnCont.TabIndex = 7;
        btnCont.Text = "Cont";
        btnCont.UseVisualStyleBackColor = false;
        btnCont.Click += btnCont_Click;
        // 
        // btnDiode
        // 
        btnDiode.BackColor = SystemColors.ControlDarkDark;
        btnDiode.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnDiode.ForeColor = Color.Yellow;
        btnDiode.Location = new Point(90, 69);
        btnDiode.Margin = new Padding(3, 4, 3, 4);
        btnDiode.Name = "btnDiode";
        btnDiode.Size = new Size(74, 37);
        btnDiode.TabIndex = 8;
        btnDiode.Text = "Diode";
        btnDiode.UseVisualStyleBackColor = false;
        btnDiode.Click += btnDiode_Click;
        // 
        // btnTemp
        // 
        btnTemp.BackColor = SystemColors.ControlDarkDark;
        btnTemp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnTemp.ForeColor = Color.Yellow;
        btnTemp.Location = new Point(9, 69);
        btnTemp.Margin = new Padding(3, 4, 3, 4);
        btnTemp.Name = "btnTemp";
        btnTemp.Size = new Size(74, 37);
        btnTemp.TabIndex = 9;
        btnTemp.Text = "Temp";
        btnTemp.UseVisualStyleBackColor = false;
        btnTemp.Click += btnTemp_Click;
        // 
        // btnDCACV
        // 
        btnDCACV.BackColor = SystemColors.ControlDarkDark;
        btnDCACV.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnDCACV.ForeColor = Color.Yellow;
        btnDCACV.Location = new Point(497, 24);
        btnDCACV.Margin = new Padding(3, 4, 3, 4);
        btnDCACV.Name = "btnDCACV";
        btnDCACV.Size = new Size(84, 37);
        btnDCACV.TabIndex = 10;
        btnDCACV.Text = "DC+ACV";
        btnDCACV.UseVisualStyleBackColor = false;
        btnDCACV.Click += btnDCACV_Click;
        // 
        // btnDCACI
        // 
        btnDCACI.BackColor = SystemColors.ControlDarkDark;
        btnDCACI.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnDCACI.ForeColor = Color.Yellow;
        btnDCACI.Location = new Point(588, 24);
        btnDCACI.Margin = new Padding(3, 4, 3, 4);
        btnDCACI.Name = "btnDCACI";
        btnDCACI.Size = new Size(84, 37);
        btnDCACI.TabIndex = 11;
        btnDCACI.Text = "DC+ACI";
        btnDCACI.UseVisualStyleBackColor = false;
        btnDCACI.Click += btnDCACI_Click;
        // 
        // btnPeriod
        // 
        btnPeriod.BackColor = SystemColors.ControlDarkDark;
        btnPeriod.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnPeriod.ForeColor = Color.Yellow;
        btnPeriod.Location = new Point(336, 69);
        btnPeriod.Margin = new Padding(3, 4, 3, 4);
        btnPeriod.Name = "btnPeriod";
        btnPeriod.Size = new Size(74, 37);
        btnPeriod.TabIndex = 12;
        btnPeriod.Text = "Period";
        btnPeriod.UseVisualStyleBackColor = false;
        btnPeriod.Click += btnPeriod_Click;
        // 
        // lblTCType
        // 
        lblTCType.Location = new Point(9, 121);
        lblTCType.Name = "lblTCType";
        lblTCType.Size = new Size(28, 27);
        lblTCType.TabIndex = 13;
        lblTCType.Text = "TC:";
        // 
        // cmbTCType
        // 
        cmbTCType.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbTCType.Items.AddRange(new object[] { "J", "K", "T" });
        cmbTCType.Location = new Point(40, 117);
        cmbTCType.Margin = new Padding(3, 4, 3, 4);
        cmbTCType.Name = "cmbTCType";
        cmbTCType.Size = new Size(55, 28);
        cmbTCType.TabIndex = 14;
        cmbTCType.SelectedIndexChanged += cmbTCType_SelectedIndexChanged;
        // 
        // lblSecDisplay
        // 
        lblSecDisplay.Location = new Point(120, 121);
        lblSecDisplay.Name = "lblSecDisplay";
        lblSecDisplay.Size = new Size(35, 27);
        lblSecDisplay.TabIndex = 15;
        lblSecDisplay.Text = "2nd:";
        // 
        // cmbSecDisplay
        // 
        cmbSecDisplay.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbSecDisplay.Items.AddRange(new object[] { "Off", "DCV", "ACV", "DCI", "ACI", "2WΩ", "4WΩ", "Freq", "Period", "Temp" });
        cmbSecDisplay.Location = new Point(158, 117);
        cmbSecDisplay.Margin = new Padding(3, 4, 3, 4);
        cmbSecDisplay.Name = "cmbSecDisplay";
        cmbSecDisplay.Size = new Size(90, 28);
        cmbSecDisplay.TabIndex = 16;
        cmbSecDisplay.SelectedIndexChanged += cmbSecDisplay_SelectedIndexChanged;
        // 
        // btnSetSecDisplay
        // 
        btnSetSecDisplay.BackColor = SystemColors.ControlDarkDark;
        btnSetSecDisplay.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnSetSecDisplay.ForeColor = Color.Yellow;
        btnSetSecDisplay.Location = new Point(254, 114);
        btnSetSecDisplay.Margin = new Padding(3, 4, 3, 4);
        btnSetSecDisplay.Name = "btnSetSecDisplay";
        btnSetSecDisplay.Size = new Size(50, 33);
        btnSetSecDisplay.TabIndex = 17;
        btnSetSecDisplay.Text = "Set";
        btnSetSecDisplay.UseVisualStyleBackColor = false;
        btnSetSecDisplay.Click += btnSetSecDisplay_Click;
        // 
        // grpAdvanced
        // 
        grpAdvanced.Controls.Add(lblRateLabel);
        grpAdvanced.Controls.Add(cmbDetectionRate);
        grpAdvanced.Controls.Add(chkAutoRange);
        grpAdvanced.Controls.Add(btnReset);
        grpAdvanced.Controls.Add(btnLocal);
        grpAdvanced.ForeColor = SystemColors.ButtonFace;
        grpAdvanced.Location = new Point(621, 4);
        grpAdvanced.Margin = new Padding(3, 4, 3, 4);
        grpAdvanced.Name = "grpAdvanced";
        grpAdvanced.Padding = new Padding(3, 4, 3, 4);
        grpAdvanced.Size = new Size(411, 79);
        grpAdvanced.TabIndex = 3;
        grpAdvanced.TabStop = false;
        grpAdvanced.Text = "Advanced";
        grpAdvanced.Enter += grpAdvanced_Enter;
        // 
        // lblRateLabel
        // 
        lblRateLabel.Location = new Point(11, 33);
        lblRateLabel.Name = "lblRateLabel";
        lblRateLabel.Size = new Size(46, 27);
        lblRateLabel.TabIndex = 0;
        lblRateLabel.Text = "Rate:";
        // 
        // cmbDetectionRate
        // 
        cmbDetectionRate.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbDetectionRate.Items.AddRange(new object[] { "Fast", "Medium", "Slow" });
        cmbDetectionRate.Location = new Point(63, 29);
        cmbDetectionRate.Margin = new Padding(3, 4, 3, 4);
        cmbDetectionRate.Name = "cmbDetectionRate";
        cmbDetectionRate.Size = new Size(91, 28);
        cmbDetectionRate.TabIndex = 1;
        cmbDetectionRate.SelectedIndexChanged += cmbDetectionRate_SelectedIndexChanged;
        // 
        // chkAutoRange
        // 
        chkAutoRange.Checked = true;
        chkAutoRange.CheckState = CheckState.Checked;
        chkAutoRange.Location = new Point(166, 32);
        chkAutoRange.Margin = new Padding(3, 4, 3, 4);
        chkAutoRange.Name = "chkAutoRange";
        chkAutoRange.Size = new Size(103, 27);
        chkAutoRange.TabIndex = 2;
        chkAutoRange.Text = "Auto Range";
        chkAutoRange.CheckedChanged += chkAutoRange_CheckedChanged;
        // 
        // btnReset
        // 
        btnReset.BackColor = SystemColors.ControlDarkDark;
        btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnReset.ForeColor = Color.Yellow;
        btnReset.Location = new Point(274, 29);
        btnReset.Margin = new Padding(3, 4, 3, 4);
        btnReset.Name = "btnReset";
        btnReset.Size = new Size(63, 33);
        btnReset.TabIndex = 6;
        btnReset.Text = "Reset";
        btnReset.UseVisualStyleBackColor = false;
        btnReset.Click += btnReset_Click;
        // 
        // btnLocal
        // 
        btnLocal.BackColor = SystemColors.ControlDarkDark;
        btnLocal.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnLocal.ForeColor = Color.Yellow;
        btnLocal.Location = new Point(343, 29);
        btnLocal.Margin = new Padding(3, 4, 3, 4);
        btnLocal.Name = "btnLocal";
        btnLocal.Size = new Size(57, 33);
        btnLocal.TabIndex = 7;
        btnLocal.Text = "Local";
        btnLocal.UseVisualStyleBackColor = false;
        btnLocal.Click += btnLocal_Click;
        // 
        // grpCommand
        // 
        grpCommand.Controls.Add(txtCommand);
        grpCommand.Controls.Add(btnSendCommand);
        grpCommand.ForeColor = SystemColors.ButtonFace;
        grpCommand.Location = new Point(621, 85);
        grpCommand.Margin = new Padding(3, 4, 3, 4);
        grpCommand.Name = "grpCommand";
        grpCommand.Padding = new Padding(3, 4, 3, 4);
        grpCommand.Size = new Size(411, 73);
        grpCommand.TabIndex = 4;
        grpCommand.TabStop = false;
        grpCommand.Text = "Manual Command";
        // 
        // txtCommand
        // 
        txtCommand.Location = new Point(11, 29);
        txtCommand.Margin = new Padding(3, 4, 3, 4);
        txtCommand.Name = "txtCommand";
        txtCommand.Size = new Size(308, 27);
        txtCommand.TabIndex = 0;
        txtCommand.KeyDown += txtCommand_KeyDown;
        // 
        // btnSendCommand
        // 
        btnSendCommand.BackColor = SystemColors.ControlDarkDark;
        btnSendCommand.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnSendCommand.ForeColor = Color.Yellow;
        btnSendCommand.Location = new Point(326, 28);
        btnSendCommand.Margin = new Padding(3, 4, 3, 4);
        btnSendCommand.Name = "btnSendCommand";
        btnSendCommand.Size = new Size(74, 33);
        btnSendCommand.TabIndex = 1;
        btnSendCommand.Text = "Send";
        btnSendCommand.UseVisualStyleBackColor = false;
        btnSendCommand.Click += btnSendCommand_Click;
        // 
        // grpLog
        // 
        grpLog.Controls.Add(txtLog);
        grpLog.Controls.Add(btnClearLog);
        grpLog.ForeColor = SystemColors.ButtonFace;
        grpLog.Location = new Point(621, 160);
        grpLog.Margin = new Padding(3, 4, 3, 4);
        grpLog.Name = "grpLog";
        grpLog.Padding = new Padding(3, 4, 3, 4);
        grpLog.Size = new Size(411, 156);
        grpLog.TabIndex = 5;
        grpLog.TabStop = false;
        grpLog.Text = "Log";
        // 
        // txtLog
        // 
        txtLog.BackColor = Color.White;
        txtLog.Font = new Font("Consolas", 8F);
        txtLog.Location = new Point(11, 22);
        txtLog.Margin = new Padding(3, 4, 3, 4);
        txtLog.Multiline = true;
        txtLog.Name = "txtLog";
        txtLog.ReadOnly = true;
        txtLog.ScrollBars = ScrollBars.Vertical;
        txtLog.Size = new Size(308, 126);
        txtLog.TabIndex = 0;
        // 
        // btnClearLog
        // 
        btnClearLog.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnClearLog.ForeColor = Color.Yellow;
        btnClearLog.Location = new Point(325, 22);
        btnClearLog.Margin = new Padding(3, 4, 3, 4);
        btnClearLog.Name = "btnClearLog";
        btnClearLog.Size = new Size(74, 31);
        btnClearLog.TabIndex = 1;
        btnClearLog.Text = "Clear";
        btnClearLog.Click += btnClearLog_Click;
        //
        // grpDataLog
        //
        grpDataLog.Controls.Add(btnLogCsv);
        grpDataLog.Controls.Add(btnGraph);
        grpDataLog.Controls.Add(lblCsvPath);
        grpDataLog.Controls.Add(txtCsvPath);
        grpDataLog.Controls.Add(btnBrowseCsv);
        grpDataLog.Controls.Add(lblLogStatus);
        grpDataLog.ForeColor = SystemColors.ButtonFace;
        grpDataLog.Location = new Point(700, 317);
        grpDataLog.Margin = new Padding(3, 4, 3, 4);
        grpDataLog.Name = "grpDataLog";
        grpDataLog.Padding = new Padding(3, 4, 3, 4);
        grpDataLog.Size = new Size(332, 160);
        grpDataLog.TabIndex = 6;
        grpDataLog.TabStop = false;
        grpDataLog.Text = "Data Logging";
        //
        // lblCsvPath
        //
        lblCsvPath.Location = new Point(9, 24);
        lblCsvPath.Name = "lblCsvPath";
        lblCsvPath.Size = new Size(38, 27);
        lblCsvPath.TabIndex = 0;
        lblCsvPath.Text = "Path:";
        //
        // txtCsvPath
        //
        txtCsvPath.Location = new Point(50, 21);
        txtCsvPath.Margin = new Padding(3, 4, 3, 4);
        txtCsvPath.Name = "txtCsvPath";
        txtCsvPath.Size = new Size(236, 27);
        txtCsvPath.TabIndex = 1;
        //
        // btnBrowseCsv
        //
        btnBrowseCsv.Location = new Point(292, 20);
        btnBrowseCsv.Margin = new Padding(3, 4, 3, 4);
        btnBrowseCsv.Name = "btnBrowseCsv";
        btnBrowseCsv.Size = new Size(30, 30);
        btnBrowseCsv.TabIndex = 2;
        btnBrowseCsv.Text = "...";
        btnBrowseCsv.Click += btnBrowseCsv_Click;
        //
        // btnLogCsv
        //
        btnLogCsv.BackColor = SystemColors.ControlDarkDark;
        btnLogCsv.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnLogCsv.ForeColor = Color.Yellow;
        btnLogCsv.Location = new Point(9, 60);
        btnLogCsv.Margin = new Padding(3, 4, 3, 4);
        btnLogCsv.Name = "btnLogCsv";
        btnLogCsv.Size = new Size(150, 33);
        btnLogCsv.TabIndex = 3;
        btnLogCsv.Text = "Start Logging";
        btnLogCsv.UseVisualStyleBackColor = false;
        btnLogCsv.Click += btnLogCsv_Click;
        //
        // btnGraph
        //
        btnGraph.BackColor = SystemColors.ControlDarkDark;
        btnGraph.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        btnGraph.ForeColor = Color.Yellow;
        btnGraph.Location = new Point(168, 60);
        btnGraph.Margin = new Padding(3, 4, 3, 4);
        btnGraph.Name = "btnGraph";
        btnGraph.Size = new Size(150, 33);
        btnGraph.TabIndex = 4;
        btnGraph.Text = "Graph";
        btnGraph.UseVisualStyleBackColor = false;
        btnGraph.Click += btnGraph_Click;
        //
        // lblLogStatus
        //
        lblLogStatus.ForeColor = Color.DarkGray;
        lblLogStatus.Location = new Point(9, 104);
        lblLogStatus.Name = "lblLogStatus";
        lblLogStatus.Size = new Size(313, 47);
        lblLogStatus.TabIndex = 5;
        lblLogStatus.Text = "Idle";
        //
        // MainForm
        //
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ControlDarkDark;
        ClientSize = new Size(1044, 491);
        Controls.Add(grpConnection);
        Controls.Add(grpMeasurement);
        Controls.Add(grpFunction);
        Controls.Add(grpAdvanced);
        Controls.Add(grpCommand);
        Controls.Add(grpLog);
        Controls.Add(grpDataLog);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(3, 4, 3, 4);
        MaximizeBox = false;
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "GW-8251A Control";
        FormClosing += MainForm_FormClosing;
        Load += MainForm_Load;
        grpConnection.ResumeLayout(false);
        grpMeasurement.ResumeLayout(false);
        grpFunction.ResumeLayout(false);
        grpAdvanced.ResumeLayout(false);
        grpCommand.ResumeLayout(false);
        grpCommand.PerformLayout();
        grpLog.ResumeLayout(false);
        grpLog.PerformLayout();
        grpDataLog.ResumeLayout(false);
        grpDataLog.PerformLayout();
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

    private Button btnDCACV;
    private Button btnDCACI;
    private Button btnPeriod;
    private Label lblTCType;
    private ComboBox cmbTCType;
    private Label lblSecDisplay;
    private ComboBox cmbSecDisplay;
    private Button btnSetSecDisplay;

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

    private GroupBox grpDataLog;
    private Button btnLogCsv;
    private Button btnGraph;
    private Label lblCsvPath;
    private TextBox txtCsvPath;
    private Button btnBrowseCsv;
    private Label lblLogStatus;
}
