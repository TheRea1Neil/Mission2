using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Mission_2
{

    internal class DiceRolls
    {
        public List<int> GetRolls(int rolls) 
        {
          //create alist
            List<int> listRolls = new List<int>();
          //add the result of each dice roll to the list
            for (int i = 0; i < rolls; i++)
            {
                
                int roll1 = new Random().Next(1, 7);
                int roll2 = new Random().Next(1, 7);
                int total = roll1 + roll2;
                listRolls.Add(total);
            }
            return listRolls;
        }
    }
}
