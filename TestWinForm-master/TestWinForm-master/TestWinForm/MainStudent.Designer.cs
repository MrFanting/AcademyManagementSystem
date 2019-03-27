namespace TestWinForm
{
    partial class MainStudent
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Account = new System.Windows.Forms.ToolStripMenuItem();
            this.Info = new System.Windows.Forms.ToolStripMenuItem();
            this.pwd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Grade = new System.Windows.Forms.ToolStripMenuItem();
            this.Plan = new System.Windows.Forms.ToolStripMenuItem();
            this.Course = new System.Windows.Forms.ToolStripMenuItem();
            this.选课ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退课ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClassRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.借用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.归还ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Account,
            this.Grade,
            this.Plan,
            this.Course,
            this.ClassRoom});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1005, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Account
            // 
            this.Account.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Info,
            this.pwd,
            this.toolStripSeparator1,
            this.Exit});
            this.Account.Name = "Account";
            this.Account.Size = new System.Drawing.Size(68, 21);
            this.Account.Text = "账号管理";
            // 
            // Info
            // 
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(180, 22);
            this.Info.Text = "个人信息";
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // pwd
            // 
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(180, 22);
            this.pwd.Text = "修改密码";
            this.pwd.Click += new System.EventHandler(this.pwd_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(180, 22);
            this.Exit.Text = "退出";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Grade
            // 
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(68, 21);
            this.Grade.Text = "成绩查询";
            this.Grade.Click += new System.EventHandler(this.Grade_Click);
            // 
            // Plan
            // 
            this.Plan.Name = "Plan";
            this.Plan.Size = new System.Drawing.Size(92, 21);
            this.Plan.Text = "培养方案查询";
            this.Plan.Click += new System.EventHandler(this.Plan_Click);
            // 
            // Course
            // 
            this.Course.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.选课ToolStripMenuItem,
            this.退课ToolStripMenuItem});
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(68, 21);
            this.Course.Text = "课程管理";
            // 
            // 选课ToolStripMenuItem
            // 
            this.选课ToolStripMenuItem.Name = "选课ToolStripMenuItem";
            this.选课ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.选课ToolStripMenuItem.Text = "选课";
            this.选课ToolStripMenuItem.Click += new System.EventHandler(this.选课ToolStripMenuItem_Click);
            // 
            // 退课ToolStripMenuItem
            // 
            this.退课ToolStripMenuItem.Name = "退课ToolStripMenuItem";
            this.退课ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.退课ToolStripMenuItem.Text = "退课";
            // 
            // ClassRoom
            // 
            this.ClassRoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.借用ToolStripMenuItem,
            this.归还ToolStripMenuItem});
            this.ClassRoom.Name = "ClassRoom";
            this.ClassRoom.Size = new System.Drawing.Size(68, 21);
            this.ClassRoom.Text = "教室管理";
            this.ClassRoom.Click += new System.EventHandler(this.ClassRoom_Click);
            // 
            // 借用ToolStripMenuItem
            // 
            this.借用ToolStripMenuItem.Name = "借用ToolStripMenuItem";
            this.借用ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.借用ToolStripMenuItem.Text = "借用";
            // 
            // 归还ToolStripMenuItem
            // 
            this.归还ToolStripMenuItem.Name = "归还ToolStripMenuItem";
            this.归还ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.归还ToolStripMenuItem.Text = "归还";
            // 
            // MainStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 564);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainStudent";
            this.Text = "学生信息管理系统";
            this.Load += new System.EventHandler(this.main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Account;
        private System.Windows.Forms.ToolStripMenuItem Info;
        private System.Windows.Forms.ToolStripMenuItem pwd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.ToolStripMenuItem Grade;
        private System.Windows.Forms.ToolStripMenuItem Plan;
        private System.Windows.Forms.ToolStripMenuItem Course;
        private System.Windows.Forms.ToolStripMenuItem ClassRoom;
        private System.Windows.Forms.ToolStripMenuItem 选课ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退课ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借用ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 归还ToolStripMenuItem;
    }
}