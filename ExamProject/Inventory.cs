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
        public Inventory(int amountOfGrapeSoda, int amountOfOrangeSoda, int amountOfLemonSoda)
        {
            sodas = new Dictionary<Soda, int>
            {
                { grapeSoda, amountOfGrapeSoda },
                { grapeSoda, amountOfOrangeSoda },
                { grapeSoda, amountOfLemonSoda }
            };
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
