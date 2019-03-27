namespace TestWinForm.UI
{
    partial class Form_Pwd
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
            this.新密码 = new System.Windows.Forms.Label();
            this.新密码确认 = new System.Windows.Forms.Label();
            this.txt新密码 = new System.Windows.Forms.TextBox();
            this.txt新密码确认 = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 新密码
            // 
            this.新密码.AutoSize = true;
            this.新密码.Location = new System.Drawing.Point(77, 86);
            this.新密码.Name = "新密码";
            this.新密码.Size = new System.Drawing.Size(53, 12);
            this.新密码.TabIndex = 1;
            this.新密码.Text = "新密码：";
            // 
            // 新密码确认
            // 
            this.新密码确认.AutoSize = true;
            this.新密码确认.Location = new System.Drawing.Point(77, 165);
            this.新密码确认.Name = "新密码确认";
            this.新密码确认.Size = new System.Drawing.Size(53, 12);
            this.新密码确认.TabIndex = 2;
            this.新密码确认.Text = "新密码：";
            // 
            // txt新密码
            // 
            this.txt新密码.Location = new System.Drawing.Point(160, 83);
            this.txt新密码.Name = "txt新密码";
            this.txt新密码.PasswordChar = '*';
            this.txt新密码.Size = new System.Drawing.Size(100, 21);
            this.txt新密码.TabIndex = 4;
            // 
            // txt新密码确认
            // 
            this.txt新密码确认.Location = new System.Drawing.Point(160, 162);
            this.txt新密码确认.Name = "txt新密码确认";
            this.txt新密码确认.PasswordChar = '*';
            this.txt新密码确认.Size = new System.Drawing.Size(100, 21);
            this.txt新密码确认.TabIndex = 5;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(79, 268);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "确认";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(185, 268);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "重置";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // Form_Pwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 360);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt新密码确认);
            this.Controls.Add(this.txt新密码);
            this.Controls.Add(this.新密码确认);
            this.Controls.Add(this.新密码);
            this.Name = "Form_Pwd";
            this.Text = "Form_Pwd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label 新密码;
        private System.Windows.Forms.Label 新密码确认;
        private System.Windows.Forms.TextBox txt新密码;
        private System.Windows.Forms.TextBox txt新密码确认;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
    }
}