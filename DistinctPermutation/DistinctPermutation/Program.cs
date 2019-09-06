using System;

namespace DistinctPermutation
{
    //    Write a function that given a string, produces all possible permutations of that string. Please use recursion
    //    Example:
    //      "ABC" ==> "ABC, ACB, BAC, BCA, CAB, CBA"
    //      "ABB" ==> "ABB, BAB, BBA"
    //       3 => 3! => 1 * 2 * 3 => 6
    //       4 => 4! => 1 * 2 * 3 * 4 => 24

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input string:");
            var inputString = Console.ReadLine();

            Permute(inputString, 0, inputString.Length - 1);

            Console.ReadKey();
        }

        static void Permute(string inputString, int firstIndex, int lastIndex)
        {
            if(firstIndex == lastIndex)
            {
                Console.WriteLine(inputString);
            }
            else
            {
                for(var i = firstIndex; i <= lastIndex; i++)
                {
                    if(NeedSwap(inputString, firstIndex, i))
                    {
                        inputString = Swap(inputString, firstIndex, i);
                        Permute(inputString, firstIndex + 1, lastIndex);
                    }
                }
            }
        }

        static string Swap(string inputString, int firstIndex, int currentIndex)
        {
            char[] inputArray = inputString.ToCharArray();
            char temp;

            temp = inputArray[firstIndex];
            inputArray[firstIndex] = inputArray[currentIndex];
            inputArray[currentIndex] = temp;

            return new string(inputArray);
        }

        static bool NeedSwap(string inputString, int firstIndex, int currentIndex)
        {
            for(var i = firstIndex; i < currentIndex; i++)
            {
                if(inputString[i] == inputString[currentIndex])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
