using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Department
    {
        private string name;
        private string id;

        private int stdcount;
        private Student[] stud;

        public Department()
        {
            stud = new Student[50];
        }

        public Department(string name, string id)
        {
            this.name = name;
            this.id = id;
            stud = new Student[50];
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

        public int StdCount
        {
            get { return stdcount; }
            set { stdcount = value; }
        }

        public void AddStd(params Student[] stds)
        {
            foreach ( Student s in stds)
            {
                this.stud[this.StdCount++] = s;
                s.Dept = this;
            }
        }

        public void PrintStudent()
        {
            foreach(Student s in this.stud)
            {
                s.showInfo();
            }
        }

        public void showInfo()
        {
            Console.WriteLine("Department Name : " + this.Name);
            Console.WriteLine("Department Id : " + this.Id);
        }
    }
}