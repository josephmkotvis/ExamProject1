using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{
    public class Person
    {
        Inventory inventory;
        public string sodaChoice;
        public bool unableToBuy;
        double amountSpent;
        public List<int> coinsSpent;
        public string priceChoice;
        public Person(int amountOfGrapeSoda, int amountOfOrangeSoda, int amountOfLemonSoda, int amountOfQuarters, int amountOfDimes, int amountOfNickels, int amountOfPennies)
        {
            inventory = new Inventory(amountOfGrapeSoda,amountOfOrangeSoda,amountOfLemonSoda, amountOfQuarters, amountOfDimes, amountOfNickels, amountOfPennies);
            coinsSpent = new List<int>
            {
                0,
                0,
                0,
                0
            };
        }

        //public void ChoosesSoda()
        //{
        //   if (choice == "1")
        //    {

        //    }

        //}
        public void BuySoda(double currentSodaPrice)
        {
            //Buys a soda from sodamachine.
            for (int i = 0; i < inventory.piggyBank.coins.Count; i++)
            {
                while ((currentSodaPrice > amountSpent) && (amountSpent < inventory.piggyBank.totalAmountOfMoney))
                {
                    inventory.piggyBank.totalAmountOfMoney -= inventory.piggyBank.coins[i].value;
                    inventory.piggyBank.amountOfCoins[i] -= 1;
                    coinsSpent[i] += 1;
                    amountSpent += inventory.piggyBank.coins[i].value;
                }
            }

        }
        public void CheckCoins(double currentSodaPrice)
        {
            if (inventory.piggyBank.totalAmountOfMoney < currentSodaPrice)
            {
                unableToBuy = true;
            }
        }
        public void TakesSoda()
        {
            inventory.sodaAmount[Convert.ToInt32(sodaChoice)] -= 1;
        }
        public void CheckPriceOpinion()
        {

        }
    }
}
