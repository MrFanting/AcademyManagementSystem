using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestWinForm.Object;

namespace TestWinForm.UI
{
    public partial class Course_Choose : Form
    {
        public Course_Choose()
        {
            InitializeComponent();
        }

        private void AddInfo(Course course)
        {
            if (course != null)
            {
                id.Text = course.Id;
                course_time.Text = course.CourseTime;
                course_name.Text = course.Con;
                credit.Text = course.Credit;
                teacher.Text = course.TeacherName;
            }
            else
            {
                MessageBox.Show("没有这门课");
            }
            
        }

        private void Course_Choose_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = NetworkService.GetCoursesToChoose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            course.Id = id.Text.ToString().Trim();
            course = NetworkService.GetCourseInfo(course);
            AddInfo(course);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id.Text = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            course_name.Text = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            credit.Text = this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
            course_time.Text = this.dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
            teacher.Text = this.dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString().Trim();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string course_id = id.Text.ToString().Trim();
            if (course_id != "")
            {
                //NetworkService.InsertCourseStudent(course_id);
            }
        }

    }
}
