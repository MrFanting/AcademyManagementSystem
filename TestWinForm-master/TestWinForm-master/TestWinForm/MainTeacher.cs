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
using TestWinForm.UI;

namespace TestWinForm
{
    public partial class MainTeacher : Form
    {
        public static UserAccount user = null;

        public MainTeacher()
        {
            InitializeComponent();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherAccount teacherAccount = new TeacherAccount();
            teacherAccount.MdiParent = this;
            teacherAccount.Show();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Pwd form_Pwd = new Form_Pwd();
            form_Pwd.MdiParent = this;
            form_Pwd.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void 成绩管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScoreWin scoreWin = new ScoreWin();
            scoreWin.MdiParent = this;
            scoreWin.Show();
        }

        private void 课程查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeacherCourse teacherCourse = new TeacherCourse();
            teacherCourse.MdiParent = this;
            teacherCourse.Show();
        }
    }
}
