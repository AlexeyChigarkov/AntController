using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace AntController
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        private const int  salt = 47293;

        private bool sendOnChange;

        private int proportion;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        this.PreviewKeyDown += Form1_PreviewKeyDown;
        radio4.PreviewKeyDown += Form1_PreviewKeyDown;
        radio1.PreviewKeyDown += Form1_PreviewKeyDown;
        radio7.PreviewKeyDown += Form1_PreviewKeyDown;
        radio10.PreviewKeyDown += Form1_PreviewKeyDown;
        button2.PreviewKeyDown += Form1_PreviewKeyDown;
        provider = new ConnectionProvider();
            config = ConfigProvider.GetConfiguration();
            ApplyAppearence();
            SetDirections();
            ConfigForm = new ConfigForm();
            controllerCondition = new ControllerCondition();
            ToolStripMenuItem copyMenuItem = new ToolStripMenuItem("Rename");
            ConfigForm.ConfigurationChanged += OnConfigurationChanged;
            provider.MessageReceived += OnMessageReceived;
            provider.ConectionEstablished += OnConnectionEstablished;
            this.FormClosing += new FormClosingEventHandler(this.FormIsClosing);
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            int FirstHotkeyId = salt +1;
            int FirstHotKeyKey = (int)Keys.NumPad0;
            int SecondHotkeyId = salt +2;
            int SecondHotKeyKey = (int)Keys.NumPad1;
            int HotkeyId3 = salt + 3;
            int HotKeyKey3 = (int)Keys.NumPad2;
            int HotkeyId4 = salt + 4;
            int HotKeyKey4 = (int)Keys.NumPad3;
            int HotkeyId5 = salt + 5;
            int HotKeyKey5 = (int)Keys.NumPad4;
            int HotkeyId6 = salt + 6;
            int HotKeyKey6 = (int)Keys.NumPad5;
            int HotkeyId7 = salt + 7;
            int HotKeyKey7 = (int)Keys.NumPad6;
            int HotkeyId8 = salt + 8;
            int HotKeyKey8 = (int)Keys.NumPad7;
            int HotkeyId9 = salt + 9;
            int HotKeyKey9 = (int)Keys.NumPad8;
            int HotkeyId10 = salt + 10;
            int HotKeyKey10 = (int)Keys.NumPad9;
            int HotkeyId11 = salt + 11;
            int HotKeyKey11 = (int)Keys.Subtract;
            int HotkeyId12 = salt + 12;
            int HotKeyKey12 = (int)Keys.Add;

            Boolean Hotkey1Registered = RegisterHotKey(this.Handle, FirstHotkeyId, 0x0001, FirstHotKeyKey);
            sendOnChange = true;
            
            Boolean HotKey2Registered = RegisterHotKey(
                this.Handle, SecondHotkeyId, 0x0001, SecondHotKeyKey
            );

            Boolean HotKey3Registered = RegisterHotKey(
                this.Handle, HotkeyId3, 0x0001, HotKeyKey3
            );
            Boolean HotKey4Registered = RegisterHotKey(
                this.Handle, HotkeyId4, 0x0001, HotKeyKey4
            );
            Boolean HotKey5Registered = RegisterHotKey(
                this.Handle, HotkeyId5, 0x0001, HotKeyKey5
            );
            Boolean HotKey6Registered = RegisterHotKey(
                this.Handle, HotkeyId6, 0x0001, HotKeyKey6
            );
            Boolean HotKey7Registered = RegisterHotKey(
                this.Handle, HotkeyId7, 0x0001, HotKeyKey7
            );
            Boolean HotKey8Registered = RegisterHotKey(
                this.Handle, HotkeyId8, 0x0001, HotKeyKey8
            );
            Boolean HotKey9Registered = RegisterHotKey(
                this.Handle, HotkeyId9, 0x0001, HotKeyKey9
            );
            Boolean HotKey10Registered = RegisterHotKey(
                this.Handle, HotkeyId10, 0x0001, HotKeyKey10
            );
            Boolean HotKey11Registered = RegisterHotKey(
                this.Handle, HotkeyId11, 0x0001, HotKeyKey11
            );
            Boolean HotKey12Registered = RegisterHotKey(
                this.Handle, HotkeyId12, 0x0001, HotKeyKey12
            );
        }

     

        void OnConfigurationChanged(string message)
        {
            config = ConfigProvider.GetConfiguration();
            SetDirections();
            ApplyAppearence();
        }

        private void FormIsClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit?", "Ant controller",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                provider.Disconnect();

               
            }
            else
            {
                e.Cancel = true;
            }

        }

        void OnConnectionEstablished(bool connection)
        {
            if (connection)
            {
                
                
                connectButton.Text = "Disconnect";
                connectButton.BackColor = Color.OrangeRed;
            }
            else
            {
                if (this.connectButton.InvokeRequired)
                {
                    SetTextCallback2 d = new SetTextCallback2(OnConnectionEstablished);
                    this.Invoke(d, new object[] { connection });
                }
                connectButton.Text = "Connect";
                connectButton.BackColor = Color.LawnGreen;
                var round = this.panel2.Controls.OfType<RoundButton>();
                foreach (var rb in round)
                {
                    rb.BackColor = SystemColors.Control;
                    rb.ForeColor = SystemColors.ControlText;
                }

                round = this.panel1.Controls.OfType<RoundButton>();
                foreach (var rb in round)
                {
                    rb.BackColor = SystemColors.Control;
                    rb.ForeColor = SystemColors.ControlText;
                }

                round = this.panel3.Controls.OfType<RoundButton>();
                foreach (var rb in round)
                {
                    rb.BackColor = SystemColors.Control;
                    rb.ForeColor = SystemColors.ControlText;
                }
            }

        }

        void OnMessageReceived(string message)
        {
            if (!Regex.IsMatch(message, controllerCondition.Pattern))
            {
                provider.WriteLog("Incorrect or system message received from the controller");
                return;
            }
            sendOnChange = false;
            ProcessMessage(message);
        }

        void ProcessMessage(string message)
        {


            if (this.roundTX.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(ProcessMessage);
                this.Invoke(d, new object[] { message });
            }
            //else
            //{
            //    controllerCondition.SetCurrentCondition(message);               
            //    this.textBoxBand.Text = controllerCondition.Band;
            //    this.textBoxLna.Text = controllerCondition.Lna.ToString();
            //    this.textBoxAnt.Text = controllerCondition.Antenna.ToString();
            //    this.textBoxTx.Text = controllerCondition.Tx;
            //    string name = "radio" + controllerCondition.Antenna.ToString();
            //    var rb = this.Controls[name] as RadioButton;
            //    rb.Checked = true;
            //    this.comboBox1.SelectedIndex = controllerCondition.Lna-1;
            //    sendOnChange = true;
            //}

            else
            {

                controllerCondition.SetCurrentCondition(message);

                var round = this.panel2.Controls.OfType<RoundButton>();
                foreach (var rb in round)
                {
                    rb.BackColor = SystemColors.Control;
                    rb.ForeColor = SystemColors.ControlText;
                }

                round = this.panel1.Controls.OfType<RoundButton>();
                foreach (var rb in round)
                {
                    rb.BackColor = SystemColors.Control;
                    rb.ForeColor = SystemColors.ControlText;
                }

                round = this.panel3.Controls.OfType<RoundButton>();
                foreach (var rb in round)
                {
                    rb.BackColor = SystemColors.Control;
                    rb.ForeColor = SystemColors.ControlText;
                }



                if (controllerCondition.Tx == "TX")
                {
                    roundTX.BackColor = Color.Tomato;
                    roundTX.ForeColor = SystemColors.ButtonHighlight;
                    roundTX.Text = "TX";
                }
                else
                {
                    roundTX.Text = "RX";
                }

                if (controllerCondition.Band == "160")
                {
                    round160.BackColor = Color.Tomato;
                    round160.ForeColor = SystemColors.ButtonHighlight;
                }

                if (controllerCondition.Band == "80")
                {
                    round80.BackColor = Color.Tomato;
                    round80.ForeColor = SystemColors.ButtonHighlight;
                }

                if (controllerCondition.Band == "40")
                {
                    round40.BackColor = Color.Tomato;
                    round40.ForeColor = SystemColors.ButtonHighlight;
                }


                if (controllerCondition.Lna == 2)
                {
                    roundLna12.BackColor = Color.Tomato;
                    roundLna12.ForeColor = SystemColors.ButtonHighlight;
                }

                if (controllerCondition.Lna == 3)
                {
                    roundLna24.BackColor = Color.Tomato;
                    roundLna24.ForeColor = SystemColors.ButtonHighlight;
                }
                if (controllerCondition.Lna == 1)
                {
                    roundLnaOff.BackColor = Color.Tomato;
                    roundLnaOff.ForeColor = SystemColors.ButtonHighlight;
                }
                this.comboBox1.SelectedIndex = controllerCondition.Lna - 1;
                string name = "radio" + controllerCondition.Antenna.ToString();
                var rb2 = this.Controls[name] as RadioButton;
                rb2.Checked = true;
                sendOnChange = true;
            }

        }


        protected override void WndProc(ref Message m)
        {
            if (m.Msg == Constants.WM_HOTKEY_MSG_ID && config.AllowHotKey)
            {
                int id = m.WParam.ToInt32();
                string number;
                string name;
                RadioButton radio;
                switch (id)
                {
                    case salt +1:
                        number = (config.NumKeys[9] + 1).ToString();
                        name = "radio" + number;
                        radio = (RadioButton)this.Controls[name];
                        radio.Checked = true;
                        break;
                    case salt + 2:
                        number = (config.NumKeys[0]+1).ToString();
                        name = "radio" + number;
                        radio = (RadioButton)this.Controls[name];
                        radio.Checked = true;
                        break;
                    case salt + 3:
                        number = (config.NumKeys[1]+1).ToString();
                        name = "radio" + number;
                        radio = (RadioButton)this.Controls[name];
                        radio.Checked = true;
                        break;
                    case salt + 4:
                        number = (config.NumKeys[2]+1).ToString();
                        name = "radio" + number;
                        radio = (RadioButton)this.Controls[name];
                        radio.Checked = true;
                        break;
                    case salt + 5:
                        number = (config.NumKeys[3]+1).ToString();
                        name = "radio" + number;
                        radio = (RadioButton)this.Controls[name];
                        radio.Checked = true;
                        break;
                    case salt + 6:
                        number = (config.NumKeys[4]+1).ToString();
                        name = "radio" + number;
                        radio = (RadioButton)this.Controls[name];
                        radio.Checked = true;
                        break;
                    case salt + 7:
                        number = (config.NumKeys[5]+1).ToString();
                        name = "radio" + number;
                        radio = (RadioButton)this.Controls[name];
                        radio.Checked = true;
                        break;
                    case salt + 8:
                        number = (config.NumKeys[6]+1).ToString();
                        name = "radio" + number;
                        radio = (RadioButton)this.Controls[name];
                        radio.Checked = true;
                        break;
                    case salt + 9:
                        number = (config.NumKeys[7]+1).ToString();
                        name = "radio" + number;
                        radio = (RadioButton)this.Controls[name];
                        radio.Checked = true;
                        break;
                    case salt + 10:
                        number = (config.NumKeys[8]+1).ToString();
                        name = "radio" + number;
                        radio = (RadioButton)this.Controls[name];
                        radio.Checked = true;
                        break;
                    case salt + 11:
                        number = (config.NumKeys[10]+1).ToString();
                        name = "radio" + number;
                        radio = (RadioButton)this.Controls[name];
                        radio.Checked = true;
                        break;
                    case salt + 12:
                        number = (config.NumKeys[11]+1).ToString();
                        name = "radio" + number;
                        radio = (RadioButton)this.Controls[name];
                        radio.Checked = true;
                        break;
                }
            }

            base.WndProc(ref m);
        }


        private void connectButton_Click(object sender, EventArgs e)
        {
            if (!provider.Connected)
            {
                try
                {
                    var host = config.Host;
                    var port = config.Port;
                    var timeout = config.Timeout;
                    var retry = config.Retry;
                    provider.Connect(host, port,timeout, retry);


                }

                catch (Exception ex)
                {
                    MessageBox.Show("Connection exception " + ex.Message);
                }
            }

            else
            {
                provider.Disconnect();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ConfigForm.IsDisposed)
            {
                
            }
            ConfigForm.TopMost = true;
            ConfigForm.ShowDialog();
        }

        private void SetDirections()
        {
            radio1.Text = config.Directions[0];
            radio2.Text = config.Directions[1];
            radio3.Text = config.Directions[2];
            radio4.Text = config.Directions[3];
            radio5.Text = config.Directions[4];
            radio6.Text = config.Directions[5];
            radio7.Text = config.Directions[6];
            radio8.Text = config.Directions[7];
            radio9.Text = config.Directions[8];
            radio10.Text = config.Directions[9];
            radio11.Text = config.Directions[10];
            radio12.Text = config.Directions[11];
        }

        private void radio1_CheckedChanged(object sender, EventArgs e)
        {
            if (provider.Connected && radio1.Checked && sendOnChange)
            {
                provider.SendMessage("A01", config.Retry);
            }
        }
        private void radio2_CheckedChanged(object sender, EventArgs e)
        {
            if (provider.Connected && radio2.Checked && sendOnChange)
            {
                provider.SendMessage("A02", config.Retry);
            }
        }

        private void radio3_CheckedChanged(object sender, EventArgs e)
        {
            if (provider.Connected && radio3.Checked && sendOnChange)
            {
                provider.SendMessage("A03", config.Retry);
            }
        }

        private void radio4_CheckedChanged(object sender, EventArgs e)
        {
            if (provider.Connected && radio4.Checked && sendOnChange)
            {
                provider.SendMessage("A04", config.Retry);
            }
        }

        private void radio5_CheckedChanged(object sender, EventArgs e)
        {
            if (provider.Connected && radio5.Checked && sendOnChange)
            {
                provider.SendMessage("A05", config.Retry);
            }
        }

        private void radio6_CheckedChanged(object sender, EventArgs e)
        {
            if (provider.Connected && radio6.Checked && sendOnChange)
            {
                provider.SendMessage("A06", config.Retry);
            }
        }

        private void radio7_CheckedChanged(object sender, EventArgs e)
        {
            if (provider.Connected && radio7.Checked && sendOnChange)
            {
                provider.SendMessage("A07", config.Retry);
            }
        }

        private void radio8_CheckedChanged(object sender, EventArgs e)
        {
            if (provider.Connected && radio8.Checked && sendOnChange)
            {
                provider.SendMessage("A08", config.Retry);
            }
        }

        private void radio9_CheckedChanged(object sender, EventArgs e)
        {
            if (provider.Connected && radio9.Checked && sendOnChange)
            {
                provider.SendMessage("A09", config.Retry);
            }
        }

        private void radio10_CheckedChanged(object sender, EventArgs e)
        {
            if (provider.Connected && radio10.Checked && sendOnChange)
            {
                provider.SendMessage("A10", config.Retry);
            }
        }

        private void radio11_CheckedChanged(object sender, EventArgs e)
        {
            if (provider.Connected && radio11.Checked && sendOnChange)
            {
                provider.SendMessage("A11", config.Retry);
            }
        }

        private void radio12_CheckedChanged(object sender, EventArgs e)
        {
            if (provider.Connected && radio12.Checked && sendOnChange)
            {
                provider.SendMessage("A12", config.Retry);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (provider.Connected && sendOnChange)
            {
                provider.SendMessage("P0" + (comboBox1.SelectedIndex + 1).ToString(), config.Retry);
            }
        }

        private void ApplyAppearence()
        {
            this.TopMost = config.AlwaysOnTop;
            this.BackColor = config.MainFormColor;
        }
    }
}
