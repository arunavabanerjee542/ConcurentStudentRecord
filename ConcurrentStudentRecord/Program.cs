using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcurrentStudentRecord
{
    class Program
    {
        // To teacher trying to input the student record in a
        // same dictionary.

        static ConcurrentDictionary<int,Student> cd = new ConcurrentDictionary<int,Student>();
        static void Main(string[] args)
        {

            List<Task> tk = new List<Task>();


            tk.Add(Task.Factory.StartNew(() => Teacher1()));

           tk.Add( Task.Factory.StartNew(() => Teacher2()));

            Task.WaitAll(tk.ToArray());

           

            foreach (var x in cd)
            {
                Console.WriteLine(x.Key +" " + x.Value.name);
            }



        }


        public static void Teacher1()
        {
            foreach(var x in Student.GetStudentRecord() )
            {
                 cd.TryAdd(x.id, x);
                
            }


        }

        public static void Teacher2()
        {
            foreach (var x in Student.GetStudentRecord())
            {
                   cd.TryAdd(x.id, x);
               
            }

        }





    }
}
