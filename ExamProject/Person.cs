using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{
    class Person
    {
        Inventory inventory;
        PiggyBank piggyBank;
        public Person(int amountOfQuarters, int amountOfDimes, int amountOfNickels, int amountOfPennies)
        {
            inventory = new Inventory();
            piggyBank = new PiggyBank(amountOfQuarters, amountOfDimes, amountOfNickels, amountOfPennies);
        }
        void Buy()
        {
            //Buys a soda from sodamachine.
            //Then goes to sodamachine to check if theres enough 
        }
    }
}
