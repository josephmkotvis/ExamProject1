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
        public SodaMachine(int amountOfGrapeSoda, int amountOfOrangeSoda, int amountOfLemonSoda, int amountOfQuarters, int amountOfDimes, int amountOfNickels, int amountOfPennies)
        {

            inventory = new Inventory(amountOfGrapeSoda, amountOfOrangeSoda, amountOfLemonSoda, amountOfQuarters, amountOfDimes, amountOfNickels, amountOfPennies);

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
