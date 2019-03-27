namespace TestWinForm.UI
{
    partial class Form_Account
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
            this.lb_account = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.txt_account = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lb_major = new System.Windows.Forms.Label();
            this.txt_class = new System.Windows.Forms.TextBox();
            this.lb_phone = new System.Windows.Forms.Label();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.lb_gender = new System.Windows.Forms.Label();
            this.txt_gender = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_birth = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_account
            // 
            this.lb_account.AutoSize = true;
            this.lb_account.Font = new System.Drawing.Font("宋体", 10F);
            this.lb_account.Location = new System.Drawing.Point(124, 55);
            this.lb_account.Name = "lb_account";
            this.lb_account.Size = new System.Drawing.Size(49, 14);
            this.lb_account.TabIndex = 0;
            this.lb_account.Text = "学号：";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("宋体", 10F);
            this.lb_name.Location = new System.Drawing.Point(124, 90);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(49, 14);
            this.lb_name.TabIndex = 2;
            this.lb_name.Text = "姓名：";
            // 
            // txt_account
            // 
            this.txt_account.BackColor = System.Drawing.SystemColors.Window;
            this.txt_account.Enabled = false;
            this.txt_account.Font = new System.Drawing.Font("宋体", 10F);
            this.txt_account.Location = new System.Drawing.Point(198, 52);
            this.txt_account.Name = "txt_account";
            this.txt_account.Size = new System.Drawing.Size(100, 23);
            this.txt_account.TabIndex = 3;
            // 
            // txt_name
            // 
            this.txt_name.Enabled = false;
            this.txt_name.Font = new System.Drawing.Font("宋体", 10F);
            this.txt_name.Location = new System.Drawing.Point(198, 87);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 23);
            this.txt_name.TabIndex = 5;
            // 
            // lb_major
            // 
            this.lb_major.AutoSize = true;
            this.lb_major.Font = new System.Drawing.Font("宋体", 10F);
            this.lb_major.Location = new System.Drawing.Point(124, 149);
            this.lb_major.Name = "lb_major";
            this.lb_major.Size = new System.Drawing.Size(49, 14);
            this.lb_major.TabIndex = 6;
            this.lb_major.Text = "专业：";
            // 
            // txt_class
            // 
            this.txt_class.Enabled = false;
            this.txt_class.Font = new System.Drawing.Font("宋体", 10F);
            this.txt_class.Location = new System.Drawing.Point(198, 146);
            this.txt_class.Name = "txt_class";
            this.txt_class.Size = new System.Drawing.Size(100, 23);
            this.txt_class.TabIndex = 7;
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Font = new System.Drawing.Font("宋体", 10F);
            this.lb_phone.Location = new System.Drawing.Point(124, 185);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(49, 14);
            this.lb_phone.TabIndex = 8;
            this.lb_phone.Text = "手机：";
            this.lb_phone.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_phone
            // 
            this.txt_phone.Enabled = false;
            this.txt_phone.Font = new System.Drawing.Font("宋体", 10F);
            this.txt_phone.Location = new System.Drawing.Point(198, 183);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(100, 23);
            this.txt_phone.TabIndex = 9;
            // 
            // lb_gender
            // 
            this.lb_gender.AutoSize = true;
            this.lb_gender.Font = new System.Drawing.Font("宋体", 10F);
            this.lb_gender.Location = new System.Drawing.Point(124, 119);
            this.lb_gender.Name = "lb_gender";
            this.lb_gender.Size = new System.Drawing.Size(49, 14);
            this.lb_gender.TabIndex = 10;
            this.lb_gender.Text = "性别：";
            // 
            // txt_gender
            // 
            this.txt_gender.Enabled = false;
            this.txt_gender.Location = new System.Drawing.Point(198, 116);
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.Size = new System.Drawing.Size(100, 21);
            this.txt_gender.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(124, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 12;
            this.label1.Text = "出生年月：";
            // 
            // txt_birth
            // 
            this.txt_birth.Enabled = false;
            this.txt_birth.Location = new System.Drawing.Point(199, 216);
            this.txt_birth.Name = "txt_birth";
            this.txt_birth.Size = new System.Drawing.Size(100, 21);
            this.txt_birth.TabIndex = 13;
            // 
            // Form_Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 317);
            this.Controls.Add(this.txt_birth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_gender);
            this.Controls.Add(this.lb_gender);
            this.Controls.Add(this.txt_phone);
            this.Controls.Add(this.lb_phone);
            this.Controls.Add(this.txt_class);
            this.Controls.Add(this.lb_major);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_account);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.lb_account);
            this.Name = "Form_Account";
            this.Text = "个人信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_account;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox txt_account;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lb_major;
        private System.Windows.Forms.TextBox txt_class;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lb_gender;
        private System.Windows.Forms.TextBox txt_gender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_birth;
    }
}