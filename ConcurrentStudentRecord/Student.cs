using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentStudentRecord
{
    class Student
    {
        public int id;
        public string name;
        public int marks;

        public Student(string n,int m, int i)
        {
            name = n;
            marks = m;
            id = i;
        }



        public static List<Student> GetStudentRecord()
        {
            List<Student> l = new List<Student>()
            {
                new Student("kjckaj",45,1),
                 new Student("aaaa",50,2),
                  new Student("bbbb",74,3),
                   new Student("cccc",23,4),
                    new Student("ddddd",78,5)



            };

            return l;


        }







    }
}
