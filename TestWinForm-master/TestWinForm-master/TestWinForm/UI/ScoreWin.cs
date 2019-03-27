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
    public partial class ScoreWin : Form
    {
        private IList<Score> scores = null;
        private int flag;
        public ScoreWin()
        {
            flag = 0;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            course.Id = textBox1.Text.ToString().Trim();
            scores = NetworkService.GetTeacherCourseGrades(course);
            if (scores != null)
            {
                AddInfo(scores[flag]);
            }
            else
            {
                MessageBox.Show("没有这门课");
            }
            
        }

        private void AddInfo(Score score)
        {
            textBox2.Text = score.Con;
            textBox3.Text = score.StudentId;
            textBox4.Text = score.Mark;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            scores[flag].Mark = textBox4.Text.ToString().Trim();
            if (flag > 0)
            {
                flag -= 1;
                AddInfo(scores[flag]);
            }
            else
            {
                MessageBox.Show("已经是第一个");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            scores[flag].Mark = textBox4.Text.ToString().Trim();
            if (flag <(scores.Count-1))
            {
                flag += 1;
                AddInfo(scores[flag]);
            }
            else
            {
                MessageBox.Show("已经是最后一个");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            scores[flag].Mark = textBox4.Text.ToString().Trim();
            if (NetworkService.GetTeacherCourseGrades(scores))
            {
                MessageBox.Show("更改成功");
            }
            else
            {
                MessageBox.Show("更改失败");
            }
        }

    }
}
