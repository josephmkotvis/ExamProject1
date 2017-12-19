using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{
    public class PiggyBank
    {
        public List<Coin> coins;
        public List<int> amountOfCoins;
    
        public double totalAmountOfMoney;
        public PiggyBank(int amountOfQuarters, int amountOfDimes, int amountOfNickels, int amountOfPennies)
        {
            Quarter quarter = new Quarter();
            Dime dime = new Dime();
            Nickel nickel = new Nickel();
            Penny penny = new Penny();
            coins = new List<Coin>
            {
                { quarter},
                { dime},
                { nickel},
                { penny}
            };
            amountOfCoins = new List<int>
            {
                { amountOfQuarters},
                { amountOfDimes},
                { amountOfNickels},
                { amountOfPennies}
            };
            totalAmountOfMoney = (quarter.value * amountOfQuarters) + (dime.value * amountOfDimes) + (nickel.value * amountOfNickels) + (penny.value * amountOfPennies);
        }
        void AddQuarters()
        {

        }
        void AddDimes()
        {

        }
        void AddNickels()
        {

        }
        void AddPennies()
        {

        }
        void RemoveQuarters()
        {

        }
        void RemoveDimes()
        {

        }
        void RemoveNickels()
        {

        }
        void RemovePennies()
        {

        }
    }
}
