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
    public partial class TeacherAccount : Form
    {
        public TeacherAccount()
        {
            InitializeComponent();
            AddInfo(NetworkService.GetTeacherPersonalInfo());
        }

        private void AddInfo(Teacher teacher)
        {
            if (teacher != null)
            {
                txt_account.Text = teacher.Id;
                textBox1.Text = teacher.Name;
                textBox2.Text = teacher.Gender;
                textBox3.Text = teacher.Age;
            }
            else
            {
                MessageBox.Show("出错");
            }
            
        }
    }
}
