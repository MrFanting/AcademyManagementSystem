
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AcademyManagementSystem.Object
{
    class Score
    {
        private string con;
        private string studentName;
        private string mark;

        public string Con { get => con; set => con = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public string Mark { get => mark; set => mark = value; }
    }
}