using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{
    class Inventory
    {
        Dictionary<Soda, int> sodas;
        GrapeSoda grapeSoda;
        OrangeSoda orangeSoda;
        LemonSoda lemonSoda;
        PiggyBank piggyBank;
        public Inventory(int amountOfGrapeSoda, int amountOfOrangeSoda, int amountOfLemonSoda, int amountOfQuarters, int amountOfDimes, int amountOfNickels, int amountOfPennies)
        {
            sodas = new Dictionary<Soda, int>
            {
                { grapeSoda, amountOfGrapeSoda },
                { grapeSoda, amountOfOrangeSoda },
                { grapeSoda, amountOfLemonSoda }
            };
            piggyBank = new PiggyBank(amountOfQuarters, amountOfDimes, amountOfNickels, amountOfPennies);
        }
        void AddGrapeSoda()
        {

        }
        void AddOrangeSoda()
        {

        }
        void AddLemonSoda()
        {

        }
        void RemoveGrapeSoda()
        {

        }
        void RemoveOrangeSoda()
        {

        }
        void RemoveLemonSoda()
        {

        }

    }
}
