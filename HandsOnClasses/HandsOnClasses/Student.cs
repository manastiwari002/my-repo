using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClasses
{
    class Student
    {
        public int studentId;
        public string studentName;
        public int age;
        public static string schoolName;
        public static string className;
    }
    class Test_Student
    {
        static void Main()
        {
            Student.schoolName = "DPS";
            Student.className = "IT";
            Student s1 = new Student();
            s1.studentId = 2345;
            s1.age = 10;
            s1.studentName = "Rohan";
            Console.WriteLine("{0} {1} {2} {3} {4} ",s1.studentId,s1.studentName,s1.age,Student.className,Student.schoolName);

            Student s2 = new Student();
            s2.studentId = 2345;
            s2.age = 10;
            s2.studentName = "Manas";
            Console.WriteLine("{0} {1} {2} {3} {4} ", s2.studentId, s2.studentName, s2.age, Student.className, Student.schoolName);

            Student.schoolName = "CPS";
            Student.className = "III";
            Student s3 = new Student();
            s3.studentId = 2345;
            s3.age = 10;
            s3.studentName = "Tim";
            Console.WriteLine("{0} {1} {2} {3} {4} ", s3.studentId, s3.studentName, s3.age, Student.className, Student.schoolName);

            Student s4 = new Student();
            s4.studentId = 2345;
            s4.age = 10;
            s4.studentName = "Jim";
            Console.WriteLine("{0} {1} {2} {3} {4} ", s4.studentId, s4.studentName, s4.age, Student.className, Student.schoolName);
        }
    }
}
