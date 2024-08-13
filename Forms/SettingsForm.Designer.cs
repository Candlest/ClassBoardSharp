namespace ClassBoard.Forms
{
    partial class SettingsForm
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
            this.tabPage_frontend = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage_backend = new System.Windows.Forms.TabPage();
            this.groupBox_Windows = new System.Windows.Forms.GroupBox();
            this.checkBox_AsBackground = new System.Windows.Forms.CheckBox();
            this.checkBox_QuietLoad = new System.Windows.Forms.CheckBox();
            this.groupBox_CEF = new System.Windows.Forms.GroupBox();
            this.checkBox_DisableGPU = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_LogSeverity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_RemoteDebuggingPort = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_Timer = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_Interval = new System.Windows.Forms.NumericUpDown();
            this.button_apply = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_frontend.SuspendLayout();
            this.tabPage_backend.SuspendLayout();
            this.groupBox_Windows.SuspendLayout();
            this.groupBox_CEF.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_LogSeverity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RemoteDebuggingPort)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Interval)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage_frontend
            // 
            this.tabPage_frontend.Controls.Add(this.button4);
            this.tabPage_frontend.Controls.Add(this.button3);
            this.tabPage_frontend.Controls.Add(this.button1);
            this.tabPage_frontend.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage_frontend.Location = new System.Drawing.Point(4, 28);
            this.tabPage_frontend.Name = "tabPage_frontend";
            this.tabPage_frontend.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_frontend.Size = new System.Drawing.Size(1116, 424);
            this.tabPage_frontend.TabIndex = 1;
            this.tabPage_frontend.Text = "壁纸设置";
            this.tabPage_frontend.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(355, 76);
            this.button1.TabIndex = 0;
            this.button1.Text = "编辑告示牌";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(355, 76);
            this.button3.TabIndex = 2;
            this.button3.Text = "编辑课程表";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 88);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(355, 76);
            this.button4.TabIndex = 3;
            this.button4.Text = "编辑倒计日";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage_backend
            // 
            this.tabPage_backend.Controls.Add(this.button_apply);
            this.tabPage_backend.Controls.Add(this.groupBox1);
            this.tabPage_backend.Controls.Add(this.groupBox_CEF);
            this.tabPage_backend.Controls.Add(this.groupBox_Windows);
            this.tabPage_backend.Font = new System.Drawing.Font("宋体", 9F);
            this.tabPage_backend.Location = new System.Drawing.Point(4, 28);
            this.tabPage_backend.Name = "tabPage_backend";
            this.tabPage_backend.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_backend.Size = new System.Drawing.Size(1116, 424);
            this.tabPage_backend.TabIndex = 0;
            this.tabPage_backend.Text = "ClassBoard设置";
            this.tabPage_backend.UseVisualStyleBackColor = true;
            // 
            // groupBox_Windows
            // 
            this.groupBox_Windows.Controls.Add(this.checkBox_QuietLoad);
            this.groupBox_Windows.Controls.Add(this.checkBox_AsBackground);
            this.groupBox_Windows.Location = new System.Drawing.Point(6, 6);
            this.groupBox_Windows.Name = "groupBox_Windows";
            this.groupBox_Windows.Size = new System.Drawing.Size(537, 129);
            this.groupBox_Windows.TabIndex = 0;
            this.groupBox_Windows.TabStop = false;
            this.groupBox_Windows.Text = "Windows";
            // 
            // checkBox_AsBackground
            // 
            this.checkBox_AsBackground.AutoSize = true;
            this.checkBox_AsBackground.Location = new System.Drawing.Point(6, 41);
            this.checkBox_AsBackground.Name = "checkBox_AsBackground";
            this.checkBox_AsBackground.Size = new System.Drawing.Size(106, 22);
            this.checkBox_AsBackground.TabIndex = 0;
            this.checkBox_AsBackground.Text = "作为背景";
            this.checkBox_AsBackground.UseVisualStyleBackColor = true;
            // 
            // checkBox_QuietLoad
            // 
            this.checkBox_QuietLoad.AutoSize = true;
            this.checkBox_QuietLoad.Location = new System.Drawing.Point(6, 81);
            this.checkBox_QuietLoad.Name = "checkBox_QuietLoad";
            this.checkBox_QuietLoad.Size = new System.Drawing.Size(106, 22);
            this.checkBox_QuietLoad.TabIndex = 1;
            this.checkBox_QuietLoad.Text = "静默启动";
            this.checkBox_QuietLoad.UseVisualStyleBackColor = true;
            // 
            // groupBox_CEF
            // 
            this.groupBox_CEF.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_CEF.Controls.Add(this.numericUpDown_RemoteDebuggingPort);
            this.groupBox_CEF.Controls.Add(this.label2);
            this.groupBox_CEF.Controls.Add(this.numericUpDown_LogSeverity);
            this.groupBox_CEF.Controls.Add(this.label1);
            this.groupBox_CEF.Controls.Add(this.checkBox_DisableGPU);
            this.groupBox_CEF.Location = new System.Drawing.Point(6, 141);
            this.groupBox_CEF.Name = "groupBox_CEF";
            this.groupBox_CEF.Size = new System.Drawing.Size(537, 198);
            this.groupBox_CEF.TabIndex = 2;
            this.groupBox_CEF.TabStop = false;
            this.groupBox_CEF.Text = "CEF框架";
            // 
            // checkBox_DisableGPU
            // 
            this.checkBox_DisableGPU.AutoSize = true;
            this.checkBox_DisableGPU.Location = new System.Drawing.Point(6, 41);
            this.checkBox_DisableGPU.Name = "checkBox_DisableGPU";
            this.checkBox_DisableGPU.Size = new System.Drawing.Size(142, 22);
            this.checkBox_DisableGPU.TabIndex = 0;
            this.checkBox_DisableGPU.Text = "禁用硬件加速";
            this.checkBox_DisableGPU.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "日志等级";
            // 
            // numericUpDown_LogSeverity
            // 
            this.numericUpDown_LogSeverity.Location = new System.Drawing.Point(485, 81);
            this.numericUpDown_LogSeverity.Name = "numericUpDown_LogSeverity";
            this.numericUpDown_LogSeverity.Size = new System.Drawing.Size(46, 28);
            this.numericUpDown_LogSeverity.TabIndex = 3;
            this.numericUpDown_LogSeverity.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "远程调试端口";
            // 
            // numericUpDown_RemoteDebuggingPort
            // 
            this.numericUpDown_RemoteDebuggingPort.Location = new System.Drawing.Point(316, 131);
            this.numericUpDown_RemoteDebuggingPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.numericUpDown_RemoteDebuggingPort.Name = "numericUpDown_RemoteDebuggingPort";
            this.numericUpDown_RemoteDebuggingPort.Size = new System.Drawing.Size(215, 28);
            this.numericUpDown_RemoteDebuggingPort.TabIndex = 5;
            this.numericUpDown_RemoteDebuggingPort.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.numericUpDown_Interval);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.checkBox_Timer);
            this.groupBox1.Location = new System.Drawing.Point(549, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 333);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "壁纸接管修复";
            // 
            // checkBox_Timer
            // 
            this.checkBox_Timer.AutoSize = true;
            this.checkBox_Timer.Location = new System.Drawing.Point(6, 41);
            this.checkBox_Timer.Name = "checkBox_Timer";
            this.checkBox_Timer.Size = new System.Drawing.Size(106, 22);
            this.checkBox_Timer.TabIndex = 0;
            this.checkBox_Timer.Text = "启用检测";
            this.checkBox_Timer.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "执行间隔（ms）";
            // 
            // numericUpDown_Interval
            // 
            this.numericUpDown_Interval.Location = new System.Drawing.Point(316, 81);
            this.numericUpDown_Interval.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_Interval.Name = "numericUpDown_Interval";
            this.numericUpDown_Interval.Size = new System.Drawing.Size(244, 28);
            this.numericUpDown_Interval.TabIndex = 3;
            this.numericUpDown_Interval.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // button_apply
            // 
            this.button_apply.Location = new System.Drawing.Point(865, 373);
            this.button_apply.Name = "button_apply";
            this.button_apply.Size = new System.Drawing.Size(249, 51);
            this.button_apply.TabIndex = 7;
            this.button_apply.Text = "应用";
            this.button_apply.UseVisualStyleBackColor = true;
            this.button_apply.Click += new System.EventHandler(this.button_apply_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_backend);
            this.tabControl1.Controls.Add(this.tabPage_frontend);
            this.tabControl1.Font = new System.Drawing.Font("宋体", 9F);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1124, 456);
            this.tabControl1.TabIndex = 0;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 480);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tabPage_frontend.ResumeLayout(false);
            this.tabPage_backend.ResumeLayout(false);
            this.groupBox_Windows.ResumeLayout(false);
            this.groupBox_Windows.PerformLayout();
            this.groupBox_CEF.ResumeLayout(false);
            this.groupBox_CEF.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_LogSeverity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_RemoteDebuggingPort)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Interval)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage_frontend;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage_backend;
        private System.Windows.Forms.Button button_apply;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Interval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBox_Timer;
        private System.Windows.Forms.GroupBox groupBox_CEF;
        private System.Windows.Forms.NumericUpDown numericUpDown_RemoteDebuggingPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_LogSeverity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_DisableGPU;
        private System.Windows.Forms.GroupBox groupBox_Windows;
        private System.Windows.Forms.CheckBox checkBox_QuietLoad;
        private System.Windows.Forms.CheckBox checkBox_AsBackground;
        private System.Windows.Forms.TabControl tabControl1;
    }
}