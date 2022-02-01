using System;
using RationalNumbers;
namespace Program
{
    class Rmain
    {
        public static void Main(){
            Console.WriteLine("ENTER NUMERATOR :");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER DENOMINATOR :");
            int deno = Convert.ToInt32(Console.ReadLine());            
            RationalNumbersOP R = new RationalNumbersOP(num,deno);
            Console.WriteLine("FLOATING DIVSION RESULT = " + R.FloatingPtDivision());
            R.MixedFraction();
            R.IntegerDiv();
           
        }
    }
    
}