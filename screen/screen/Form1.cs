using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO.Ports;
using System.Media;
using System.Threading;

namespace screen
{
    public partial class Form1 : Form
    {
        public int[] breathingCurve = new int[100];     //breathingCurve
        public int[] scaledBreathingCurve = new int[100];     //breathingCurve
        public int selectedMode = 1;
        public bool masterAlarm = false;
        public int masterAlarmBg = 0;
        public string preparedCommand = "";

        public SerialPort mySerialPort;
        public Form1()
        {
            InitializeComponent();
            Console.Beep();
            Console.Beep();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            txtDebug_AppendLine("Loaded.");
            //Serial_Configure("COM3");
        }

        public void Serial_Configure(String port)
        {
            try
            {
                mySerialPort.Close();
            }
            catch (Exception e) { }

            try
            {
                mySerialPort = new SerialPort(port);
                mySerialPort.BaudRate = 9600;
                mySerialPort.Parity = Parity.None;
                mySerialPort.StopBits = StopBits.One;
                mySerialPort.DataBits = 8;
                mySerialPort.Handshake = Handshake.None;
                mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                mySerialPort.Open();
            }
            catch (Exception e)
            {
                Debug.Print("Exception!");
            }
        }

        public void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            txtFromSerial.Invoke(new Action(() => {
                txtFromSerial_AppendLine(indata);
            }));

            //TODO: capture the line, and parse the line.
        }

        public void txtDebug_AppendLine(string line)
        {
            txtDebug.AppendText(DateTime.Now.ToString("HH:mm:ss.ff") + " : " + line.ToString() + "\r\n");
        }
        public void txtFromSerial_AppendLine(string line)
        {
            txtFromSerial.AppendText(DateTime.Now.ToString("HH:mm:ss.ff") + " : " + line.ToString() + "\r\n");
        }


        private void cmbPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            String port = cmbPort.Text;
            txtDebug_AppendLine("Changed port to " + port);
            Serial_Configure(port);
        }

        private void Mode_Changed()
        {
            //TODO: recalibrate properly by physician
            switch (selectedMode)
            {
                case 1:
                    numTA.Value = 11;
                    numTB.Value = 21;
                    numTC.Value = 31;
                    numTD.Value = 61;
                    numTE.Value = 70;
                    numTF.Value = 100;
                    numSP.Value = 33;
                    numLA.Value = 41;
                    numLB.Value = 121;
                    numLC.Value = 121;
                    numLD.Value = 41;
                    break;
                case 2:
                    numTA.Value = 15;
                    numTB.Value = 25;
                    numTC.Value = 35;
                    numTD.Value = 65;
                    numTE.Value = 75;
                    numTF.Value = 100;
                    numSP.Value = 35;
                    numLA.Value = 45;
                    numLB.Value = 125;
                    numLC.Value = 125;
                    numLD.Value = 45;
                    break;
                case 3:
                    numTA.Value = 16;
                    numTB.Value = 26;
                    numTC.Value = 36;
                    numTD.Value = 66;
                    numTE.Value = 76;
                    numTF.Value = 100;
                    numSP.Value = 36;
                    numLA.Value = 46;
                    numLB.Value = 126;
                    numLC.Value = 126;
                    numLD.Value = 46;
                    break;
                case 4:
                    numTA.Value = 17;
                    numTB.Value = 27;
                    numTC.Value = 37;
                    numTD.Value = 67;
                    numTE.Value = 77;
                    numTF.Value = 100;
                    numSP.Value = 37;
                    numLA.Value = 47;
                    numLB.Value = 126;
                    numLC.Value = 126;
                    numLD.Value = 46;
                    break;
                case 5:
                    numTA.Value = 18;
                    numTB.Value = 28;
                    numTC.Value = 38;
                    numTD.Value = 68;
                    numTE.Value = 78;
                    numTF.Value = 100;
                    numSP.Value = 38;
                    numLA.Value = 48;
                    numLB.Value = 128;
                    numLC.Value = 128;
                    numLD.Value = 48;
                    break;
                case 6:
                    numTA.Value = 19;
                    numTB.Value = 29;
                    numTC.Value = 39;
                    numTD.Value = 69;
                    numTE.Value = 79;
                    numTF.Value = 100;
                    numSP.Value = 39;
                    numLA.Value = 49;
                    numLB.Value = 129;
                    numLC.Value = 129;
                    numLD.Value = 49;
                    break;
                case 7:
                    numTA.Value = 20;
                    numTB.Value = 30;
                    numTC.Value = 40;
                    numTD.Value = 70;
                    numTE.Value = 80;
                    numTF.Value = 100;
                    numSP.Value = 40;
                    numLA.Value = 50;
                    numLB.Value = 130;
                    numLC.Value = 130;
                    numLD.Value = 50;
                    break;
            }

            breathingCurve_UpdateCommand();

        }

        private void breathingCurve_UpdateCommand()
        {
            string command = breathingCurve_GetCommand();
            txtCommand.Text = command;
            preparedCommand = command;
            txtDebug_AppendLine("Prepared command: " + preparedCommand);
        }


        private String breathingCurve_GetCommand()
        {
            //obtains the XML command from UI config.
            breathingCurve_Calculate();
            VentilatorConfig conf = new VentilatorConfig();
            conf.tA = Convert.ToInt32(numTA.Value);
            conf.tB = Convert.ToInt32(numTB.Value);
            conf.tC = Convert.ToInt32(numTC.Value);
            conf.tD = Convert.ToInt32(numTD.Value);
            conf.tE = Convert.ToInt32(numTE.Value);
            conf.tF = Convert.ToInt32(numTF.Value);
            conf.LA = Convert.ToInt32(numLA.Value);
            conf.LB = Convert.ToInt32(numLB.Value);
            conf.LC = Convert.ToInt32(numLC.Value);
            conf.LD = Convert.ToInt32(numLD.Value);
            conf.md = selectedMode;
            conf.sp = Convert.ToInt32(numSP.Value);

            String printableASCII = breathingCurve_GetPrintableASCII(conf);
            String str = "";
            str = "<FromPC DB br='" + printableASCII + "' tA='" + conf.tA.ToString() + "' tB='" + conf.tB.ToString() + "' tC='" + conf.tC.ToString() + "' tD='" + conf.tD.ToString() + "' tE='" + conf.tE.ToString() + "' tF='" + conf.tF.ToString() + "' LA='" + conf.LA.ToString() + "' LB='" + conf.LB.ToString() + "' LC='" + conf.LC.ToString() + "' LD='" + conf.LD.ToString() + "' sp='" + conf.sp.ToString() + "' md='" + selectedMode.ToString() + "' go='go'/>\r\n";
            return str;
        }

        private void breathingCurve_Calculate()
        {
            //recalculate the global breathingCurve array.
            var conf = new VentilatorConfig();
            for (int t = 0; t < 100; t++)
            {
                double val = 0 * RectFn(0, conf.tA, t) +
                                    (-1) * conf.LA * RectFn(conf.tA, conf.tB, t) * Math.Sin(Math.PI * (t - conf.tA) / (conf.tB - conf.tA)) +
                                    conf.LB * RectFn(conf.tB, conf.tC, t) * (1 - Math.Exp(-(t - conf.tB))) +
                                    conf.LC * RectFn(conf.tC, conf.tD, t) +
                                    conf.LC * RectFn(conf.tD, conf.tE, t) * (Math.Exp(-(t - conf.tD))) +
                                    conf.LD;
                val = Math.Floor(val);
                breathingCurve[t] = Convert.ToInt32(val);
            }
        }

        public int RectFn(int a, int b, int t)
        {
            if (a <= t && t < b) return 1;
            return 0;
        }

        private String breathingCurve_GetPrintableASCII(VentilatorConfig conf)
        {
            String str = "";
            double min = (-1) * conf.LA;
            double max = conf.LB;

            for (int t = 0; t < 100; t++)
            {
                double val = ((127 - 32) / Math.Abs(max - min)) * breathingCurve[t] + 32;
                val = Math.Floor(val);
                scaledBreathingCurve[t] = Convert.ToInt32(val);
                scaledBreathingCurve[t] = sat(32, 127, scaledBreathingCurve[t]);
                str = str + Convert.ToChar(scaledBreathingCurve[t]);
            }
            return str;
        }

        private void btnTestAlarm_Click(object sender, EventArgs e)
        {
            //Beep01();
            masterAlarm = true;
        }

        private int sat(int min, int max, int val)
        {
            if (val < min) return min;
            if (val > max) return max;
            return val;
        }

        private void Beep01()       //test
        {
            new Thread( 
                () => {
                    Console.Beep(1000, 100);
                    Console.Beep(1000, 100);
                    Console.Beep(1000, 100);
                    Console.Beep(4000, 200);
                    Console.Beep(4000, 200);
                    Console.Beep(4000, 200);
                }
            ).Start();
        }

        private void Beep02()       //test
        {
            new Thread(
                () => {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Beep(1000, 200);
                        Console.Beep(1200, 200);
                        Console.Beep(1400, 200);
                        Console.Beep(2400, 100);
                    }
                }
            ).Start();
        }

        private void Beep03()       //notebook running on battery
        {
            new Thread(
                () => {
                    Console.Beep(3000, 200);
                }
            ).Start();
        }

        private void Beep04()       //master alarm
        {
            new Thread(
                () => {
                    Console.Beep(5000, 300);
                }
            ).Start();
        }

        private void btnBeep_Click(object sender, EventArgs e)
        {
            Beep02();
        }

        private void btnModes_ResetLayout()
        {
            btnMode1.BackColor = SystemColors.Control;
            btnMode2.BackColor = SystemColors.Control;
            btnMode3.BackColor = SystemColors.Control;
            btnMode4.BackColor = SystemColors.Control;
            btnMode5.BackColor = SystemColors.Control;
            btnMode6.BackColor = SystemColors.Control;
            btnMode7.BackColor = SystemColors.Control;
            btnMode8.BackColor = SystemColors.Control;
        }

        private void btnMode1_Click(object sender, EventArgs e)
        {
            btnModes_ResetLayout();
            selectedMode = 1;
            btnMode1.BackColor = SystemColors.ControlDark;
            Mode_Changed();
        }

        private void btnMode2_Click(object sender, EventArgs e)
        {
            btnModes_ResetLayout();
            selectedMode = 2;
            btnMode2.BackColor = SystemColors.ControlDark;
            Mode_Changed();
        }

        private void btnMode3_Click(object sender, EventArgs e)
        {
            btnModes_ResetLayout();
            selectedMode = 3;
            btnMode3.BackColor = SystemColors.ControlDark;
            Mode_Changed();
        }

        private void btnMode4_Click(object sender, EventArgs e)
        {
            btnModes_ResetLayout();
            selectedMode = 4;
            btnMode4.BackColor = SystemColors.ControlDark;
            Mode_Changed();
        }

        private void btnMode5_Click(object sender, EventArgs e)
        {
            btnModes_ResetLayout();
            selectedMode = 5;
            btnMode5.BackColor = SystemColors.ControlDark;
            Mode_Changed();
        }

        private void btnMode6_Click(object sender, EventArgs e)
        {
            btnModes_ResetLayout();
            selectedMode = 6;
            btnMode6.BackColor = SystemColors.ControlDark;
            Mode_Changed();
        }

        private void btnMode7_Click(object sender, EventArgs e)
        {
            btnModes_ResetLayout();
            selectedMode = 7;
            btnMode7.BackColor = SystemColors.ControlDark;
            Mode_Changed();
        }

        private void btnMode8_Click(object sender, EventArgs e)
        {
            btnModes_ResetLayout();
            selectedMode = 1;
            btnMode8.BackColor = SystemColors.ControlDark;
            Mode_Changed();
        }

        private void tmrWatchdog1_Tick(object sender, EventArgs e)
        {
            Boolean isRunningOnBattery = (System.Windows.Forms.SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Offline);
            if (isRunningOnBattery)
            {
                Beep03();
            }
        }

        private void tmrMasterAlarm_Tick(object sender, EventArgs e)
        {
            if (masterAlarm)
            {
                Beep04();
                if (masterAlarmBg==0)
                {
                    masterAlarmBg = 1;
                    grpModes.BackColor = Color.Red;
                }
                else
                {
                    masterAlarmBg = 0;
                    grpModes.BackColor = SystemColors.Control;
                }

            }
        }

        private void btnAlarmOff_Click(object sender, EventArgs e)
        {
            masterAlarm = false;
            grpModes.BackColor = SystemColors.Control;
        }

        private void numTA_ValueChanged(object sender, EventArgs e)
        {
            breathingCurve_UpdateCommand();
        }

        private void numTB_ValueChanged(object sender, EventArgs e)
        {
            breathingCurve_UpdateCommand();
        }

        private void numTC_ValueChanged(object sender, EventArgs e)
        {
            breathingCurve_UpdateCommand();
        }

        private void numTD_ValueChanged(object sender, EventArgs e)
        {
            breathingCurve_UpdateCommand();
        }

        private void numTE_ValueChanged(object sender, EventArgs e)
        {
            breathingCurve_UpdateCommand();
        }

        private void numTF_ValueChanged(object sender, EventArgs e)
        {
            breathingCurve_UpdateCommand();
        }

        private void numSP_ValueChanged(object sender, EventArgs e)
        {
            breathingCurve_UpdateCommand();
        }

        private void numLA_ValueChanged(object sender, EventArgs e)
        {
            breathingCurve_UpdateCommand();
        }

        private void numLB_ValueChanged(object sender, EventArgs e)
        {
            breathingCurve_UpdateCommand();
        }

        private void numLC_ValueChanged(object sender, EventArgs e)
        {
            breathingCurve_UpdateCommand();
        }

        private void numLD_ValueChanged(object sender, EventArgs e)
        {
            breathingCurve_UpdateCommand();
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            txtDebug_AppendLine("SENT command: " + preparedCommand);
            //we send this to the arduino:
            mySerialPort.Write(preparedCommand);
        }
    }
}
