using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagementSystem.Object
{
    class Course
    {
        private string id;
        private string con;//课程名
        private string credit;
        private string property;
        private string teacherName;

        public string Id { get => id; set => id = value; }
        public string Con { get => con; set => con = value; }
        public string Credit { get => credit; set => credit = value; }
        public string Property { get => property; set => property = value; }
        public string TeacherName { get => teacherName; set => teacherName = value; }
    }
}
