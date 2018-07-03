using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyManagementSystem.Object
{
    class Student
    {
        private string id;
        private string name;
        private string birth;
        private string major;
        private string number;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Birth { get => birth; set => birth = value; }
        public string Major { get => major; set => major = value; }
        public string Number { get => number; set => number = value; }
    }
}
