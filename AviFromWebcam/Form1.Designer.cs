namespace AviFromWebcam
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.hueBar = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.recordBtn = new System.Windows.Forms.Button();
            this.statusTxt = new System.Windows.Forms.Label();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.contBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.hueText = new System.Windows.Forms.TextBox();
            this.satBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.satText = new System.Windows.Forms.TextBox();
            this.brightnessBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.brightnessText = new System.Windows.Forms.TextBox();
            this.pixBar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.pixText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hueBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.satBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 240);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabPage1);
            this.mainTabControl.Controls.Add(this.tabPage2);
            this.mainTabControl.Location = new System.Drawing.Point(338, 12);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(303, 348);
            this.mainTabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(295, 322);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(10, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 153);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Video Device";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 113);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Refresh List";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Available devices";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start Selected Video Device";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(237, 69);
            this.listBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.pixText);
            this.tabPage2.Controls.Add(this.brightnessText);
            this.tabPage2.Controls.Add(this.satText);
            this.tabPage2.Controls.Add(this.hueText);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.pixBar);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.brightnessBar);
            this.tabPage2.Controls.Add(this.satBar);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.hueBar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(295, 322);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Filters";
            // 
            // hueBar
            // 
            this.hueBar.AutoSize = false;
            this.hueBar.BackColor = System.Drawing.Color.White;
            this.hueBar.Location = new System.Drawing.Point(15, 43);
            this.hueBar.Maximum = 360;
            this.hueBar.Name = "hueBar";
            this.hueBar.Size = new System.Drawing.Size(226, 39);
            this.hueBar.TabIndex = 0;
            this.hueBar.TickFrequency = 90;
            this.hueBar.Scroll += new System.EventHandler(this.hueBar_Scroll);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // recordBtn
            // 
            this.recordBtn.Location = new System.Drawing.Point(67, 314);
            this.recordBtn.Name = "recordBtn";
            this.recordBtn.Size = new System.Drawing.Size(92, 23);
            this.recordBtn.TabIndex = 2;
            this.recordBtn.Text = "Start Recording";
            this.recordBtn.UseVisualStyleBackColor = true;
            this.recordBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // statusTxt
            // 
            this.statusTxt.AutoSize = true;
            this.statusTxt.Location = new System.Drawing.Point(12, 255);
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.Size = new System.Drawing.Size(43, 13);
            this.statusTxt.TabIndex = 3;
            this.statusTxt.Text = "Waiting";
            // 
            // pauseBtn
            // 
            this.pauseBtn.Enabled = false;
            this.pauseBtn.Location = new System.Drawing.Point(15, 285);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(75, 23);
            this.pauseBtn.TabIndex = 4;
            this.pauseBtn.Text = "Pause";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // contBtn
            // 
            this.contBtn.Enabled = false;
            this.contBtn.Location = new System.Drawing.Point(120, 285);
            this.contBtn.Name = "contBtn";
            this.contBtn.Size = new System.Drawing.Size(75, 23);
            this.contBtn.TabIndex = 5;
            this.contBtn.Text = "Continue";
            this.contBtn.UseVisualStyleBackColor = true;
            this.contBtn.Click += new System.EventHandler(this.contBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hue";
            // 
            // hueText
            // 
            this.hueText.Location = new System.Drawing.Point(243, 43);
            this.hueText.Name = "hueText";
            this.hueText.Size = new System.Drawing.Size(38, 20);
            this.hueText.TabIndex = 2;
            this.hueText.Text = "0";
            this.hueText.TextChanged += new System.EventHandler(this.hueText_TextChanged);
            // 
            // satBar
            // 
            this.satBar.AutoSize = false;
            this.satBar.BackColor = System.Drawing.Color.White;
            this.satBar.Location = new System.Drawing.Point(15, 114);
            this.satBar.Maximum = 100;
            this.satBar.Name = "satBar";
            this.satBar.Size = new System.Drawing.Size(226, 39);
            this.satBar.TabIndex = 0;
            this.satBar.TickFrequency = 10;
            this.satBar.Scroll += new System.EventHandler(this.satBar_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Saturation";
            // 
            // satText
            // 
            this.satText.Location = new System.Drawing.Point(243, 114);
            this.satText.Name = "satText";
            this.satText.Size = new System.Drawing.Size(38, 20);
            this.satText.TabIndex = 2;
            this.satText.Text = "0";
            this.satText.TextChanged += new System.EventHandler(this.satText_TextChanged);
            // 
            // brightnessBar
            // 
            this.brightnessBar.AutoSize = false;
            this.brightnessBar.BackColor = System.Drawing.Color.White;
            this.brightnessBar.Location = new System.Drawing.Point(15, 179);
            this.brightnessBar.Maximum = 100;
            this.brightnessBar.Name = "brightnessBar";
            this.brightnessBar.Size = new System.Drawing.Size(226, 39);
            this.brightnessBar.TabIndex = 0;
            this.brightnessBar.TickFrequency = 10;
            this.brightnessBar.Scroll += new System.EventHandler(this.brightnessBar_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Brightness";
            // 
            // brightnessText
            // 
            this.brightnessText.Location = new System.Drawing.Point(243, 179);
            this.brightnessText.Name = "brightnessText";
            this.brightnessText.Size = new System.Drawing.Size(38, 20);
            this.brightnessText.TabIndex = 2;
            this.brightnessText.Text = "0";
            this.brightnessText.TextChanged += new System.EventHandler(this.brightnessText_TextChanged);
            // 
            // pixBar
            // 
            this.pixBar.AutoSize = false;
            this.pixBar.BackColor = System.Drawing.Color.White;
            this.pixBar.Location = new System.Drawing.Point(15, 249);
            this.pixBar.Maximum = 50;
            this.pixBar.Name = "pixBar";
            this.pixBar.Size = new System.Drawing.Size(226, 39);
            this.pixBar.TabIndex = 0;
            this.pixBar.TickFrequency = 10;
            this.pixBar.Scroll += new System.EventHandler(this.pixBar_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Pixellate";
            // 
            // pixText
            // 
            this.pixText.Location = new System.Drawing.Point(243, 249);
            this.pixText.Name = "pixText";
            this.pixText.Size = new System.Drawing.Size(38, 20);
            this.pixText.TabIndex = 2;
            this.pixText.Text = "0";
            this.pixText.TextChanged += new System.EventHandler(this.pixText_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 372);
            this.Controls.Add(this.contBtn);
            this.Controls.Add(this.pauseBtn);
            this.Controls.Add(this.statusTxt);
            this.Controls.Add(this.recordBtn);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Simple Webcam Recorder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hueBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.satBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightnessBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pixBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button recordBtn;
        private System.Windows.Forms.Label statusTxt;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Button contBtn;
        private System.Windows.Forms.TrackBar hueBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hueText;
        private System.Windows.Forms.TextBox satText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar satBar;
        private System.Windows.Forms.TextBox brightnessText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar brightnessBar;
        private System.Windows.Forms.TextBox pixText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar pixBar;
    }
}

