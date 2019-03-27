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
    public partial class ClassRoom : Form
    {
        public ClassRoom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IList<Room> rooms = NetworkService.GetRoomIdle();
            IList<Room> roomsQuery = new List<Room>();
            string weekday = GetWeekName();
            foreach(Room room in rooms)
            {
                if (room.IdleTime.Equals(weekday))
                {
                    roomsQuery.Add(room);
                }
            }
            this.dataGridView1.DataSource = roomsQuery;

            //
        }

        /// <summary>
        /// 获取当前星期几
        /// </summary>
        /// <returns></returns>
        private static string GetWeekName()
        {
            string weekName = "";
            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    weekName = "周一";
                    break;
                case DayOfWeek.Tuesday:
                    weekName = "周二";
                    break;
                case DayOfWeek.Wednesday:
                    weekName = "周三";
                    break;
                case DayOfWeek.Thursday:
                    weekName = "周四";
                    break;
                case DayOfWeek.Friday:
                    weekName = "周五";
                    break;
                case DayOfWeek.Saturday:
                    weekName = "周六";
                    break;
                case DayOfWeek.Sunday:
                    weekName = "周日";
                    break;
            }
            return weekName;
        }
        private void AddInfo(Room room)
        {
            if (room != null)
            {
            }
            else
            {
                MessageBox.Show("没有这间教室");
            }
            
        }

        private void ClassRoom_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = NetworkService.GetRoomIdle();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.textBox1.Text = this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            this.textBox2.Text = this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString().Trim();
            this.textBox3.Text = this.dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString().Trim();
            this.textBox4.Text = this.dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();

        }
    }
}
