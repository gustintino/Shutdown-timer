
namespace Shutdown_timer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.countdown_stop = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.seconds = new System.Windows.Forms.NumericUpDown();
            this.minutes = new System.Windows.Forms.NumericUpDown();
            this.hours = new System.Windows.Forms.NumericUpDown();
            this.countdown_start = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hours)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-2, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(293, 105);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.countdown_stop);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.seconds);
            this.tabPage2.Controls.Add(this.minutes);
            this.tabPage2.Controls.Add(this.hours);
            this.tabPage2.Controls.Add(this.countdown_start);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(285, 77);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Countdown";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // countdown_stop
            // 
            this.countdown_stop.Location = new System.Drawing.Point(232, 47);
            this.countdown_stop.Name = "countdown_stop";
            this.countdown_stop.Size = new System.Drawing.Size(46, 23);
            this.countdown_stop.TabIndex = 15;
            this.countdown_stop.Text = "Stop";
            this.countdown_stop.UseVisualStyleBackColor = true;
            this.countdown_stop.Visible = false;
            this.countdown_stop.Click += new System.EventHandler(this.countdown_stop_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Shutdown",
            "Reboot",
            "Sleep"});
            this.comboBox1.Location = new System.Drawing.Point(109, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 23);
            this.comboBox1.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "m";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "h";
            // 
            // seconds
            // 
            this.seconds.Location = new System.Drawing.Point(179, 15);
            this.seconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(43, 23);
            this.seconds.TabIndex = 10;
            this.seconds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.seconds.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // minutes
            // 
            this.minutes.Location = new System.Drawing.Point(109, 15);
            this.minutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(43, 23);
            this.minutes.TabIndex = 9;
            this.minutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.minutes.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // hours
            // 
            this.hours.Location = new System.Drawing.Point(39, 15);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(43, 23);
            this.hours.TabIndex = 8;
            this.hours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.hours.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // countdown_start
            // 
            this.countdown_start.Location = new System.Drawing.Point(231, 48);
            this.countdown_start.Name = "countdown_start";
            this.countdown_start.Size = new System.Drawing.Size(46, 23);
            this.countdown_start.TabIndex = 7;
            this.countdown_start.Text = "Start";
            this.countdown_start.UseVisualStyleBackColor = true;
            this.countdown_start.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(285, 77);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Specifc time";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 101);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button countdown_start;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NumericUpDown hours;
        private System.Windows.Forms.NumericUpDown seconds;
        private System.Windows.Forms.NumericUpDown minutes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button countdown_stop;
    }
}

