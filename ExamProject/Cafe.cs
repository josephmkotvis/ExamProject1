using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{
    class Cafe
    {
        Person buyer;
        SodaMachine sodaMachine;
        public Cafe(Person buyer, SodaMachine sodaMachine)
        {
            this.buyer = buyer;
            this.sodaMachine = sodaMachine;
        }
    }
}
