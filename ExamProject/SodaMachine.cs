using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{
    public class SodaMachine
    {
        public Inventory inventory;
        UserInterface UI;
        public bool cantSell;
        public double currentSodaChoicePrice;
       
        public SodaMachine(int amountOfGrapeSoda, int amountOfOrangeSoda, int amountOfLemonSoda, int amountOfQuarters, int amountOfDimes, int amountOfNickels, int amountOfPennies)
        {

            inventory = new Inventory(amountOfGrapeSoda, amountOfOrangeSoda, amountOfLemonSoda, amountOfQuarters, amountOfDimes, amountOfNickels, amountOfPennies);

        }
        public void CheckSodaAvailability(string buyerResponse)
        {
            if (inventory.sodaAmount[Convert.ToInt32(buyerResponse)] == 0)
            {
                cantSell = true;
                UI.DisplayNoSodaAvailable(buyerResponse);
            }
            else
            {
                UI.DisplaySodaAvailable(buyerResponse);
            }
        }
        public void CheckSodaPrice(string buyerResponse)
        {
            UI.DisplaySodaPrice(inventory.sodaAmount[Convert.ToInt32(buyerResponse)]);
        }
        public void AskForOpinion()
        {

        }
        public void InformSodaAvailability()
        {

        }
        public void InformSodaPrice()
        {

        }
        public void CheckCoins()
        {

        }
        public void CheckRegister()
        {

        }
        public void InformRegisterAvailability()
        {

        }

        public void SellSoda(string sodaChoice)
        {
            inventory.sodaAmount[Convert.ToInt32(sodaChoice)] -= 1;
        }
        public void TakeCoins(List<int> buyercoinsSpent)
        {
            for (int i = 0; i<inventory.piggyBank.amountOfCoins.Count; i++)
            {
                inventory.piggyBank.amountOfCoins[i] += buyercoinsSpent[i];
            }
        }
        //void RemoveCoins()
        //{

        //}
        //void AddCoins()
        //{

        //}
    }
}
