using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Tanvir", "19-39324-1", 3.83f);
            Student s2 = new Student("Ahmed", "19-39492-2", 3.50f);
            Student s3 = new Student("Sohan", "19-39895-3", 3.66f);

            Department d1 = new Department("Computer Scince", "CS");
            Department d2 = new Department("Electrical & Electronic Engineering", "EEE");

            s1.Dept = d1;
            s2.Dept = d2;
            s3.Dept = d2;

            s1.showInfo();
            s1.ShowDepartment();

            s2.showInfo();
            s2.ShowDepartment();

            s3.showInfo();
            s3.ShowDepartment();

            d1.AddStd(s1);
            d2.AddStd(s2);

            d1.PrintStudent();
            d2.PrintStudent();
        }
    }
}
