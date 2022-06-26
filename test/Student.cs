using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Student
    {
        //public static Student Instance = new Student();

        private static Student instance;
        static object key = new object();
        public static Student Instance
        {
            get
            {
                if(instance == null)
                {
                    lock (key)
                    {
                        instance = new Student();   
                    }
                }
                return instance;    
            }
        }

        private Student()
        {

        }
        public void Demo()
        {
            Console.WriteLine("hello");
        }
    }
}
