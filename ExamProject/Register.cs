using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{
    class Register
    {
        Dictionary<Coin, int> coins;
        Quarter quarter;
        Dime dime;
        Nickel nickel;
        Penny penny;
        public Register(int amountOfQuarters, int amountOfDimes, int amountOfNickels, int amountOfPennies)
        {
            coins = new Dictionary<Coin, int>
            {
                { quarter, amountOfQuarters },
                { dime, amountOfDimes },
                { nickel, amountOfNickels },
                { penny, amountOfPennies }
            };
        }
    }
}
