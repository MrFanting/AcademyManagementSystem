using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AcademyManagementSystem.Object
{
    class Teacher
    {
        private string id;
        private string name;
        private string gender;
        private string age;

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Age { get => age; set => age = value; }
    }
}