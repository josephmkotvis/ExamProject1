using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{

    public class Inventory
    {
        public List <int> sodaAmount;
        public List<Soda> sodas;
        GrapeSoda grapeSoda;
        OrangeSoda orangeSoda;
        LemonSoda lemonSoda;
        public PiggyBank piggyBank;
        public Inventory(int amountOfGrapeSoda, int amountOfOrangeSoda, int amountOfLemonSoda, int amountOfQuarters, int amountOfDimes, int amountOfNickels, int amountOfPennies)
        {
            sodaAmount = new List<int>
            {
                {amountOfGrapeSoda },
                {amountOfOrangeSoda },
                {amountOfLemonSoda }
            };
            sodas = new List<Soda>
            {
                { grapeSoda },
                { orangeSoda},
                { lemonSoda}
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
