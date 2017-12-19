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
        public Person(int amountOfGrapeSoda, int amountOfOrangeSoda, int amountOfLemonSoda, int amountOfQuarters, int amountOfDimes, int amountOfNickels, int amountOfPennies)
        {
            inventory = new Inventory(amountOfGrapeSoda,amountOfOrangeSoda,amountOfLemonSoda, amountOfQuarters, amountOfDimes, amountOfNickels, amountOfPennies);

        }

        public void ChoosesSoda()
        {
            //Chooses what soda to purchase
        }
        public void BuySoda()
        {
            //Buys a soda from sodamachine.
        }
        public void CheckCoins()
        {
            // checks to see if there are enough coins
        }
        public void TakesSoda()
        {
            //takes soda from sodamachine
        }
        public void CheckPriceOpinion()
        {

        }
    }
}
