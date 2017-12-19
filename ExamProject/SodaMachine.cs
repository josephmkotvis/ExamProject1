using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{
    class SodaMachine
    {
        Dictionary<Coin, int> coins;
        Quarter quarter;
        Dime dime;
        Nickel nickel;
        Penny penny;
        Inventory inventory;
        public SodaMachine(int amountOfQuarters, int amountOfDimes, int amountOfNickels, int amountOfPennies)
        {
            coins = new Dictionary<Coin, int>();
            coins.Add(quarter, amountOfQuarters);
            coins.Add(dime, amountOfDimes);
            coins.Add(nickel, amountOfNickels);
            coins.Add(penny, amountOfPennies);
            inventory = new Inventory();

        }
    }
}
