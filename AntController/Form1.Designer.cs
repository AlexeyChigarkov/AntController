using System;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;

namespace AntController
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private ConnectionProvider provider;

        public Configuration config;

        public ConfigForm ConfigForm;
        delegate void SetTextCallback(string text);
        delegate void SetTextCallback2(bool connect);

        private ControllerCondition controllerCondition;

        private KeyHandler ghk;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radio4 = new System.Windows.Forms.RadioButton();
            this.radio10 = new System.Windows.Forms.RadioButton();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.radio7 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.radio5 = new System.Windows.Forms.RadioButton();
            this.radio6 = new System.Windows.Forms.RadioButton();
            this.radio8 = new System.Windows.Forms.RadioButton();
            this.radio9 = new System.Windows.Forms.RadioButton();
            this.radio11 = new System.Windows.Forms.RadioButton();
            this.radio12 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.connectButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.round40 = new AntController.RoundButton();
            this.round80 = new AntController.RoundButton();
            this.round160 = new AntController.RoundButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.roundLnaOff = new AntController.RoundButton();
            this.roundLna24 = new AntController.RoundButton();
            this.roundLna12 = new AntController.RoundButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.roundTX = new AntController.RoundButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(382, 335);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // radio4
            // 
            this.radio4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radio4.AutoSize = true;
            this.radio4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radio4.Checked = true;
            this.radio4.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radio4.Location = new System.Drawing.Point(358, 168);
            this.radio4.Name = "radio4";
            this.radio4.Size = new System.Drawing.Size(35, 19);
            this.radio4.TabIndex = 1;
            this.radio4.TabStop = true;
            this.radio4.Text = "90";
            this.radio4.UseVisualStyleBackColor = false;
            this.radio4.CheckedChanged += new System.EventHandler(this.radio4_CheckedChanged);
            // 
            // radio10
            // 
            this.radio10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radio10.AutoSize = true;
            this.radio10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radio10.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radio10.Location = new System.Drawing.Point(28, 168);
            this.radio10.Name = "radio10";
            this.radio10.Size = new System.Drawing.Size(40, 19);
            this.radio10.TabIndex = 2;
            this.radio10.Text = "270";
            this.radio10.UseVisualStyleBackColor = false;
            this.radio10.CheckedChanged += new System.EventHandler(this.radio10_CheckedChanged);
            // 
            // radio1
            // 
            this.radio1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radio1.AutoSize = true;
            this.radio1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radio1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radio1.Location = new System.Drawing.Point(193, 15);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(30, 19);
            this.radio1.TabIndex = 3;
            this.radio1.Text = "0";
            this.radio1.UseVisualStyleBackColor = false;
            this.radio1.CheckedChanged += new System.EventHandler(this.radio1_CheckedChanged);
            // 
            // radio7
            // 
            this.radio7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radio7.AutoSize = true;
            this.radio7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radio7.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radio7.Location = new System.Drawing.Point(193, 316);
            this.radio7.Name = "radio7";
            this.radio7.Size = new System.Drawing.Size(40, 19);
            this.radio7.TabIndex = 4;
            this.radio7.Text = "180";
            this.radio7.UseVisualStyleBackColor = false;
            this.radio7.CheckedChanged += new System.EventHandler(this.radio7_CheckedChanged);
            // 
            // radio2
            // 
            this.radio2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radio2.AutoSize = true;
            this.radio2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radio2.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radio2.Location = new System.Drawing.Point(270, 41);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(35, 19);
            this.radio2.TabIndex = 13;
            this.radio2.Text = "30";
            this.radio2.UseVisualStyleBackColor = false;
            this.radio2.CheckedChanged += new System.EventHandler(this.radio2_CheckedChanged);
            // 
            // radio3
            // 
            this.radio3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radio3.AutoSize = true;
            this.radio3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radio3.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radio3.Location = new System.Drawing.Point(338, 109);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(35, 19);
            this.radio3.TabIndex = 14;
            this.radio3.Text = "60";
            this.radio3.UseVisualStyleBackColor = false;
            this.radio3.CheckedChanged += new System.EventHandler(this.radio3_CheckedChanged);
            // 
            // radio5
            // 
            this.radio5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radio5.AutoSize = true;
            this.radio5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radio5.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radio5.Location = new System.Drawing.Point(333, 238);
            this.radio5.Name = "radio5";
            this.radio5.Size = new System.Drawing.Size(40, 19);
            this.radio5.TabIndex = 15;
            this.radio5.Text = "120";
            this.radio5.UseVisualStyleBackColor = false;
            this.radio5.CheckedChanged += new System.EventHandler(this.radio5_CheckedChanged);
            // 
            // radio6
            // 
            this.radio6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radio6.AutoSize = true;
            this.radio6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radio6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.radio6.Cursor = System.Windows.Forms.Cursors.Default;
            this.radio6.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radio6.Location = new System.Drawing.Point(286, 295);
            this.radio6.Name = "radio6";
            this.radio6.Size = new System.Drawing.Size(40, 19);
            this.radio6.TabIndex = 16;
            this.radio6.Text = "150";
            this.radio6.UseVisualStyleBackColor = false;
            this.radio6.CheckedChanged += new System.EventHandler(this.radio6_CheckedChanged);
            // 
            // radio8
            // 
            this.radio8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radio8.AutoSize = true;
            this.radio8.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radio8.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radio8.Location = new System.Drawing.Point(110, 295);
            this.radio8.Name = "radio8";
            this.radio8.Size = new System.Drawing.Size(40, 19);
            this.radio8.TabIndex = 17;
            this.radio8.Text = "210";
            this.radio8.UseVisualStyleBackColor = false;
            this.radio8.CheckedChanged += new System.EventHandler(this.radio8_CheckedChanged);
            // 
            // radio9
            // 
            this.radio9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radio9.AutoSize = true;
            this.radio9.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radio9.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radio9.Location = new System.Drawing.Point(44, 238);
            this.radio9.Name = "radio9";
            this.radio9.Size = new System.Drawing.Size(40, 19);
            this.radio9.TabIndex = 18;
            this.radio9.Text = "240";
            this.radio9.UseVisualStyleBackColor = false;
            this.radio9.CheckedChanged += new System.EventHandler(this.radio9_CheckedChanged);
            // 
            // radio11
            // 
            this.radio11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radio11.AutoSize = true;
            this.radio11.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radio11.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radio11.Location = new System.Drawing.Point(44, 109);
            this.radio11.Name = "radio11";
            this.radio11.Size = new System.Drawing.Size(40, 19);
            this.radio11.TabIndex = 19;
            this.radio11.Text = "300";
            this.radio11.UseVisualStyleBackColor = false;
            this.radio11.CheckedChanged += new System.EventHandler(this.radio11_CheckedChanged);
            // 
            // radio12
            // 
            this.radio12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radio12.AutoSize = true;
            this.radio12.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.radio12.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radio12.Location = new System.Drawing.Point(88, 55);
            this.radio12.Name = "radio12";
            this.radio12.Size = new System.Drawing.Size(40, 19);
            this.radio12.TabIndex = 20;
            this.radio12.Text = "330";
            this.radio12.UseVisualStyleBackColor = false;
            this.radio12.CheckedChanged += new System.EventHandler(this.radio12_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(21, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 22);
            this.button2.TabIndex = 11;
            this.button2.Text = "Setttings";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // connectButton
            // 
            this.connectButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.connectButton.BackColor = System.Drawing.Color.LawnGreen;
            this.connectButton.Location = new System.Drawing.Point(154, 366);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(100, 22);
            this.connectButton.TabIndex = 12;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "OFF",
            "12 dB",
            "24 dB"});
            this.comboBox1.Location = new System.Drawing.Point(297, 366);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 21);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.round40);
            this.panel1.Controls.Add(this.round80);
            this.panel1.Controls.Add(this.round160);
            this.panel1.Location = new System.Drawing.Point(418, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(57, 152);
            this.panel1.TabIndex = 37;
            // 
            // round40
            // 
            this.round40.BackColor = System.Drawing.SystemColors.Control;
            this.round40.Location = new System.Drawing.Point(1, 94);
            this.round40.Name = "round40";
            this.round40.Size = new System.Drawing.Size(50, 44);
            this.round40.TabIndex = 33;
            this.round40.Text = "40";
            this.round40.UseVisualStyleBackColor = false;
            // 
            // round80
            // 
            this.round80.BackColor = System.Drawing.SystemColors.Control;
            this.round80.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.round80.ForeColor = System.Drawing.SystemColors.ControlText;
            this.round80.Location = new System.Drawing.Point(1, 55);
            this.round80.Name = "round80";
            this.round80.Size = new System.Drawing.Size(50, 44);
            this.round80.TabIndex = 32;
            this.round80.Text = "80";
            this.round80.UseVisualStyleBackColor = false;
            // 
            // round160
            // 
            this.round160.BackColor = System.Drawing.SystemColors.Control;
            this.round160.Location = new System.Drawing.Point(1, 5);
            this.round160.Name = "round160";
            this.round160.Size = new System.Drawing.Size(50, 44);
            this.round160.TabIndex = 31;
            this.round160.Text = "160";
            this.round160.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MintCream;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.roundLnaOff);
            this.panel2.Controls.Add(this.roundLna24);
            this.panel2.Controls.Add(this.roundLna12);
            this.panel2.Location = new System.Drawing.Point(418, 168);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(57, 146);
            this.panel2.TabIndex = 38;
            // 
            // roundLnaOff
            // 
            this.roundLnaOff.BackColor = System.Drawing.SystemColors.Control;
            this.roundLnaOff.Location = new System.Drawing.Point(3, 93);
            this.roundLnaOff.Name = "roundLnaOff";
            this.roundLnaOff.Size = new System.Drawing.Size(50, 44);
            this.roundLnaOff.TabIndex = 34;
            this.roundLnaOff.Text = "OFF";
            this.roundLnaOff.UseVisualStyleBackColor = false;
            // 
            // roundLna24
            // 
            this.roundLna24.BackColor = System.Drawing.SystemColors.Control;
            this.roundLna24.ForeColor = System.Drawing.SystemColors.ControlText;
            this.roundLna24.Location = new System.Drawing.Point(3, -2);
            this.roundLna24.Name = "roundLna24";
            this.roundLna24.Size = new System.Drawing.Size(50, 44);
            this.roundLna24.TabIndex = 36;
            this.roundLna24.Text = "24dB";
            this.roundLna24.UseVisualStyleBackColor = false;
            // 
            // roundLna12
            // 
            this.roundLna12.BackColor = System.Drawing.SystemColors.Control;
            this.roundLna12.Location = new System.Drawing.Point(1, 43);
            this.roundLna12.Name = "roundLna12";
            this.roundLna12.Size = new System.Drawing.Size(50, 44);
            this.roundLna12.TabIndex = 35;
            this.roundLna12.Text = "12dB";
            this.roundLna12.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.roundTX);
            this.panel3.Location = new System.Drawing.Point(418, 318);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(57, 58);
            this.panel3.TabIndex = 39;
            // 
            // roundTX
            // 
            this.roundTX.BackColor = System.Drawing.SystemColors.Control;
            this.roundTX.Location = new System.Drawing.Point(1, 0);
            this.roundTX.Name = "roundTX";
            this.roundTX.Size = new System.Drawing.Size(54, 52);
            this.roundTX.TabIndex = 37;
            this.roundTX.Text = "RX";
            this.roundTX.UseVisualStyleBackColor = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Antenna controller";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(498, 413);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.radio12);
            this.Controls.Add(this.radio11);
            this.Controls.Add(this.radio9);
            this.Controls.Add(this.radio8);
            this.Controls.Add(this.radio6);
            this.Controls.Add(this.radio5);
            this.Controls.Add(this.radio3);
            this.Controls.Add(this.radio2);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radio7);
            this.Controls.Add(this.radio1);
            this.Controls.Add(this.radio10);
            this.Controls.Add(this.radio4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "LL-ECW";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;

        private void Form1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
          
                if ( config.AllowNumLock && ( e.KeyCode >= Keys.NumPad0 || e.KeyCode <= Keys.NumPad9 || e.KeyCode == Keys.Add || e.KeyCode == Keys.Subtract))
                {
                    string number;
                    string name;
                    RadioButton radio;
                    switch (e.KeyCode)
                    {
                    case Keys.NumPad4:
                        number = (config.NumKeys[3]+1).ToString();
                        name = "radio" + number;
                        radio = (RadioButton)this.Controls[name];
                        radio.Checked = true;
                        break;
                    case Keys.NumPad8:
                        number = (config.NumKeys[7]+1).ToString();
                        name = "radio" + number;
                        radio = (RadioButton)this.Controls[name];
                        radio.Checked = true;
                        break;
                    case Keys.NumPad6:
                        number = (config.NumKeys[5]+1).ToString();
                        name = "radio" + number;
                        radio = (RadioButton)this.Controls[name];
                        radio.Checked = true;
                        break;
                    case Keys.NumPad5:
                        number = (config.NumKeys[4]+1).ToString();
                        name = "radio" + number;
                        radio = (RadioButton)this.Controls[name];
                        radio.Checked = true;
                        break;
                    case Keys.NumPad0:
                        number = (config.NumKeys[9]+1).ToString();
                        name = "radio" + number;
                        radio = (RadioButton)this.Controls[name];
                        radio.Checked = true;
                        break;
                    case Keys.NumPad1:
                        number = (config.NumKeys[0]+1).ToString();
                        name = "radio" + number;
                        radio = (RadioButton)this.Controls[name];
                        radio.Checked = true;
                        break;
                    case Keys.NumPad2:
                        number = (config.NumKeys[1]+1).ToString();
                        name = "radio" + number;
                        radio = (RadioButton)this.Controls[name];
                        radio.Checked = true;
                        break;
                    case Keys.NumPad3:
                        number = (config.NumKeys[2]+1).ToString();
                        name = "radio" + number;
                        radio = (RadioButton)this.Controls[name];
                        radio.Checked = true;
                        break;
                    case Keys.NumPad7:
                        number = (config.NumKeys[6]+1).ToString();
                        name = "radio" + number;
                        radio = (RadioButton)this.Controls[name];                                                
                        radio.Checked = true;
                        break;
                    case Keys.NumPad9:
                        number = (config.NumKeys[8]+1).ToString();
                        name = "radio" + number;
                        radio = (RadioButton)this.Controls[name];
                        radio.Checked = true;
                        break;
                    case Keys.Add:
                        number = (config.NumKeys[11]+1).ToString();
                        name = "radio" + number;
                        radio = (RadioButton)this.Controls[name];
                        radio.Checked = true;
                        break;
                    case Keys.Subtract:
                        number = (config.NumKeys[10]+1).ToString();
                        name = "radio" + number;
                        radio = (RadioButton)this.Controls[name];
                        radio.Checked = true;
                        break;

                }
                }

                e.Handled = true;
        }


        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                case Keys.Up:
                case Keys.Left: 
                case Keys.Right:
                    e.IsInputKey = true;
                    break;
            }
        }

        

        private RadioButton radio4;
        private RadioButton radio10;
        private RadioButton radio1;
        private RadioButton radio7;
        private RadioButton radio2;
        private RadioButton radio3;
        private RadioButton radio5;
        private RadioButton radio6;
        private RadioButton radio8;
        private RadioButton radio9;
        private RadioButton radio11;
        private RadioButton radio12;
        private Button button2;
        private Button connectButton;
        private ComboBox comboBox1;
        private RoundButton round160;
        private RoundButton round80;
        private RoundButton round40;
        private RoundButton roundLnaOff;
        private RoundButton roundLna12;
        private RoundButton roundLna24;
        private Panel panel1;
        private Panel panel2;
        private RoundButton roundTX;
        private Panel panel3;
        private NotifyIcon notifyIcon1;
    }
}

