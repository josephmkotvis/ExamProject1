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
        void CreateInteraction()
        {
            // Person checkssoda
            buyer.ChoosesSoda();
            //sodamachine checks if available
            sodaMachine.CheckSodaAvailability();
            sodaMachine.InformSodaAvailability();
            //sodamachine checks price
            sodaMachine.CheckSodaPrice();
            sodaMachine.InformSodaAvailability();
            //person checks if price is okay
            buyer.CheckPriceOpinion();
            //person check for price in wallet
            buyer.CheckCoins();
            //person puts in money
            buyer.BuySoda();
            //sodamachine takes change
            sodaMachine.TakeCoins();
            //sodamachine checks change
            sodaMachine.CheckCoins();
            //sodamachine checks register
            sodaMachine.CheckRegister();
            sodaMachine.InformRegisterAvailability();
            //sodamachine sells soda or if unable
            sodaMachine.SellSoda();
            //person aqcuires soda
            buyer.TakesSoda();
        }
    }
}
