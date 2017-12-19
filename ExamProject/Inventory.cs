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
        public PiggyBank piggyBank;
        public Inventory(int amountOfGrapeSoda, int amountOfOrangeSoda, int amountOfLemonSoda, int amountOfQuarters, int amountOfDimes, int amountOfNickels, int amountOfPennies)
        {
            GrapeSoda grapeSoda = new GrapeSoda();
            OrangeSoda orangeSoda = new OrangeSoda(); ;
            LemonSoda lemonSoda = new LemonSoda();
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
