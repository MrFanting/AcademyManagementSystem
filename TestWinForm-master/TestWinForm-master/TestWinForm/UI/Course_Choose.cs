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
using System.Text.RegularExpressions;

namespace TestWinForm.UI
{
    public partial class Course_Choose : Form
    {
        IList<Course> coursesList = new List<Course>();
        IList<Course> coursesListQuery = new List<Course>();

        public Course_Choose()
        {
            InitializeComponent();
        }

        
        
        private void Course_Choose_Load(object sender, EventArgs e)
        {
            coursesList = NetworkService.GetCoursesToChoose();
            dataGridView1.DataSource = coursesList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            Regex reg = new Regex(".*");            
            course.Id = id.Text.ToString().Trim();
            course.Con = course_name.Text.ToString().Trim();
            course.TeacherName = teacher.Text.ToString().Trim();
            int flag = 0;
            foreach (Course cour in coursesList)
            {
                if (!course.Id.Equals(""))
                {
                    if (course.Id.Equals(cour.Id))
                        flag++;
                }
                else { flag++; }
                if (!course.Con.Equals(""))
                {
                    if (course.Con.Equals(cour.Id)) 
                        flag++;
                }
                else { flag++; }
                if (!course.TeacherName.Equals(""))
                {
                    if (course.TeacherName.Equals(cour.Id)) 
                        flag++;
                }
                else
                {
                    flag++;
                }
                if (flag == 3)
                {
                    coursesListQuery.Add(cour);
                }
                flag = 0;
                dataGridView1.DataSource = coursesListQuery;
            }
            //course = NetworkService.GetCourseInfo(course);
            
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
            Score score = new Score();
            string course_id = id.Text.ToString().Trim();
            if (course_id != "")
            {
                score.CourseId = course_id;
                NetworkService.InsertStudentCourse(score);
            }
        }

    }
}
