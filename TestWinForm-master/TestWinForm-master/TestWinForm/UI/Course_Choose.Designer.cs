namespace TestWinForm.UI
{
    partial class Course_Choose
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
            this.label = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.course_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.credit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.teacher = new System.Windows.Forms.TextBox();
            this.select = new System.Windows.Forms.Button();
            this.choose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.course_time = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 37);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(65, 12);
            this.label.TabIndex = 1;
            this.label.Text = "  课程号  ";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(95, 34);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 21);
            this.id.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "  课程名  ";
            // 
            // course_name
            // 
            this.course_name.Enabled = false;
            this.course_name.Location = new System.Drawing.Point(94, 77);
            this.course_name.Name = "course_name";
            this.course_name.Size = new System.Drawing.Size(100, 21);
            this.course_name.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "   学分   ";
            // 
            // credit
            // 
            this.credit.Enabled = false;
            this.credit.Location = new System.Drawing.Point(94, 127);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(100, 21);
            this.credit.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = " 上课时间   ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "   教师   ";
            // 
            // teacher
            // 
            this.teacher.Enabled = false;
            this.teacher.Location = new System.Drawing.Point(94, 220);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(100, 21);
            this.teacher.TabIndex = 11;
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(14, 276);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(75, 23);
            this.select.TabIndex = 13;
            this.select.Text = "条件查询";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.button2_Click);
            // 
            // choose
            // 
            this.choose.Location = new System.Drawing.Point(119, 276);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(75, 23);
            this.choose.TabIndex = 14;
            this.choose.Text = "选课";
            this.choose.UseVisualStyleBackColor = true;
            this.choose.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(200, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(382, 302);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "培养方案内课程";
            // 
            // course_time
            // 
            this.course_time.Enabled = false;
            this.course_time.Location = new System.Drawing.Point(94, 174);
            this.course_time.Name = "course_time";
            this.course_time.Size = new System.Drawing.Size(100, 21);
            this.course_time.TabIndex = 17;
            // 
            // Course_Choose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 386);
            this.Controls.Add(this.course_time);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.choose);
            this.Controls.Add(this.select);
            this.Controls.Add(this.teacher);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.course_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label);
            this.Name = "Course_Choose";
            this.Text = "选课";
            this.Load += new System.EventHandler(this.Course_Choose_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox course_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox credit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teacher;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button choose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox course_time;
    }
}