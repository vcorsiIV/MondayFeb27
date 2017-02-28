using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Program takes a hot dog order
// And determines price
using System;
using static System.Console;

//Add namespace
namespace DebugFour1
{
    class DebugFour1
    {
        static void Main()
        {
            const double BASIC_DOG_PRICE = 2.00;
            const double CHILI_PRICE = 0.69;
            const double CHEESE_PRICE = 0.49;
            String wantChili, wantCheese;
            double price;
            Write("Do you want chili on your dog? ");
            wantChili = ReadLine();
            Write("Do you want cheese on your dog? ");
            wantCheese = ReadLine();
            //String requires ==
            if (wantChili == "Y")
                if (wantCheese == "Y")
                    //change == to =
                    price = BASIC_DOG_PRICE + CHILI_PRICE + CHEESE_PRICE;
                else
                    //Changed == to =
                    price = BASIC_DOG_PRICE + CHILI_PRICE;
            else
               //String requires ==
               if (wantCheese == "Y")
                //Add the price of the cheese
                price = BASIC_DOG_PRICE + CHEESE_PRICE;
            else
                //Changed == to =
                price = BASIC_DOG_PRICE;
            WriteLine("Your total is {0}", price.ToString("C"));
        }
    }
}