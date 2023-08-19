namespace ClassBoard
{
    partial class SettingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingPage));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabBoard = new System.Windows.Forms.TabPage();
            this.tabEvents = new System.Windows.Forms.TabPage();
            this.textBox_board = new System.Windows.Forms.TextBox();
            this.textBox_events = new System.Windows.Forms.TextBox();
            this.tabSchedule = new System.Windows.Forms.TabPage();
            this.textBox_schedule = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_save_board = new System.Windows.Forms.Button();
            this.button_save_events = new System.Windows.Forms.Button();
            this.button_save_schedule = new System.Windows.Forms.Button();
            this.tab_css = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tab_autorun = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.button_open = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabBoard.SuspendLayout();
            this.tabEvents.SuspendLayout();
            this.tabSchedule.SuspendLayout();
            this.tab_css.SuspendLayout();
            this.tab_autorun.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabBoard);
            this.tabControl.Controls.Add(this.tabEvents);
            this.tabControl.Controls.Add(this.tabSchedule);
            this.tabControl.Controls.Add(this.tab_css);
            this.tabControl.Controls.Add(this.tab_autorun);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(940, 476);
            this.tabControl.TabIndex = 0;
            // 
            // tabBoard
            // 
            this.tabBoard.Controls.Add(this.button_save_board);
            this.tabBoard.Controls.Add(this.label1);
            this.tabBoard.Controls.Add(this.textBox_board);
            this.tabBoard.Location = new System.Drawing.Point(4, 25);
            this.tabBoard.Name = "tabBoard";
            this.tabBoard.Padding = new System.Windows.Forms.Padding(3);
            this.tabBoard.Size = new System.Drawing.Size(932, 447);
            this.tabBoard.TabIndex = 0;
            this.tabBoard.Text = "告示牌内容";
            this.tabBoard.UseVisualStyleBackColor = true;
            // 
            // tabEvents
            // 
            this.tabEvents.Controls.Add(this.button_save_events);
            this.tabEvents.Controls.Add(this.label2);
            this.tabEvents.Controls.Add(this.textBox_events);
            this.tabEvents.Location = new System.Drawing.Point(4, 25);
            this.tabEvents.Name = "tabEvents";
            this.tabEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tabEvents.Size = new System.Drawing.Size(932, 447);
            this.tabEvents.TabIndex = 1;
            this.tabEvents.Text = "事件倒计日";
            this.tabEvents.UseVisualStyleBackColor = true;
            // 
            // textBox_board
            // 
            this.textBox_board.Location = new System.Drawing.Point(6, 128);
            this.textBox_board.Multiline = true;
            this.textBox_board.Name = "textBox_board";
            this.textBox_board.Size = new System.Drawing.Size(920, 310);
            this.textBox_board.TabIndex = 0;
            // 
            // textBox_events
            // 
            this.textBox_events.Location = new System.Drawing.Point(6, 128);
            this.textBox_events.Multiline = true;
            this.textBox_events.Name = "textBox_events";
            this.textBox_events.Size = new System.Drawing.Size(920, 295);
            this.textBox_events.TabIndex = 1;
            // 
            // tabSchedule
            // 
            this.tabSchedule.Controls.Add(this.button_save_schedule);
            this.tabSchedule.Controls.Add(this.label3);
            this.tabSchedule.Controls.Add(this.textBox_schedule);
            this.tabSchedule.Location = new System.Drawing.Point(4, 25);
            this.tabSchedule.Name = "tabSchedule";
            this.tabSchedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabSchedule.Size = new System.Drawing.Size(932, 447);
            this.tabSchedule.TabIndex = 2;
            this.tabSchedule.Text = "课表";
            this.tabSchedule.UseVisualStyleBackColor = true;
            // 
            // textBox_schedule
            // 
            this.textBox_schedule.Location = new System.Drawing.Point(6, 128);
            this.textBox_schedule.Multiline = true;
            this.textBox_schedule.Name = "textBox_schedule";
            this.textBox_schedule.Size = new System.Drawing.Size(920, 315);
            this.textBox_schedule.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "此处的内容会被保存到程序运行目录下的 board.txt 。\r\n可以包含html标签，如<strong>, <ins>,  <del>等。\r\n换行符请使用<br>" +
    " 。\r\ne.g. 本周背诵：<br>《梦游天姥吟留别》《赤壁赋》";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(512, 75);
            this.label2.TabIndex = 2;
            this.label2.Text = "此处的内容会被保存到程序运行目录下的 events.txt 。\r\n第一行是表头，请勿修改。\r\n请按照：“事件，日期” 的格式添加条目。\r\ne.g. 高考, 202" +
    "4-06-07\r\n（注意，所有的逗号请使用英文半角符号的逗号，是\',\'而不是\'，\'！！！）";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(748, 75);
            this.label3.TabIndex = 2;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // button_save_board
            // 
            this.button_save_board.Location = new System.Drawing.Point(851, 99);
            this.button_save_board.Name = "button_save_board";
            this.button_save_board.Size = new System.Drawing.Size(75, 23);
            this.button_save_board.TabIndex = 2;
            this.button_save_board.Text = "保存\r\n";
            this.button_save_board.UseVisualStyleBackColor = true;
            this.button_save_board.Click += new System.EventHandler(this.button_save_board_Click);
            // 
            // button_save_events
            // 
            this.button_save_events.Location = new System.Drawing.Point(851, 99);
            this.button_save_events.Name = "button_save_events";
            this.button_save_events.Size = new System.Drawing.Size(75, 23);
            this.button_save_events.TabIndex = 3;
            this.button_save_events.Text = "保存\r\n";
            this.button_save_events.UseVisualStyleBackColor = true;
            this.button_save_events.Click += new System.EventHandler(this.button_save_events_Click);
            // 
            // button_save_schedule
            // 
            this.button_save_schedule.Location = new System.Drawing.Point(851, 99);
            this.button_save_schedule.Name = "button_save_schedule";
            this.button_save_schedule.Size = new System.Drawing.Size(75, 23);
            this.button_save_schedule.TabIndex = 3;
            this.button_save_schedule.Text = "保存\r\n";
            this.button_save_schedule.UseVisualStyleBackColor = true;
            this.button_save_schedule.Click += new System.EventHandler(this.button_save_schedule_Click);
            // 
            // tab_css
            // 
            this.tab_css.Controls.Add(this.linkLabel1);
            this.tab_css.Controls.Add(this.label4);
            this.tab_css.Location = new System.Drawing.Point(4, 25);
            this.tab_css.Name = "tab_css";
            this.tab_css.Padding = new System.Windows.Forms.Padding(3);
            this.tab_css.Size = new System.Drawing.Size(932, 447);
            this.tab_css.TabIndex = 3;
            this.tab_css.Text = "背景图片";
            this.tab_css.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(636, 75);
            this.label4.TabIndex = 2;
            this.label4.Text = "由于背景页和网页元素配色有强相关性，\r\n修改背景图片请至 Background/css/custom.css 。\r\n另外，背景程序即是 Background/ma" +
    "in.html 。\r\n网页和程序后端间使用对象 cef_obj 传递文件参数，详见 Help 页面 （即 README.html）。\r\n有任何问题欢迎到 Git" +
    "hub 页面提出 issue ：";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(337, 78);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(290, 15);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Class Board Sharp 的 Github 项目主页";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // tab_autorun
            // 
            this.tab_autorun.Controls.Add(this.button_open);
            this.tab_autorun.Controls.Add(this.label5);
            this.tab_autorun.Location = new System.Drawing.Point(4, 25);
            this.tab_autorun.Name = "tab_autorun";
            this.tab_autorun.Padding = new System.Windows.Forms.Padding(3);
            this.tab_autorun.Size = new System.Drawing.Size(932, 447);
            this.tab_autorun.TabIndex = 4;
            this.tab_autorun.Text = "开机自启动";
            this.tab_autorun.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(615, 150);
            this.label5.TabIndex = 3;
            this.label5.Text = "开机自启动仅在关闭冰点还原后可设置成功。\r\n详见：Help 页面 或者 README.html 。\r\n\r\n设置开机自启动方法：\r\n第一步： 按下“打开启动项文件夹" +
    "“按钮，此时本程序快捷方式已经自动复制到剪切板中；\r\n第二步：在启动项文件夹中右键粘贴快捷方式至文件夹中；\r\n\r\n关闭开机自启动方法：\r\n第一步： 按下“打开启" +
    "动项文件夹“按钮；\r\n第二步：在启动项文件夹中删除本程序的快捷方式；\r\n";
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(9, 272);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(149, 54);
            this.button_open.TabIndex = 4;
            this.button_open.Text = "打开启动项文件夹";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // SettingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 500);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingPage";
            this.Text = "Class Board 设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingPage_FormClosing);
            this.Load += new System.EventHandler(this.SettingPage_Load);
            this.tabControl.ResumeLayout(false);
            this.tabBoard.ResumeLayout(false);
            this.tabBoard.PerformLayout();
            this.tabEvents.ResumeLayout(false);
            this.tabEvents.PerformLayout();
            this.tabSchedule.ResumeLayout(false);
            this.tabSchedule.PerformLayout();
            this.tab_css.ResumeLayout(false);
            this.tab_css.PerformLayout();
            this.tab_autorun.ResumeLayout(false);
            this.tab_autorun.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabBoard;
        private System.Windows.Forms.TabPage tabEvents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_board;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_events;
        private System.Windows.Forms.TabPage tabSchedule;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_schedule;
        private System.Windows.Forms.Button button_save_board;
        private System.Windows.Forms.Button button_save_events;
        private System.Windows.Forms.Button button_save_schedule;
        private System.Windows.Forms.TabPage tab_css;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TabPage tab_autorun;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_open;
    }
}