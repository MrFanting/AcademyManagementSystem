
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AcademyManagementSystem.Object
{
    class Score
    {

        //显示使用
        public string Con { get; set; }
        public string StudentName { get; set; }
        public string Mark { get; set; }

        //查询使用
        public string CourseId { get; set; }
        public string StudentId { get; set; }
    }
}