using System;

namespace StringOP{
     
     class StringOperation
     {
      
         
        public static int Length(string s){
            return s.Length;
        }

        public static bool isExclamation(string s){
           return s[s.Length-1] == '!';
        }
        public static bool isDeclarative(string s){
            return s[s.Length-1] == '.';
        }

        public static bool isInterrogative(string s){
            return s[s.Length-1] == '?';
        }

        public static void SwapN(string s){
            string[] arr = s.Split(" ");
            Console.WriteLine($"ENTERED NAME :  \"{arr[1]}, {arr[0]}\"");
        }

        public static void SwapIfElse(string s){
            string[] arr = s.Split(" ");
            if(arr.Length == 1){
                Console.WriteLine($"ENTERED NAME : \"{arr[0]}\"");
            }else{
                Console.WriteLine($"ENTERED NAME : \"{arr[1]}, {arr[0]}\"");
            }

        }

     }

}
