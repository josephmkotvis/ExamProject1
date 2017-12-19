using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{
    class Program
    {
        static void Main(string[] args)
        {
            SodaMachine sodaMachine = new SodaMachine(20, 10, 20, 50);
            Person buyer = new Person(30,30,30,30, sodaMachine);

        }
    }
}
