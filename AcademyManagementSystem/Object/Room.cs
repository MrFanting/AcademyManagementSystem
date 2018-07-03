using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagementSystem.Object
{
    class Room
    {
        private string id;
        private string time;//上午、下午、中午
        private string isIdle;//是否空闲

        public string Id { get => id; set => id = value; }
        public string Time { get => time; set => time = value; }
        public string IsIdle { get => isIdle; set => isIdle = value; }
    }
}
