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
    public partial class Form_Grade : Form
    {
        public Form_Grade()
        {
            InitializeComponent();
            IList<Score> scores= NetworkService.GetAllStudentGrades();
            dataGridView1.DataSource = scores;
        }
    }
}
