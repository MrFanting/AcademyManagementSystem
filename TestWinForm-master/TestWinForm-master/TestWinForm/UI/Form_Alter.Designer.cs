namespace TestWinForm.UI
{
    partial class Form_Alter
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
            this.lb_nowpwd = new System.Windows.Forms.Label();
            this.lb_newpwd0 = new System.Windows.Forms.Label();
            this.lb_newPwd1 = new System.Windows.Forms.Label();
            this.txt_nowpwd = new System.Windows.Forms.TextBox();
            this.txt_newpwd0 = new System.Windows.Forms.TextBox();
            this.txt_newpwd1 = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_nowpwd
            // 
            this.lb_nowpwd.AutoSize = true;
            this.lb_nowpwd.Location = new System.Drawing.Point(136, 56);
            this.lb_nowpwd.Name = "lb_nowpwd";
            this.lb_nowpwd.Size = new System.Drawing.Size(77, 14);
            this.lb_nowpwd.TabIndex = 0;
            this.lb_nowpwd.Text = "当前密码：";
            // 
            // lb_newpwd0
            // 
            this.lb_newpwd0.AutoSize = true;
            this.lb_newpwd0.Font = new System.Drawing.Font("宋体", 10F);
            this.lb_newpwd0.Location = new System.Drawing.Point(139, 103);
            this.lb_newpwd0.Name = "lb_newpwd0";
            this.lb_newpwd0.Size = new System.Drawing.Size(63, 14);
            this.lb_newpwd0.TabIndex = 1;
            this.lb_newpwd0.Text = "新密码：";
            // 
            // lb_newPwd1
            // 
            this.lb_newPwd1.AutoSize = true;
            this.lb_newPwd1.Font = new System.Drawing.Font("宋体", 10F);
            this.lb_newPwd1.Location = new System.Drawing.Point(139, 151);
            this.lb_newPwd1.Name = "lb_newPwd1";
            this.lb_newPwd1.Size = new System.Drawing.Size(63, 14);
            this.lb_newPwd1.TabIndex = 2;
            this.lb_newPwd1.Text = "新密码：";
            // 
            // txt_nowpwd
            // 
            this.txt_nowpwd.Location = new System.Drawing.Point(238, 53);
            this.txt_nowpwd.Name = "txt_nowpwd";
            this.txt_nowpwd.Size = new System.Drawing.Size(116, 23);
            this.txt_nowpwd.TabIndex = 3;
            // 
            // txt_newpwd0
            // 
            this.txt_newpwd0.Location = new System.Drawing.Point(238, 100);
            this.txt_newpwd0.Name = "txt_newpwd0";
            this.txt_newpwd0.Size = new System.Drawing.Size(116, 23);
            this.txt_newpwd0.TabIndex = 4;
            // 
            // txt_newpwd1
            // 
            this.txt_newpwd1.Font = new System.Drawing.Font("宋体", 10F);
            this.txt_newpwd1.Location = new System.Drawing.Point(238, 148);
            this.txt_newpwd1.Name = "txt_newpwd1";
            this.txt_newpwd1.Size = new System.Drawing.Size(116, 23);
            this.txt_newpwd1.TabIndex = 5;
            this.txt_newpwd1.Text = "再次输入新密码";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(138, 224);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "确认";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(279, 224);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // Form_Alter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 287);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_newpwd1);
            this.Controls.Add(this.txt_newpwd0);
            this.Controls.Add(this.txt_nowpwd);
            this.Controls.Add(this.lb_newPwd1);
            this.Controls.Add(this.lb_newpwd0);
            this.Controls.Add(this.lb_nowpwd);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.Name = "Form_Alter";
            this.Text = "修改密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_nowpwd;
        private System.Windows.Forms.Label lb_newpwd0;
        private System.Windows.Forms.Label lb_newPwd1;
        private System.Windows.Forms.TextBox txt_nowpwd;
        private System.Windows.Forms.TextBox txt_newpwd0;
        private System.Windows.Forms.TextBox txt_newpwd1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
    }
}