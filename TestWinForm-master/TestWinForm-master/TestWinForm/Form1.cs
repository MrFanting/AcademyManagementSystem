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

namespace TestWinForm
{
    public partial class Form1 : Form
    {
        public static string Type { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string name = this.txt_id.Text.ToString().Trim();
            string pwd = this.txt_pwd.Text.ToString().Trim();
            if (name != "" && pwd != "")
            {
                
                //等待修改
                if (comboBox1.Text.ToString().Trim()=="student")
                {
                    MainStudent.user = new UserAccount(name, pwd, comboBox1.Text.ToString().Trim());
                    if (NetworkService.Login(MainStudent.user))
                    {
                        Type = "student";
                        MainStudent main = new MainStudent();
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("账号或密码错误");
                    }
                    
                }
                else
                {
                    MainTeacher.user = new UserAccount(name, pwd, comboBox1.Text.ToString().Trim());
                    if (NetworkService.Login(MainTeacher.user))
                    {
                        Type = "teacher";
                        MainTeacher main = new MainTeacher();
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("账号或密码错误");
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("请输入账号或密码");
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_id.Text = "";
            txt_pwd.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //skinEngine1.SkinFile = Application.StartupPath + @"\Skins\CalmnessColor2.ssk";
            comboBox1.SelectedIndex = 0;
        }
    }
}
