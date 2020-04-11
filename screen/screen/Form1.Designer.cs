namespace screen
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpModes = new System.Windows.Forms.GroupBox();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnMode8 = new System.Windows.Forms.Button();
            this.btnMode7 = new System.Windows.Forms.Button();
            this.btnMode6 = new System.Windows.Forms.Button();
            this.btnMode5 = new System.Windows.Forms.Button();
            this.btnMode4 = new System.Windows.Forms.Button();
            this.btnMode3 = new System.Windows.Forms.Button();
            this.btnMode2 = new System.Windows.Forms.Button();
            this.btnMode1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtToSerial = new System.Windows.Forms.TextBox();
            this.txtFromSerial = new System.Windows.Forms.TextBox();
            this.btnBeep = new System.Windows.Forms.Button();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numSP = new System.Windows.Forms.NumericUpDown();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.numLD = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numLC = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numLB = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numLA = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.numTF = new System.Windows.Forms.NumericUpDown();
            this.tF = new System.Windows.Forms.Label();
            this.numTE = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numTD = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numTC = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numTB = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numTA = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtDebug = new System.Windows.Forms.TextBox();
            this.btnTestAlarm = new System.Windows.Forms.Button();
            this.btnTestRemoteAlarm = new System.Windows.Forms.Button();
            this.btnGO = new System.Windows.Forms.Button();
            this.tmrWatchdog1 = new System.Windows.Forms.Timer(this.components);
            this.btnAlarmOff = new System.Windows.Forms.Button();
            this.tmrMasterAlarm = new System.Windows.Forms.Timer(this.components);
            this.lblAlarmBattery = new System.Windows.Forms.Label();
            this.lblAlarmPort = new System.Windows.Forms.Label();
            this.lblAlarmPressure = new System.Windows.Forms.Label();
            this.lblAlarmNetwork = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblAlarmWD1 = new System.Windows.Forms.Label();
            this.lblMasterAlarm = new System.Windows.Forms.Label();
            this.grpModes.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTA)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpModes
            // 
            this.grpModes.Controls.Add(this.btnAlarmOff);
            this.grpModes.Controls.Add(this.btnTestRemoteAlarm);
            this.grpModes.Controls.Add(this.btnTestAlarm);
            this.grpModes.Controls.Add(this.btnUndo);
            this.grpModes.Controls.Add(this.btnMode8);
            this.grpModes.Controls.Add(this.btnMode7);
            this.grpModes.Controls.Add(this.btnMode6);
            this.grpModes.Controls.Add(this.btnMode5);
            this.grpModes.Controls.Add(this.btnMode4);
            this.grpModes.Controls.Add(this.btnMode3);
            this.grpModes.Controls.Add(this.btnMode2);
            this.grpModes.Controls.Add(this.btnMode1);
            this.grpModes.Location = new System.Drawing.Point(211, 12);
            this.grpModes.Name = "grpModes";
            this.grpModes.Size = new System.Drawing.Size(263, 142);
            this.grpModes.TabIndex = 0;
            this.grpModes.TabStop = false;
            this.grpModes.Text = "Modes";
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(184, 16);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(75, 23);
            this.btnUndo.TabIndex = 1;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            // 
            // btnMode8
            // 
            this.btnMode8.Location = new System.Drawing.Point(88, 109);
            this.btnMode8.Name = "btnMode8";
            this.btnMode8.Size = new System.Drawing.Size(75, 23);
            this.btnMode8.TabIndex = 7;
            this.btnMode8.Text = "Mode8";
            this.btnMode8.UseVisualStyleBackColor = true;
            this.btnMode8.Click += new System.EventHandler(this.btnMode8_Click);
            // 
            // btnMode7
            // 
            this.btnMode7.Location = new System.Drawing.Point(89, 79);
            this.btnMode7.Name = "btnMode7";
            this.btnMode7.Size = new System.Drawing.Size(75, 23);
            this.btnMode7.TabIndex = 6;
            this.btnMode7.Text = "Mode7";
            this.btnMode7.UseVisualStyleBackColor = true;
            this.btnMode7.Click += new System.EventHandler(this.btnMode7_Click);
            // 
            // btnMode6
            // 
            this.btnMode6.Location = new System.Drawing.Point(89, 49);
            this.btnMode6.Name = "btnMode6";
            this.btnMode6.Size = new System.Drawing.Size(75, 23);
            this.btnMode6.TabIndex = 5;
            this.btnMode6.Text = "Mode6";
            this.btnMode6.UseVisualStyleBackColor = true;
            this.btnMode6.Click += new System.EventHandler(this.btnMode6_Click);
            // 
            // btnMode5
            // 
            this.btnMode5.Location = new System.Drawing.Point(88, 19);
            this.btnMode5.Name = "btnMode5";
            this.btnMode5.Size = new System.Drawing.Size(75, 23);
            this.btnMode5.TabIndex = 4;
            this.btnMode5.Text = "Mode5";
            this.btnMode5.UseVisualStyleBackColor = true;
            this.btnMode5.Click += new System.EventHandler(this.btnMode5_Click);
            // 
            // btnMode4
            // 
            this.btnMode4.Location = new System.Drawing.Point(7, 109);
            this.btnMode4.Name = "btnMode4";
            this.btnMode4.Size = new System.Drawing.Size(75, 23);
            this.btnMode4.TabIndex = 3;
            this.btnMode4.Text = "Mode4";
            this.btnMode4.UseVisualStyleBackColor = true;
            this.btnMode4.Click += new System.EventHandler(this.btnMode4_Click);
            // 
            // btnMode3
            // 
            this.btnMode3.Location = new System.Drawing.Point(7, 79);
            this.btnMode3.Name = "btnMode3";
            this.btnMode3.Size = new System.Drawing.Size(75, 23);
            this.btnMode3.TabIndex = 2;
            this.btnMode3.Text = "Mode3";
            this.btnMode3.UseVisualStyleBackColor = true;
            this.btnMode3.Click += new System.EventHandler(this.btnMode3_Click);
            // 
            // btnMode2
            // 
            this.btnMode2.Location = new System.Drawing.Point(7, 49);
            this.btnMode2.Name = "btnMode2";
            this.btnMode2.Size = new System.Drawing.Size(75, 23);
            this.btnMode2.TabIndex = 1;
            this.btnMode2.Text = "Mode2";
            this.btnMode2.UseVisualStyleBackColor = true;
            this.btnMode2.Click += new System.EventHandler(this.btnMode2_Click);
            // 
            // btnMode1
            // 
            this.btnMode1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnMode1.Location = new System.Drawing.Point(6, 19);
            this.btnMode1.Name = "btnMode1";
            this.btnMode1.Size = new System.Drawing.Size(75, 23);
            this.btnMode1.TabIndex = 0;
            this.btnMode1.Text = "Mode1";
            this.btnMode1.UseVisualStyleBackColor = false;
            this.btnMode1.Click += new System.EventHandler(this.btnMode1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtToSerial);
            this.groupBox2.Controls.Add(this.txtFromSerial);
            this.groupBox2.Controls.Add(this.btnBeep);
            this.groupBox2.Controls.Add(this.cmbPort);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 141);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setup";
            // 
            // txtToSerial
            // 
            this.txtToSerial.Location = new System.Drawing.Point(112, 47);
            this.txtToSerial.Multiline = true;
            this.txtToSerial.Name = "txtToSerial";
            this.txtToSerial.ReadOnly = true;
            this.txtToSerial.Size = new System.Drawing.Size(75, 85);
            this.txtToSerial.TabIndex = 3;
            // 
            // txtFromSerial
            // 
            this.txtFromSerial.Location = new System.Drawing.Point(7, 47);
            this.txtFromSerial.Multiline = true;
            this.txtFromSerial.Name = "txtFromSerial";
            this.txtFromSerial.ReadOnly = true;
            this.txtFromSerial.Size = new System.Drawing.Size(95, 85);
            this.txtFromSerial.TabIndex = 2;
            // 
            // btnBeep
            // 
            this.btnBeep.Location = new System.Drawing.Point(112, 17);
            this.btnBeep.Name = "btnBeep";
            this.btnBeep.Size = new System.Drawing.Size(75, 23);
            this.btnBeep.TabIndex = 1;
            this.btnBeep.Text = "Beep";
            this.btnBeep.UseVisualStyleBackColor = true;
            this.btnBeep.Click += new System.EventHandler(this.btnBeep_Click);
            // 
            // cmbPort
            // 
            this.cmbPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4"});
            this.cmbPort.Location = new System.Drawing.Point(7, 19);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(95, 21);
            this.cmbPort.TabIndex = 0;
            this.cmbPort.SelectedIndexChanged += new System.EventHandler(this.cmbPort_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblMasterAlarm);
            this.groupBox3.Controls.Add(this.lblAlarmWD1);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.lblAlarmNetwork);
            this.groupBox3.Controls.Add(this.lblAlarmPressure);
            this.groupBox3.Controls.Add(this.lblAlarmPort);
            this.groupBox3.Controls.Add(this.lblAlarmBattery);
            this.groupBox3.Location = new System.Drawing.Point(480, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(196, 72);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Alarms";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGO);
            this.groupBox4.Controls.Add(this.numSP);
            this.groupBox4.Controls.Add(this.lblSpeed);
            this.groupBox4.Controls.Add(this.numLD);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.numLC);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.numLB);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.numLA);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtCommand);
            this.groupBox4.Controls.Add(this.numTF);
            this.groupBox4.Controls.Add(this.tF);
            this.groupBox4.Controls.Add(this.numTE);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.numTD);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.numTC);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.numTB);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.numTA);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(13, 160);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(260, 172);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Customize";
            // 
            // numSP
            // 
            this.numSP.Location = new System.Drawing.Point(198, 14);
            this.numSP.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.numSP.Name = "numSP";
            this.numSP.Size = new System.Drawing.Size(53, 20);
            this.numSP.TabIndex = 23;
            this.numSP.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this.numSP.ValueChanged += new System.EventHandler(this.numSP_ValueChanged);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(175, 16);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(18, 13);
            this.lblSpeed.TabIndex = 22;
            this.lblSpeed.Text = "sp";
            // 
            // numLD
            // 
            this.numLD.Location = new System.Drawing.Point(198, 118);
            this.numLD.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numLD.Name = "numLD";
            this.numLD.Size = new System.Drawing.Size(53, 20);
            this.numLD.TabIndex = 21;
            this.numLD.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numLD.ValueChanged += new System.EventHandler(this.numLD_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(175, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "LD";
            // 
            // numLC
            // 
            this.numLC.Location = new System.Drawing.Point(198, 92);
            this.numLC.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numLC.Name = "numLC";
            this.numLC.Size = new System.Drawing.Size(53, 20);
            this.numLC.TabIndex = 19;
            this.numLC.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numLC.ValueChanged += new System.EventHandler(this.numLC_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(175, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "LC";
            // 
            // numLB
            // 
            this.numLB.Location = new System.Drawing.Point(198, 66);
            this.numLB.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numLB.Name = "numLB";
            this.numLB.Size = new System.Drawing.Size(53, 20);
            this.numLB.TabIndex = 17;
            this.numLB.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numLB.ValueChanged += new System.EventHandler(this.numLB_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(175, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "LB";
            // 
            // numLA
            // 
            this.numLA.Location = new System.Drawing.Point(198, 40);
            this.numLA.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numLA.Name = "numLA";
            this.numLA.Size = new System.Drawing.Size(53, 20);
            this.numLA.TabIndex = 15;
            this.numLA.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.numLA.ValueChanged += new System.EventHandler(this.numLA_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "LA";
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(6, 144);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(170, 20);
            this.txtCommand.TabIndex = 13;
            // 
            // numTF
            // 
            this.numTF.Location = new System.Drawing.Point(111, 116);
            this.numTF.Name = "numTF";
            this.numTF.ReadOnly = true;
            this.numTF.Size = new System.Drawing.Size(53, 20);
            this.numTF.TabIndex = 12;
            this.numTF.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numTF.ValueChanged += new System.EventHandler(this.numTF_ValueChanged);
            // 
            // tF
            // 
            this.tF.AutoSize = true;
            this.tF.Location = new System.Drawing.Point(88, 118);
            this.tF.Name = "tF";
            this.tF.Size = new System.Drawing.Size(16, 13);
            this.tF.TabIndex = 11;
            this.tF.Text = "tF";
            // 
            // numTE
            // 
            this.numTE.Location = new System.Drawing.Point(111, 90);
            this.numTE.Name = "numTE";
            this.numTE.Size = new System.Drawing.Size(53, 20);
            this.numTE.TabIndex = 10;
            this.numTE.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numTE.ValueChanged += new System.EventHandler(this.numTE_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "tE";
            // 
            // numTD
            // 
            this.numTD.Location = new System.Drawing.Point(111, 64);
            this.numTD.Name = "numTD";
            this.numTD.Size = new System.Drawing.Size(53, 20);
            this.numTD.TabIndex = 8;
            this.numTD.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numTD.ValueChanged += new System.EventHandler(this.numTD_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "tD";
            // 
            // numTC
            // 
            this.numTC.Location = new System.Drawing.Point(28, 116);
            this.numTC.Name = "numTC";
            this.numTC.Size = new System.Drawing.Size(53, 20);
            this.numTC.TabIndex = 6;
            this.numTC.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numTC.ValueChanged += new System.EventHandler(this.numTC_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "tC";
            // 
            // numTB
            // 
            this.numTB.Location = new System.Drawing.Point(28, 90);
            this.numTB.Name = "numTB";
            this.numTB.Size = new System.Drawing.Size(53, 20);
            this.numTB.TabIndex = 4;
            this.numTB.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numTB.ValueChanged += new System.EventHandler(this.numTB_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "tB";
            // 
            // numTA
            // 
            this.numTA.Location = new System.Drawing.Point(28, 64);
            this.numTA.Name = "numTA";
            this.numTA.Size = new System.Drawing.Size(53, 20);
            this.numTA.TabIndex = 2;
            this.numTA.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTA.ValueChanged += new System.EventHandler(this.numTA_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "tA";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtDebug);
            this.groupBox5.Location = new System.Drawing.Point(480, 91);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(196, 63);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Debug";
            // 
            // txtDebug
            // 
            this.txtDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebug.Location = new System.Drawing.Point(12, 19);
            this.txtDebug.Multiline = true;
            this.txtDebug.Name = "txtDebug";
            this.txtDebug.Size = new System.Drawing.Size(173, 38);
            this.txtDebug.TabIndex = 0;
            // 
            // btnTestAlarm
            // 
            this.btnTestAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestAlarm.Location = new System.Drawing.Point(184, 88);
            this.btnTestAlarm.Name = "btnTestAlarm";
            this.btnTestAlarm.Size = new System.Drawing.Size(75, 23);
            this.btnTestAlarm.TabIndex = 5;
            this.btnTestAlarm.Text = "Test Alarm";
            this.btnTestAlarm.UseVisualStyleBackColor = true;
            this.btnTestAlarm.Click += new System.EventHandler(this.btnTestAlarm_Click);
            // 
            // btnTestRemoteAlarm
            // 
            this.btnTestRemoteAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestRemoteAlarm.Location = new System.Drawing.Point(184, 112);
            this.btnTestRemoteAlarm.Name = "btnTestRemoteAlarm";
            this.btnTestRemoteAlarm.Size = new System.Drawing.Size(75, 23);
            this.btnTestRemoteAlarm.TabIndex = 8;
            this.btnTestRemoteAlarm.Text = "TestRemAlarm";
            this.btnTestRemoteAlarm.UseVisualStyleBackColor = true;
            // 
            // btnGO
            // 
            this.btnGO.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGO.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGO.Location = new System.Drawing.Point(184, 144);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(67, 23);
            this.btnGO.TabIndex = 5;
            this.btnGO.Text = "GO";
            this.btnGO.UseVisualStyleBackColor = false;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // tmrWatchdog1
            // 
            this.tmrWatchdog1.Enabled = true;
            this.tmrWatchdog1.Interval = 500;
            this.tmrWatchdog1.Tick += new System.EventHandler(this.tmrWatchdog1_Tick);
            // 
            // btnAlarmOff
            // 
            this.btnAlarmOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlarmOff.Location = new System.Drawing.Point(184, 48);
            this.btnAlarmOff.Name = "btnAlarmOff";
            this.btnAlarmOff.Size = new System.Drawing.Size(75, 23);
            this.btnAlarmOff.TabIndex = 9;
            this.btnAlarmOff.Text = "Alarm OFF";
            this.btnAlarmOff.UseVisualStyleBackColor = true;
            this.btnAlarmOff.Click += new System.EventHandler(this.btnAlarmOff_Click);
            // 
            // tmrMasterAlarm
            // 
            this.tmrMasterAlarm.Enabled = true;
            this.tmrMasterAlarm.Interval = 300;
            this.tmrMasterAlarm.Tick += new System.EventHandler(this.tmrMasterAlarm_Tick);
            // 
            // lblAlarmBattery
            // 
            this.lblAlarmBattery.AutoSize = true;
            this.lblAlarmBattery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarmBattery.ForeColor = System.Drawing.Color.Red;
            this.lblAlarmBattery.Location = new System.Drawing.Point(8, 16);
            this.lblAlarmBattery.Name = "lblAlarmBattery";
            this.lblAlarmBattery.Size = new System.Drawing.Size(48, 16);
            this.lblAlarmBattery.TabIndex = 0;
            this.lblAlarmBattery.Text = "BATT";
            // 
            // lblAlarmPort
            // 
            this.lblAlarmPort.AutoSize = true;
            this.lblAlarmPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarmPort.ForeColor = System.Drawing.Color.Red;
            this.lblAlarmPort.Location = new System.Drawing.Point(8, 32);
            this.lblAlarmPort.Name = "lblAlarmPort";
            this.lblAlarmPort.Size = new System.Drawing.Size(50, 16);
            this.lblAlarmPort.TabIndex = 1;
            this.lblAlarmPort.Text = "PORT";
            // 
            // lblAlarmPressure
            // 
            this.lblAlarmPressure.AutoSize = true;
            this.lblAlarmPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarmPressure.ForeColor = System.Drawing.Color.Red;
            this.lblAlarmPressure.Location = new System.Drawing.Point(8, 48);
            this.lblAlarmPressure.Name = "lblAlarmPressure";
            this.lblAlarmPressure.Size = new System.Drawing.Size(49, 16);
            this.lblAlarmPressure.TabIndex = 2;
            this.lblAlarmPressure.Text = "PRES";
            // 
            // lblAlarmNetwork
            // 
            this.lblAlarmNetwork.AutoSize = true;
            this.lblAlarmNetwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarmNetwork.ForeColor = System.Drawing.Color.Red;
            this.lblAlarmNetwork.Location = new System.Drawing.Point(64, 15);
            this.lblAlarmNetwork.Name = "lblAlarmNetwork";
            this.lblAlarmNetwork.Size = new System.Drawing.Size(39, 16);
            this.lblAlarmNetwork.TabIndex = 5;
            this.lblAlarmNetwork.Text = "NET";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(64, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "NEMA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(64, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "CARDIO";
            // 
            // lblAlarmWD1
            // 
            this.lblAlarmWD1.AutoSize = true;
            this.lblAlarmWD1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlarmWD1.ForeColor = System.Drawing.Color.Red;
            this.lblAlarmWD1.Location = new System.Drawing.Point(128, 16);
            this.lblAlarmWD1.Name = "lblAlarmWD1";
            this.lblAlarmWD1.Size = new System.Drawing.Size(55, 16);
            this.lblAlarmWD1.TabIndex = 8;
            this.lblAlarmWD1.Text = "WDOG";
            // 
            // lblMasterAlarm
            // 
            this.lblMasterAlarm.AutoSize = true;
            this.lblMasterAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMasterAlarm.ForeColor = System.Drawing.Color.Red;
            this.lblMasterAlarm.Location = new System.Drawing.Point(128, 48);
            this.lblMasterAlarm.Name = "lblMasterAlarm";
            this.lblMasterAlarm.Size = new System.Drawing.Size(71, 16);
            this.lblMasterAlarm.TabIndex = 9;
            this.lblMasterAlarm.Text = "MASTER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 334);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpModes);
            this.MaximumSize = new System.Drawing.Size(696, 373);
            this.MinimumSize = new System.Drawing.Size(696, 373);
            this.Name = "Form1";
            this.Text = "Main Screen";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpModes.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTA)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpModes;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnMode8;
        private System.Windows.Forms.Button btnMode7;
        private System.Windows.Forms.Button btnMode6;
        private System.Windows.Forms.Button btnMode5;
        private System.Windows.Forms.Button btnMode4;
        private System.Windows.Forms.Button btnMode3;
        private System.Windows.Forms.Button btnMode2;
        private System.Windows.Forms.Button btnMode1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.Button btnBeep;
        private System.Windows.Forms.TextBox txtFromSerial;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtToSerial;
        private System.Windows.Forms.NumericUpDown numTF;
        private System.Windows.Forms.Label tF;
        private System.Windows.Forms.NumericUpDown numTE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numTD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numTA;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.NumericUpDown numLD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numLC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numLB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numLA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numSP;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtDebug;
        private System.Windows.Forms.Button btnTestRemoteAlarm;
        private System.Windows.Forms.Button btnTestAlarm;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.Timer tmrWatchdog1;
        private System.Windows.Forms.Button btnAlarmOff;
        private System.Windows.Forms.Timer tmrMasterAlarm;
        private System.Windows.Forms.Label lblAlarmPort;
        private System.Windows.Forms.Label lblAlarmBattery;
        private System.Windows.Forms.Label lblAlarmWD1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAlarmNetwork;
        private System.Windows.Forms.Label lblAlarmPressure;
        private System.Windows.Forms.Label lblMasterAlarm;
    }
}

