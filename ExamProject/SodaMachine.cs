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

            inventory = new Inventory(5,3,10);
            register = new Register(amountOfQuarters, amountOfDimes, amountOfNickels, amountOfPennies);

        }
        void CheckCoins()
        {

        }
        void CheckCoinValues()
        {

        }
        void SellSoda()
        {

        }
        void RemoveCoins()
        {

        }
        void AddCoints()
        {

        }
    }
}
