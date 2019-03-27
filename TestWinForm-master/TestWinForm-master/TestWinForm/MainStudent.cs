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
    public partial class MainStudent : Form
    {
        public static UserAccount user = null;
        public MainStudent()
        {
            InitializeComponent();
        }

        private void toolStripAccount_Click(object sender, EventArgs e)
        {
            Form_Account form_account = new Form_Account();
            form_account.MdiParent = this;
            form_account.Text = "账号管理";
            form_account.Show();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        private void Info_Click(object sender, EventArgs e)
        {
            Form_Account form_Account = new Form_Account();
            form_Account.MdiParent = this;
            form_Account.Show();
        }

        private void Grade_Click(object sender, EventArgs e)
        {
            Form_Grade form_Grade = new Form_Grade();
            form_Grade.MdiParent = this;
            form_Grade.Show();
        }

        private void pwd_Click(object sender, EventArgs e)
        {
            Form_Pwd form_Pwd = new Form_Pwd();
            form_Pwd.MdiParent = this;
            form_Pwd.Show();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void Plan_Click(object sender, EventArgs e)
        {
            //查询培养计划
            Plan plan = new Plan();
            plan.MdiParent = this;
            plan.Show();
        }

        private void ClassRoom_Click(object sender, EventArgs e)
        {
            //查询空闲
            ClassRoom classRoom = new ClassRoom();
            classRoom.MdiParent = this;
            classRoom.Show();
        }

        private void 选课ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Course_Choose course_Choose = new Course_Choose();
            course_Choose.MdiParent = this;
            course_Choose.Show();
        }
    }
}
