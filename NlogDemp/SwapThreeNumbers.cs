using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace NlogDemp
{
    /// <summary>
    /// Swap three numbers program using nlog
    /// </summary>
    public class SwapThreeNumbers
    {
        //Method to swap three numbers
        public static void SwapNumbers(int i, int j, int k)
        {
            if( i == 0 || j == 0 || k == 0 )
            {
                NLog.DebugInfo("Debug Unsucessfull due to wrong input");
                NLog.ErrorInfo("Providing wrong inputs");
                NLog.WarnInfo("Inputs Shouldnt be null");
            }
            else
            {
                NLog.InfoLevel("Before numbers swapped : " + i + " " + j + " " + k);
                i = i + j + k; // (i = 60)
                j = i - (j + k); // (j = 60 – (20+30) =10)
                k = i - (j + k); // (k = 60 – (10 + 30) = 20)
                i -= (j + k); // (i = = 60 – (10 + 20) = 30)
                Console.WriteLine("After Swaping : " + i + " " + j + " " + k);
                NLog.DebugInfo("Debug sucessfull");
                NLog.SuccessInfo("Sucessfully swapped numbers : "+i+" "+j+" "+k);
                Console.ReadLine();
            }
        }
    }
}
