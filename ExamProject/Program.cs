﻿using System;
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
            SodaMachine sodaMachine = new SodaMachine(5,8,10,20, 10, 20, 50);
            Person buyer = new Person(0,0,0,30, 30, 30, 30);
            Cafe ward4 = new Cafe(buyer, sodaMachine);
        }
    }
}
