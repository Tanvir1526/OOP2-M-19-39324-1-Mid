using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Student
    {
        private string name;
        private string id;
        private float cgpa;
        private Department dept;

        public Student() { }

        public Student (string name , string id, float cgpa)
        {
            this.name = name;
            this.id = id; ;
            this.cgpa = cgpa;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public float Cgpa
        {
            get { return cgpa; }
            set { cgpa = value; }
        }
        public Department Dept
        {
            set { this.dept = value; }
            get{return this.dept;}
        }

        public void showInfo()
        {
            Console.WriteLine("Name : " + this.Name);
            Console.WriteLine("ID : " + this.Id);
            Console.WriteLine("Cgpa : " + this.Cgpa);
        }

        public void ShowDepartment()
        {
            this.showInfo();
            this.Dept.showInfo();
        }


    }
}
