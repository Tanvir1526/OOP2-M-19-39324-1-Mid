using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
      
             static void Main(string[] args)
        {
            student obj1 = new student("Tanvir Ahmed", 39324, "FST", 3.84);
            
            obj1.showInfo();
            
            Account obj3 = new Account("Tanvir Ahmed", "39324", 10000);
            obj3.Deposit(5000);
            Course obj4 = new Course("OOP 2", "CSC3203", 3);
            obj4.ShowCourseInfo();
            Triangle obj5 = new Triangle(5,5,6);
            obj5.TestTriangle();
        }
      }
  }

