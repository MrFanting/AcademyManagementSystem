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
            //
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

        
    }
}
