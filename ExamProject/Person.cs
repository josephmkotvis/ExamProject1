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
            inventory = new Inventory(0,0,0);
            piggyBank = new PiggyBank(amountOfQuarters, amountOfDimes, amountOfNickels, amountOfPennies);
        }

        void ChoosesSoda()
        {
            //Chooses what soda to purchase
        }
        void Buy()
        {
            //Buys a soda from sodamachine.
        }
        void CheckCoins()
        {
            // checks to see if there are enough coins
        }
        void TakesSoda()
        {
            //takes soda from sodamachine
        }

    }
}
