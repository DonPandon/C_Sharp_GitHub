using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This program is meant to calculate shipping costs to 4 different zones depending on an input price given by the user.
//2 zones are high risk, so, additional to the % fee, they charge a safety fee of 25 coins.
//Zone 1: 25%
//Zone 2: 12%, high risk
//zone 3: 8%
//zone 4: 4%, high risk

//the program must keep going until the user types "exit"

namespace ShippingCosts
{
    public delegate double ShippingCosts(ref double arg1);


    class Program
    {

        static void Main(string[] args)
        {

        }
    }
}
