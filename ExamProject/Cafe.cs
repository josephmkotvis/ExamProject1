using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace ExamProject
{
    public class Cafe
    {
        Person buyer;
        SodaMachine sodaMachine;
        UserInterface UI;
        public Cafe(Person buyer, SodaMachine sodaMachine)
        {
            this.buyer = buyer;
            this.sodaMachine = sodaMachine;
            UI = new UserInterface(sodaMachine);
        }
        public  void CreateInteraction()
        {
            // Person checkssoda
            UI.DisplaySodaChoices();
            buyer.sodaChoice = UI.GetUserInput();
            //buyer.ChoosesSoda();
            //sodamachine checks if available
            sodaMachine.CheckSodaAvailability(buyer.sodaChoice);
            sodaMachine.InformSodaAvailability();
            //sodamachine checks price
            sodaMachine.InformSodaAvailability();
            if (sodaMachine.cantSell == true)
            {
                CreateInteraction();
            }
            sodaMachine.CheckSodaPrice(buyer.sodaChoice);
            buyer.priceChoice = UI.GetUserInput();
            //person checks if price is okay
            //person check for price in wallet
            buyer.CheckCoins(sodaMachine.currentSodaChoicePrice);
            if (buyer.unableToBuy == true)
            {
                CreateInteraction();
            }
            //person puts in money
            buyer.BuySoda(sodaMachine.currentSodaChoicePrice);
            //sodamachine takes change
            sodaMachine.TakeCoins(buyer.coinsSpent);
            //sodamachine checks change
            //sodaMachine.CheckCoins();
            //sodamachine checks register
            //sodaMachine.CheckRegister();
            //sodaMachine.InformRegisterAvailability();
            //sodamachine sells soda or if unable
            sodaMachine.SellSoda(buyer.sodaChoice);
            //person aqcuires soda
            buyer.TakesSoda();
            UI.DisplaySodaBought(buyer.sodaChoice);
        }
    }
}
