using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{
    class SodaMachine
    {
        Inventory inventory;
        Register register;
        public SodaMachine(int amountOfQuarters, int amountOfDimes, int amountOfNickels, int amountOfPennies)
        {

            inventory = new Inventory();
            register = new Register(amountOfQuarters, amountOfDimes, amountOfNickels, amountOfPennies);

        }
    }
}
