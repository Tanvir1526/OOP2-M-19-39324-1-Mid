using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Course
    {
        
        private String courseName;
        private String courseCode;
        private int courseCredit;

        public Course(String cn, String cc, int ccrt)
        {
            courseName = cn;
            courseCode = cc;
            courseCredit = ccrt;
        }
        public void ShowCourseInfo()
        {
            Console.WriteLine("Course Name = " + courseName);
            Console.WriteLine("Course Code = " + courseCode);
            Console.WriteLine("Course Credit = " + courseCredit);
        }
    }
  }

