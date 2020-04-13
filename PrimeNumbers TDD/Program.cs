using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeNumbers_TDD
{
    class Program
    {
        static void Main(string[] args)
        {
            Test();
        }

        static void Test() 
        {
            Console.Write("Testing 1 passes: ");
            Console.WriteLine(Test1());
            
        }
        static bool Test1() 
        {   
            List<int> blankList = new List<int>();
            return blankList.SequenceEqual(PrimeNumbers(1));
        }
        

        static List<int> PrimeNumbers(int num) 
        {
            List<int> primeNumbers = new List<int>();
            
            return primeNumbers;
        }
    }
}
