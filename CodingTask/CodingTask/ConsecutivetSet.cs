using System;
using System.Collections.Generic;
using System.Text;

namespace CodingTask
{
    /// <summary>
    /// Find consecutive set of numbers in array, that sum up to given number. Output [start, end] indexes of first such set. Faster than O(N^2) solution required.
    //E.g. [1, 2, 4, 43, 65, 3, 5] and 7 => [0, 2], since 1 + 6 = 7\
    /// </summary>

    class ConsecutivetNumbers
    {
        public int FindNumber(int[] inputArray, int sum)
        {
            int result = 0;
            int startIndex;
            int endIndex;

            for(var i = 0; i < inputArray.Length; i++)
            {

                if (result < sum)
                {
                    if (result == 0)
                    { startIndex = i; }
                    
                    result += inputArray[i];
                    endIndex = i;
                }
                else
                if(result > sum)
                {
                    result = 0;
                
                }
                else
                {
                    return 
                }

            }

        }

    }
}
