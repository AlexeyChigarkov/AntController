using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntController
{
    public partial class ConfigForm : Form
    {

        public ConfigForm()
        {
            InitializeComponent();
            config = ConfigProvider.GetConfiguration();
            SetLabels();
            textDirection1.TextChanged += TextDirection1_TextChanged;
            textDirection2.TextChanged += TextDirection1_TextChanged;
            textDirection3.TextChanged += TextDirection1_TextChanged;
            textDirection4.TextChanged += TextDirection1_TextChanged;
            textDirection5.TextChanged += TextDirection1_TextChanged;
            textDirection6.TextChanged += TextDirection1_TextChanged;
            textDirection7.TextChanged += TextDirection1_TextChanged;
            textDirection8.TextChanged += TextDirection1_TextChanged;
            textDirection9.TextChanged += TextDirection1_TextChanged;
            textDirection10.TextChanged += TextDirection1_TextChanged;
            textDirection11.TextChanged += TextDirection1_TextChanged;
            textDirection12.TextChanged += TextDirection1_TextChanged;
            PortTextBox.TextChanged += TextDirection1_TextChanged;
            HostTextBox.TextChanged += TextDirection1_TextChanged;
            AllowNumLock.CheckStateChanged += TextDirection1_TextChanged;
            AllowHotKey.CheckStateChanged += TextDirection1_TextChanged;
            textBoxTimeout.TextChanged += TextDirection1_TextChanged;
            textBoxRetry.TextChanged += TextDirection1_TextChanged;
            NumComboBox1.SelectedIndexChanged += TextDirection1_TextChanged;
            NumComboBox2.SelectedIndexChanged += TextDirection1_TextChanged;
            NumComboBox3.SelectedIndexChanged += TextDirection1_TextChanged;
            NumComboBox4.SelectedIndexChanged += TextDirection1_TextChanged;
            NumComboBox5.SelectedIndexChanged += TextDirection1_TextChanged;
            NumComboBox6.SelectedIndexChanged += TextDirection1_TextChanged;
            NumComboBox7.SelectedIndexChanged += TextDirection1_TextChanged;
            NumComboBox8.SelectedIndexChanged += TextDirection1_TextChanged;
            NumComboBox9.SelectedIndexChanged += TextDirection1_TextChanged;
            NumComboBox10.SelectedIndexChanged += TextDirection1_TextChanged;
            NumComboBox11.SelectedIndexChanged += TextDirection1_TextChanged;
            NumComboBox12.SelectedIndexChanged += TextDirection1_TextChanged;           
           
            checkBoxTop.CheckStateChanged += TextDirection1_TextChanged;

            this.FormClosing += new FormClosingEventHandler(this.FormIsClosing);
        }

        private void FormIsClosing(object sender, FormClosingEventArgs e)
        {
            SetLabels();
        }

        private void TextDirection1_TextChanged(object sender, EventArgs e)
        {

            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = ValidateInput();
            if (!result.Item1)
            {
                MessageBox.Show($"Configuration contains invalid value {result.Item2}. Please check", "Configuration validation");
                return;
            }
            config.Host = HostTextBox.Text;
            config.Port = Convert.ToInt32(PortTextBox.Text);
            config.AllowNumLock = AllowNumLock.Checked;
            config.AllowHotKey = AllowHotKey.Checked;
            config.Timeout = Convert.ToInt32(textBoxTimeout.Text);
            config.Retry = Convert.ToInt32(textBoxRetry.Text);
            config.AlwaysOnTop = checkBoxTop.Checked;
            config.MainFormColor = button3.BackColor;
            config.Directions[0] = textDirection1.Text;
            config.Directions[1] = textDirection2.Text;
            config.Directions[2] = textDirection3.Text;
            config.Directions[3] = textDirection4.Text;
            config.Directions[4] = textDirection5.Text;
            config.Directions[5] = textDirection6.Text;
            config.Directions[6] = textDirection7.Text;
            config.Directions[7] = textDirection8.Text;
            config.Directions[8] = textDirection9.Text;
            config.Directions[9] = textDirection10.Text;
            config.Directions[10] = textDirection11.Text;
            config.Directions[11] = textDirection12.Text;

            

            config.NumKeys[0] = (NumComboBox1.SelectedIndex );
            config.NumKeys[1] =  (NumComboBox2.SelectedIndex );
            config.NumKeys[2] =  (NumComboBox3.SelectedIndex );
            config.NumKeys[3] =  (NumComboBox4.SelectedIndex );
            config.NumKeys[4] = (NumComboBox5.SelectedIndex );
            config.NumKeys[5] =  (NumComboBox6.SelectedIndex );
            config.NumKeys[6] =  (NumComboBox7.SelectedIndex );
            config.NumKeys[7] =  (NumComboBox8.SelectedIndex );
            config.NumKeys[8] =  (NumComboBox9.SelectedIndex );
            config.NumKeys[9] =  (NumComboBox10.SelectedIndex );
            config.NumKeys[10] =  (NumComboBox11.SelectedIndex );
            config.NumKeys[11] = (NumComboBox12.SelectedIndex );

            ConfigProvider.DeserializeConfiguration(config);
            ConfigurationChanged("changed");

            button1.Enabled = false;
            this.Close();
        }

        private void SetDirections()
        {
            textDirection1.Text = config.Directions[0];
            textDirection2.Text = config.Directions[1];
            textDirection3.Text = config.Directions[2];
            textDirection4.Text = config.Directions[3];
            textDirection5.Text = config.Directions[4];
            textDirection6.Text = config.Directions[5];
            textDirection7.Text = config.Directions[6];
            textDirection8.Text = config.Directions[7];
            textDirection9.Text = config.Directions[8];
            textDirection10.Text = config.Directions[9];
            textDirection11.Text = config.Directions[10];
            textDirection12.Text = config.Directions[11];

        }

        private void SetNumKeys()
        {
         

            NumComboBox1.Items.Clear();
            NumComboBox2.Items.Clear();
            NumComboBox3.Items.Clear();
            NumComboBox4.Items.Clear();
            NumComboBox5.Items.Clear();
            NumComboBox6.Items.Clear();
            NumComboBox7.Items.Clear();
            NumComboBox8.Items.Clear();
            NumComboBox9.Items.Clear();
            NumComboBox10.Items.Clear();
            NumComboBox11.Items.Clear();
            NumComboBox12.Items.Clear();

            for (int i = 0; i < config.Directions.Length; i++)
            {
                NumComboBox1.Items.Add(config.Directions[i]);
                NumComboBox2.Items.Add(config.Directions[i]);
                NumComboBox3.Items.Add(config.Directions[i]);
                NumComboBox4.Items.Add(config.Directions[i]);
                NumComboBox5.Items.Add(config.Directions[i]);
                NumComboBox6.Items.Add(config.Directions[i]);
                NumComboBox7.Items.Add(config.Directions[i]);
                NumComboBox8.Items.Add(config.Directions[i]);
                NumComboBox9.Items.Add(config.Directions[i]);
                NumComboBox10.Items.Add(config.Directions[i]);
                NumComboBox11.Items.Add(config.Directions[i]);
                NumComboBox12.Items.Add(config.Directions[i]);
            }

                NumComboBox1.SelectedIndex = config.NumKeys[0];
                NumComboBox2.SelectedIndex = config.NumKeys[1];
                NumComboBox3.SelectedIndex = config.NumKeys[2];
                NumComboBox4.SelectedIndex = config.NumKeys[3];
                NumComboBox5.SelectedIndex = config.NumKeys[4];
                NumComboBox6.SelectedIndex = config.NumKeys[5];
                NumComboBox7.SelectedIndex = config.NumKeys[6];
                NumComboBox8.SelectedIndex = config.NumKeys[7];
                NumComboBox9.SelectedIndex = config.NumKeys[8];
                NumComboBox10.SelectedIndex = config.NumKeys[9];
                NumComboBox11.SelectedIndex = config.NumKeys[10];
                NumComboBox12.SelectedIndex = config.NumKeys[11];

           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConfigProvider.DeserializeConfiguration(new Configuration(true));
            config = ConfigProvider.GetConfiguration();
            SetLabels();
            button1.Enabled = true;
        }

        private void SetLabels()
        {
            HostTextBox.Text = config.Host;
            PortTextBox.Text = config.Port.ToString();
            AllowNumLock.Checked = config.AllowNumLock;
            AllowHotKey.Checked = config.AllowHotKey;
            checkBoxTop.Checked = config.AlwaysOnTop;
            textBoxRetry.Text = config.Retry.ToString();
            textBoxTimeout.Text = config.Timeout.ToString();
            button3.BackColor = config.MainFormColor;
            SetDirections();
            SetNumKeys();

        }

        private (bool, string) ValidateInput()
        {
            foreach (var con in this.tabPage2.Controls.OfType<TextBox>())
            {
                if (con.Name.StartsWith("Num"))
                {
                    int n;
                    if (Int32.TryParse(con.Text, out n))
                    {
                        if (n < 1 || n > 12)
                        {
                            return (false, con.Text);
                        }
                    }
                    else
                    {
                        return (false, con.Text);
                    }                   
                }
            }

            if (!Int32.TryParse(PortTextBox.Text, out var a))
            {
                return (false, PortTextBox.Text);
            }
            if (!Int32.TryParse(textBoxRetry.Text, out var b))
            {
                return (false, textBoxRetry.Text);
            }
            if (!Int32.TryParse(textBoxTimeout.Text, out var c))
            {
                return (false, textBoxTimeout.Text);
            }

           
               string ValidIpAddressRegex = "^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5]).){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$";
              if (!Regex.IsMatch(HostTextBox.Text,ValidIpAddressRegex))
              {
                return (false, HostTextBox.Text);
            }
           

            return (true, String.Empty);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button3.BackColor = colorDialog1.Color;
                button1.Enabled = true;
            }
        }
    }

}