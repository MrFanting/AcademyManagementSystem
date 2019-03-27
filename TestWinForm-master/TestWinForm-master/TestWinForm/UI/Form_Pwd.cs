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
    
    public partial class Form_Pwd : Form
    {
        public static string Type { get; set; }
        public Form_Pwd()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (txt新密码.Text.ToString().Trim() == txt新密码确认.Text.ToString().Trim())
            {
                if (Form1.Type == "student")
                {
                    UserAccount user = new UserAccount(MainStudent.user.Account, txt新密码.Text.ToString().Trim(),"");
                    if (NetworkService.UpdatePassword(user))
                        MessageBox.Show("更改成功");
                    else
                        MessageBox.Show("更改错误");
                }
                else
                {
                    UserAccount user = new UserAccount(MainTeacher.user.Account, txt新密码.Text.ToString().Trim(), "");
                    if (NetworkService.UpdatePassword(user))
                        MessageBox.Show("更改成功");
                    else
                        MessageBox.Show("更改错误");
                }
            }
            else
            {
                MessageBox.Show("密码输入不一致");
            }
        }
    }
}
