// Program computes sales commission based on the following:
// Sales up to and including $1,000 -- 5% commission
// Up to and including $5,000 -- 5% on first $1,000 and
//     7% commission on amount over $1,000
// up to and including $10,000 -- same as before plus $1,000 bonus
// over $10,000 - same as all of the above plus
//    additional $1,500 bonus
using System;
using static System.Console;

namespace DebugFour4
{
    class DebugFour4
    {
        static void Main()
        {
            double sales, commission;
            string inputString;
            const int LOWSALES = 1000;
            const int MEDSALES = 5000;
            const int HIGHSALES = 10000;
            const double LOWPCT = 0.05;
            const double MEDPCT = 0.02;
            const int BONUS1 = 1000;
            const int BONUS2 = 1500;
            WriteLine("What was the sales amount? ");
            inputString = ReadLine();
            sales = Convert.ToDouble(inputString);
            //can get rid of the if (sales <= LOWSALES) because commission base result
            commission = LOWPCT * sales;
            //if (sales <= LOWSALES)

            //This is for Up to and including $5,000:
            //commission += (sales - LOWSALES) * MEDPCT;
            // sales needs to be inbetween LOWSALES and MEDSALES
            if (LOWSALES <= sales && sales <= MEDSALES)
                commission += (sales - LOWSALES) * MEDPCT;
            // sales need to be inbetween MEDSALES and HIGHSALES
            else if (MEDSALES <= sales && sales <= HIGHSALES)
                // change to bonus1
                commission += BONUS1;
            // add an else if statement with the addition of +$1500
            else if (sales >= HIGHSALES)
                commission += BONUS2;
            WriteLine("Sales: {0}\nCommission: {1}",
              sales.ToString("C"), commission.ToString("C"));
        }
    }

}
