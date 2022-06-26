using System;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // writer singleton without lock

            //Student.Instance.Demo();

            // write singleton with lock
            Student.Instance.Demo();

        }
    }
}
