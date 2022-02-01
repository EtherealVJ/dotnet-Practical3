using System;
using StringOP;
namespace Program{
    class StringMainOP
    {
        public static void Main(string[] args){
               
                Console.WriteLine("\nENTER STRING : ");
                String str = Console.ReadLine();
                Console.WriteLine($"\"{str}\" LENGTH : {StringOperation.Length(str)}");
                
               
                Console.WriteLine("\nENTER SENTENCE (TYPE) : ");
                String sentence = Console.ReadLine();
                
                if(StringOperation.isExclamation(sentence)){
                    Console.WriteLine("EXCLAMATORY SENTENCE !");               
                }else if(StringOperation.isDeclarative(sentence)){
                    Console.WriteLine("DECLARATIVE SENTENCE !");
                }else if(StringOperation.isInterrogative(sentence)){
                    Console.WriteLine("INTERROGATIVE SENTENCE !");
                }else { Console.WriteLine("UNABLE TO IDENTIFY THE SENTENCE ! "); }


               
                Console.WriteLine("\nENTER FIRST & LAST NAME : ");
                String name = Console.ReadLine();
                StringOperation.SwapN(name);
               
                Console.WriteLine("\nENTER NAME : ");
                String sname = Console.ReadLine();
                StringOperation.SwapIfElse(sname);

        }
    }
}
