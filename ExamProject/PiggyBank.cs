using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{
    class PiggyBank
    {
        Dictionary<Coin, int> coins;
        public PiggyBank()
        {
            coins = new Dictionary<Coin, int>();
        }
    }
}
