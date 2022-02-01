using System;

namespace RationalNumbers
{  
         class RationalNumbersOP
         {
       
            int num,deno;
            public RationalNumbersOP(int a,int b){
                 this.deno = b;
                 this.num = a;
                 if(b==0){
                     throw new DivideByZeroException();
                 }
             }
            public double FloatingPtDivision(){
                        return ((float)num/deno);
             }

            public void MixedFraction(){
                    int wNum = (int)num/deno;
                    Console.WriteLine("MIXED FRACTION RESULT = " + wNum + " " + (num%deno) + "/" + deno);
             }

             public void IntegerDiv(){
                Console.WriteLine($"INTEGER DIVISION RESULT = QUOTIENT : {(int)num/deno}  REMAINDER : {num%deno}");
             }

             
             
         }
    
}