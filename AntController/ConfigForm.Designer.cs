namespace AntController
{
    partial class ConfigForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public delegate void ConfigurationChangedHandler(string message);
        public event ConfigurationChangedHandler ConfigurationChanged;

        private Configuration config;


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.HostTextBox = new System.Windows.Forms.TextBox();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AllowNumLock = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxRetry = new System.Windows.Forms.TextBox();
            this.textBoxTimeout = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.AllowHotKey = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textDirection12 = new System.Windows.Forms.TextBox();
            this.textDirection11 = new System.Windows.Forms.TextBox();
            this.textDirection10 = new System.Windows.Forms.TextBox();
            this.textDirection9 = new System.Windows.Forms.TextBox();
            this.textDirection8 = new System.Windows.Forms.TextBox();
            this.textDirection7 = new System.Windows.Forms.TextBox();
            this.textDirection6 = new System.Windows.Forms.TextBox();
            this.textDirection5 = new System.Windows.Forms.TextBox();
            this.textDirection4 = new System.Windows.Forms.TextBox();
            this.textDirection3 = new System.Windows.Forms.TextBox();
            this.textDirection2 = new System.Windows.Forms.TextBox();
            this.textDirection1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.checkBoxTop = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.NumComboBox1 = new System.Windows.Forms.ComboBox();
            this.NumComboBox2 = new System.Windows.Forms.ComboBox();
            this.NumComboBox3 = new System.Windows.Forms.ComboBox();
            this.NumComboBox6 = new System.Windows.Forms.ComboBox();
            this.NumComboBox5 = new System.Windows.Forms.ComboBox();
            this.NumComboBox4 = new System.Windows.Forms.ComboBox();
            this.NumComboBox9 = new System.Windows.Forms.ComboBox();
            this.NumComboBox8 = new System.Windows.Forms.ComboBox();
            this.NumComboBox7 = new System.Windows.Forms.ComboBox();
            this.NumComboBox10 = new System.Windows.Forms.ComboBox();
            this.NumComboBox11 = new System.Windows.Forms.ComboBox();
            this.NumComboBox12 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // HostTextBox
            // 
            this.HostTextBox.Location = new System.Drawing.Point(7, 44);
            this.HostTextBox.Name = "HostTextBox";
            this.HostTextBox.Size = new System.Drawing.Size(189, 20);
            this.HostTextBox.TabIndex = 0;
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(8, 96);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(189, 20);
            this.PortTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Host";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // AllowNumLock
            // 
            this.AllowNumLock.AutoSize = true;
            this.AllowNumLock.Location = new System.Drawing.Point(4, 16);
            this.AllowNumLock.Name = "AllowNumLock";
            this.AllowNumLock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AllowNumLock.Size = new System.Drawing.Size(103, 17);
            this.AllowNumLock.TabIndex = 4;
            this.AllowNumLock.Text = "Allow Num Lock";
            this.AllowNumLock.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(19, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 22);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(14, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(258, 250);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.OldLace;
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.textBoxRetry);
            this.tabPage1.Controls.Add(this.textBoxTimeout);
            this.tabPage1.Controls.Add(this.HostTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.PortTextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(250, 224);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Connection";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(121, 139);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Resend";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 139);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "Timeout";
            // 
            // textBoxRetry
            // 
            this.textBoxRetry.Location = new System.Drawing.Point(124, 155);
            this.textBoxRetry.Name = "textBoxRetry";
            this.textBoxRetry.Size = new System.Drawing.Size(73, 20);
            this.textBoxRetry.TabIndex = 8;
            // 
            // textBoxTimeout
            // 
            this.textBoxTimeout.Location = new System.Drawing.Point(7, 155);
            this.textBoxTimeout.Name = "textBoxTimeout";
            this.textBoxTimeout.Size = new System.Drawing.Size(73, 20);
            this.textBoxTimeout.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.OldLace;
            this.tabPage2.Controls.Add(this.NumComboBox12);
            this.tabPage2.Controls.Add(this.NumComboBox11);
            this.tabPage2.Controls.Add(this.NumComboBox10);
            this.tabPage2.Controls.Add(this.NumComboBox9);
            this.tabPage2.Controls.Add(this.NumComboBox8);
            this.tabPage2.Controls.Add(this.NumComboBox7);
            this.tabPage2.Controls.Add(this.NumComboBox6);
            this.tabPage2.Controls.Add(this.NumComboBox5);
            this.tabPage2.Controls.Add(this.NumComboBox4);
            this.tabPage2.Controls.Add(this.NumComboBox3);
            this.tabPage2.Controls.Add(this.NumComboBox2);
            this.tabPage2.Controls.Add(this.NumComboBox1);
            this.tabPage2.Controls.Add(this.textBox16);
            this.tabPage2.Controls.Add(this.textBox15);
            this.tabPage2.Controls.Add(this.textBox14);
            this.tabPage2.Controls.Add(this.textBox13);
            this.tabPage2.Controls.Add(this.textBox11);
            this.tabPage2.Controls.Add(this.AllowHotKey);
            this.tabPage2.Controls.Add(this.AllowNumLock);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(250, 224);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Buttons";
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(115, 52);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(45, 20);
            this.textBox16.TabIndex = 21;
            this.textBox16.Text = "*";
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(62, 52);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(45, 20);
            this.textBox15.TabIndex = 20;
            this.textBox15.Text = "/";
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(6, 53);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(45, 20);
            this.textBox14.TabIndex = 19;
            this.textBox14.Text = "Num ";
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(166, 133);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(45, 46);
            this.textBox13.TabIndex = 18;
            this.textBox13.Text = "Enter";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(115, 158);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(45, 20);
            this.textBox11.TabIndex = 16;
            this.textBox11.Text = "Del";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AllowHotKey
            // 
            this.AllowHotKey.AutoSize = true;
            this.AllowHotKey.Location = new System.Drawing.Point(119, 16);
            this.AllowHotKey.Name = "AllowHotKey";
            this.AllowHotKey.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AllowHotKey.Size = new System.Drawing.Size(92, 17);
            this.AllowHotKey.TabIndex = 5;
            this.AllowHotKey.Text = "Allow Hot Key";
            this.AllowHotKey.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.OldLace;
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.textDirection12);
            this.tabPage3.Controls.Add(this.textDirection11);
            this.tabPage3.Controls.Add(this.textDirection10);
            this.tabPage3.Controls.Add(this.textDirection9);
            this.tabPage3.Controls.Add(this.textDirection8);
            this.tabPage3.Controls.Add(this.textDirection7);
            this.tabPage3.Controls.Add(this.textDirection6);
            this.tabPage3.Controls.Add(this.textDirection5);
            this.tabPage3.Controls.Add(this.textDirection4);
            this.tabPage3.Controls.Add(this.textDirection3);
            this.tabPage3.Controls.Add(this.textDirection2);
            this.tabPage3.Controls.Add(this.textDirection1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(250, 224);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Directions";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(144, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = " 12";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(144, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = " 11";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(144, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 13);
            this.label13.TabIndex = 21;
            this.label13.Text = " 10";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(144, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = " 9";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = " 8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = " 7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "6";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(69, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = " 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = " 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = " 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = " 1";
            // 
            // textDirection12
            // 
            this.textDirection12.Location = new System.Drawing.Point(166, 149);
            this.textDirection12.Name = "textDirection12";
            this.textDirection12.Size = new System.Drawing.Size(40, 20);
            this.textDirection12.TabIndex = 11;
            // 
            // textDirection11
            // 
            this.textDirection11.Location = new System.Drawing.Point(166, 104);
            this.textDirection11.Name = "textDirection11";
            this.textDirection11.Size = new System.Drawing.Size(40, 20);
            this.textDirection11.TabIndex = 10;
            // 
            // textDirection10
            // 
            this.textDirection10.Location = new System.Drawing.Point(166, 62);
            this.textDirection10.Name = "textDirection10";
            this.textDirection10.Size = new System.Drawing.Size(40, 20);
            this.textDirection10.TabIndex = 9;
            // 
            // textDirection9
            // 
            this.textDirection9.Location = new System.Drawing.Point(166, 17);
            this.textDirection9.Name = "textDirection9";
            this.textDirection9.Size = new System.Drawing.Size(40, 20);
            this.textDirection9.TabIndex = 8;
            // 
            // textDirection8
            // 
            this.textDirection8.Location = new System.Drawing.Point(91, 149);
            this.textDirection8.Name = "textDirection8";
            this.textDirection8.Size = new System.Drawing.Size(40, 20);
            this.textDirection8.TabIndex = 7;
            // 
            // textDirection7
            // 
            this.textDirection7.Location = new System.Drawing.Point(91, 104);
            this.textDirection7.Name = "textDirection7";
            this.textDirection7.Size = new System.Drawing.Size(40, 20);
            this.textDirection7.TabIndex = 6;
            // 
            // textDirection6
            // 
            this.textDirection6.Location = new System.Drawing.Point(91, 62);
            this.textDirection6.Name = "textDirection6";
            this.textDirection6.Size = new System.Drawing.Size(40, 20);
            this.textDirection6.TabIndex = 5;
            // 
            // textDirection5
            // 
            this.textDirection5.Location = new System.Drawing.Point(91, 17);
            this.textDirection5.Name = "textDirection5";
            this.textDirection5.Size = new System.Drawing.Size(40, 20);
            this.textDirection5.TabIndex = 4;
            // 
            // textDirection4
            // 
            this.textDirection4.Location = new System.Drawing.Point(22, 149);
            this.textDirection4.Name = "textDirection4";
            this.textDirection4.Size = new System.Drawing.Size(40, 20);
            this.textDirection4.TabIndex = 3;
            // 
            // textDirection3
            // 
            this.textDirection3.Location = new System.Drawing.Point(22, 104);
            this.textDirection3.Name = "textDirection3";
            this.textDirection3.Size = new System.Drawing.Size(40, 20);
            this.textDirection3.TabIndex = 2;
            // 
            // textDirection2
            // 
            this.textDirection2.Location = new System.Drawing.Point(22, 62);
            this.textDirection2.Name = "textDirection2";
            this.textDirection2.Size = new System.Drawing.Size(40, 20);
            this.textDirection2.TabIndex = 1;
            // 
            // textDirection1
            // 
            this.textDirection1.Location = new System.Drawing.Point(22, 17);
            this.textDirection1.Multiline = true;
            this.textDirection1.Name = "textDirection1";
            this.textDirection1.Size = new System.Drawing.Size(40, 16);
            this.textDirection1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(144, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 22);
            this.button2.TabIndex = 7;
            this.button2.Text = "Reset to defaults";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.OldLace;
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.checkBoxTop);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(250, 224);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Appearance";
            // 
            // checkBoxTop
            // 
            this.checkBoxTop.AutoSize = true;
            this.checkBoxTop.Location = new System.Drawing.Point(13, 21);
            this.checkBoxTop.Name = "checkBoxTop";
            this.checkBoxTop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxTop.Size = new System.Drawing.Size(96, 17);
            this.checkBoxTop.TabIndex = 0;
            this.checkBoxTop.Text = "Always on Top";
            this.checkBoxTop.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(104, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(10, 73);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 13);
            this.label17.TabIndex = 9;
            this.label17.Text = "Main form color";
            // 
            // NumComboBox1
            // 
            this.NumComboBox1.FormattingEnabled = true;
            this.NumComboBox1.Location = new System.Drawing.Point(6, 131);
            this.NumComboBox1.Name = "NumComboBox1";
            this.NumComboBox1.Size = new System.Drawing.Size(45, 21);
            this.NumComboBox1.TabIndex = 8;
            // 
            // NumComboBox2
            // 
            this.NumComboBox2.FormattingEnabled = true;
            this.NumComboBox2.Location = new System.Drawing.Point(62, 131);
            this.NumComboBox2.Name = "NumComboBox2";
            this.NumComboBox2.Size = new System.Drawing.Size(45, 21);
            this.NumComboBox2.TabIndex = 23;
            // 
            // NumComboBox3
            // 
            this.NumComboBox3.FormattingEnabled = true;
            this.NumComboBox3.Location = new System.Drawing.Point(115, 131);
            this.NumComboBox3.Name = "NumComboBox3";
            this.NumComboBox3.Size = new System.Drawing.Size(45, 21);
            this.NumComboBox3.TabIndex = 24;
            // 
            // NumComboBox6
            // 
            this.NumComboBox6.FormattingEnabled = true;
            this.NumComboBox6.Location = new System.Drawing.Point(115, 104);
            this.NumComboBox6.Name = "NumComboBox6";
            this.NumComboBox6.Size = new System.Drawing.Size(45, 21);
            this.NumComboBox6.TabIndex = 27;
            // 
            // NumComboBox5
            // 
            this.NumComboBox5.FormattingEnabled = true;
            this.NumComboBox5.Location = new System.Drawing.Point(62, 104);
            this.NumComboBox5.Name = "NumComboBox5";
            this.NumComboBox5.Size = new System.Drawing.Size(45, 21);
            this.NumComboBox5.TabIndex = 26;
            // 
            // NumComboBox4
            // 
            this.NumComboBox4.FormattingEnabled = true;
            this.NumComboBox4.Location = new System.Drawing.Point(6, 105);
            this.NumComboBox4.Name = "NumComboBox4";
            this.NumComboBox4.Size = new System.Drawing.Size(45, 21);
            this.NumComboBox4.TabIndex = 25;
            // 
            // NumComboBox9
            // 
            this.NumComboBox9.FormattingEnabled = true;
            this.NumComboBox9.Location = new System.Drawing.Point(115, 79);
            this.NumComboBox9.Name = "NumComboBox9";
            this.NumComboBox9.Size = new System.Drawing.Size(45, 21);
            this.NumComboBox9.TabIndex = 30;
            // 
            // NumComboBox8
            // 
            this.NumComboBox8.FormattingEnabled = true;
            this.NumComboBox8.Location = new System.Drawing.Point(62, 78);
            this.NumComboBox8.Name = "NumComboBox8";
            this.NumComboBox8.Size = new System.Drawing.Size(45, 21);
            this.NumComboBox8.TabIndex = 29;
            // 
            // NumComboBox7
            // 
            this.NumComboBox7.FormattingEnabled = true;
            this.NumComboBox7.Location = new System.Drawing.Point(6, 79);
            this.NumComboBox7.Name = "NumComboBox7";
            this.NumComboBox7.Size = new System.Drawing.Size(45, 21);
            this.NumComboBox7.TabIndex = 28;
            // 
            // NumComboBox10
            // 
            this.NumComboBox10.FormattingEnabled = true;
            this.NumComboBox10.Location = new System.Drawing.Point(6, 158);
            this.NumComboBox10.Name = "NumComboBox10";
            this.NumComboBox10.Size = new System.Drawing.Size(101, 21);
            this.NumComboBox10.TabIndex = 31;
            // 
            // NumComboBox11
            // 
            this.NumComboBox11.FormattingEnabled = true;
            this.NumComboBox11.Location = new System.Drawing.Point(166, 52);
            this.NumComboBox11.Name = "NumComboBox11";
            this.NumComboBox11.Size = new System.Drawing.Size(45, 21);
            this.NumComboBox11.TabIndex = 32;
            // 
            // NumComboBox12
            // 
            this.NumComboBox12.FormattingEnabled = true;
            this.NumComboBox12.Location = new System.Drawing.Point(166, 91);
            this.NumComboBox12.Name = "NumComboBox12";
            this.NumComboBox12.Size = new System.Drawing.Size(45, 21);
            this.NumComboBox12.TabIndex = 33;
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 315);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConfigForm";
            this.Text = "LL-ECW";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox HostTextBox;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox AllowNumLock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textDirection12;
        private System.Windows.Forms.TextBox textDirection11;
        private System.Windows.Forms.TextBox textDirection10;
        private System.Windows.Forms.TextBox textDirection9;
        private System.Windows.Forms.TextBox textDirection8;
        private System.Windows.Forms.TextBox textDirection7;
        private System.Windows.Forms.TextBox textDirection6;
        private System.Windows.Forms.TextBox textDirection5;
        private System.Windows.Forms.TextBox textDirection4;
        private System.Windows.Forms.TextBox textDirection3;
        private System.Windows.Forms.TextBox textDirection2;
        private System.Windows.Forms.TextBox textDirection1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBoxRetry;
        private System.Windows.Forms.TextBox textBoxTimeout;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.CheckBox AllowHotKey;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckBox checkBoxTop;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox NumComboBox1;
        private System.Windows.Forms.ComboBox NumComboBox10;
        private System.Windows.Forms.ComboBox NumComboBox9;
        private System.Windows.Forms.ComboBox NumComboBox8;
        private System.Windows.Forms.ComboBox NumComboBox7;
        private System.Windows.Forms.ComboBox NumComboBox6;
        private System.Windows.Forms.ComboBox NumComboBox5;
        private System.Windows.Forms.ComboBox NumComboBox4;
        private System.Windows.Forms.ComboBox NumComboBox3;
        private System.Windows.Forms.ComboBox NumComboBox2;
        private System.Windows.Forms.ComboBox NumComboBox12;
        private System.Windows.Forms.ComboBox NumComboBox11;
    }
}