using System;
using System.Data;
using System.Data.SqlTypes;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nece eded olacaq?");
            string sums = Console.ReadLine();
            var sum = Convert.ToInt32(sums);
            int[] rept = new int[sum];
            for(int i = 0; i < rept.Length; i++)
            {
                string Sums = Console.ReadLine();
                var Sum = Convert.ToInt32(Sums);
                rept[i] = Sum;



            }
        

            int result = FindBiggest(rept);
            Console.WriteLine(result);
            

            

        }
       
        

        static int FindBiggest(int[] numbers)
        {
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            return max;
        }
        static bool HasNum(bool a=true)
        {
             

            string nuks = "0,1,2,3,4,5,6,7,8,9";
            string ed1 = Console.ReadLine();
            for (int j = 0; j < ed1.Length; j++)
            { 
                for (int s = 0; s < nuks.Length; s++) 
                {
                    if (ed1==nuks)
                    {

                            a = true;
                           break;

                    }

                }

            }

            if (a)
            {


               Console.WriteLine("edetde a herifi var");

            }
            else {
                Console.WriteLine("a herifi yoxtur");


            }
            
            return a;
        } 
    }
}
