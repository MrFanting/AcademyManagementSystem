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
    public partial class Form_Account : Form
    {
        public Form_Account()
        {
            //得到main下user,查询学生信息

            InitializeComponent();
            Student student = NetworkService.GetStudentPersonalInfo();
            addInfo(student);
        }

        private void addInfo(Student student)
        {
            txt_account.Text = student.Id;
            txt_birth.Text = student.Birth;
            txt_class.Text = student.Major;
            txt_gender.Text = student.Gender;
            txt_name.Text = student.Name;
            txt_phone.Text = student.Number;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
