namespace TestWinForm.UI
{
    partial class Form_Courses
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_college = new System.Windows.Forms.Label();
            this.com_college = new System.Windows.Forms.ComboBox();
            this.lb_number = new System.Windows.Forms.Label();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lb_teacher = new System.Windows.Forms.Label();
            this.txt_teacher = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_weekday = new System.Windows.Forms.Label();
            this.com_weekday = new System.Windows.Forms.ComboBox();
            this.lb_time = new System.Windows.Forms.Label();
            this.com_time = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.com_time);
            this.groupBox1.Controls.Add(this.lb_time);
            this.groupBox1.Controls.Add(this.com_weekday);
            this.groupBox1.Controls.Add(this.lb_weekday);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.txt_teacher);
            this.groupBox1.Controls.Add(this.lb_teacher);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.lb_name);
            this.groupBox1.Controls.Add(this.txt_number);
            this.groupBox1.Controls.Add(this.lb_number);
            this.groupBox1.Controls.Add(this.com_college);
            this.groupBox1.Controls.Add(this.lb_college);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(791, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // lb_college
            // 
            this.lb_college.AutoSize = true;
            this.lb_college.Location = new System.Drawing.Point(18, 21);
            this.lb_college.Name = "lb_college";
            this.lb_college.Size = new System.Drawing.Size(53, 12);
            this.lb_college.TabIndex = 0;
            this.lb_college.Text = "开课院系";
            // 
            // com_college
            // 
            this.com_college.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_college.FormattingEnabled = true;
            this.com_college.Items.AddRange(new object[] {
            "工商管理学院",
            "化工学院",
            "理学院",
            "外国语学院",
            "石油工程学院"});
            this.com_college.Location = new System.Drawing.Point(77, 18);
            this.com_college.Name = "com_college";
            this.com_college.Size = new System.Drawing.Size(102, 20);
            this.com_college.TabIndex = 1;
            // 
            // lb_number
            // 
            this.lb_number.AutoSize = true;
            this.lb_number.Location = new System.Drawing.Point(227, 21);
            this.lb_number.Name = "lb_number";
            this.lb_number.Size = new System.Drawing.Size(41, 12);
            this.lb_number.TabIndex = 2;
            this.lb_number.Text = "课程号";
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(275, 18);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(100, 21);
            this.txt_number.TabIndex = 3;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(400, 21);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(41, 12);
            this.lb_name.TabIndex = 4;
            this.lb_name.Text = "课程名";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(448, 17);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 21);
            this.txt_name.TabIndex = 5;
            // 
            // lb_teacher
            // 
            this.lb_teacher.AutoSize = true;
            this.lb_teacher.Location = new System.Drawing.Point(570, 21);
            this.lb_teacher.Name = "lb_teacher";
            this.lb_teacher.Size = new System.Drawing.Size(53, 12);
            this.lb_teacher.TabIndex = 6;
            this.lb_teacher.Text = "开课教师";
            // 
            // txt_teacher
            // 
            this.txt_teacher.Location = new System.Drawing.Point(630, 17);
            this.txt_teacher.Name = "txt_teacher";
            this.txt_teacher.Size = new System.Drawing.Size(100, 21);
            this.txt_teacher.TabIndex = 7;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(505, 49);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 8;
            this.btn_search.Text = "查询";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(655, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "清空条件";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lb_weekday
            // 
            this.lb_weekday.AutoSize = true;
            this.lb_weekday.Location = new System.Drawing.Point(20, 61);
            this.lb_weekday.Name = "lb_weekday";
            this.lb_weekday.Size = new System.Drawing.Size(53, 12);
            this.lb_weekday.TabIndex = 10;
            this.lb_weekday.Text = "开课星期";
            // 
            // com_weekday
            // 
            this.com_weekday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_weekday.FormattingEnabled = true;
            this.com_weekday.Items.AddRange(new object[] {
            "星期一",
            "星期二",
            "星期三",
            "星期四",
            "星期五"});
            this.com_weekday.Location = new System.Drawing.Point(77, 53);
            this.com_weekday.Name = "com_weekday";
            this.com_weekday.Size = new System.Drawing.Size(102, 20);
            this.com_weekday.TabIndex = 11;
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Location = new System.Drawing.Point(229, 60);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(53, 12);
            this.lb_time.TabIndex = 12;
            this.lb_time.Text = "开课节次";
            // 
            // com_time
            // 
            this.com_time.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_time.FormattingEnabled = true;
            this.com_time.Items.AddRange(new object[] {
            "一二节",
            "三四节",
            "五六节",
            "七八节"});
            this.com_time.Location = new System.Drawing.Point(289, 52);
            this.com_time.Name = "com_time";
            this.com_time.Size = new System.Drawing.Size(121, 20);
            this.com_time.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(12, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(791, 301);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "序号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "课程号";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "课程名";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "开课院系";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "开课教师";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "查看";
            this.Column6.Name = "Column6";
            // 
            // Form_Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 428);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Courses";
            this.Text = "Form_Courses";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox com_time;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.ComboBox com_weekday;
        private System.Windows.Forms.Label lb_weekday;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_teacher;
        private System.Windows.Forms.Label lb_teacher;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.Label lb_number;
        private System.Windows.Forms.ComboBox com_college;
        private System.Windows.Forms.Label lb_college;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}