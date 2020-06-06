using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Console
{
    public static class ShortingAlgorithms
    {
        public static int[] BubbleShort(int[] input)
        {
            //e.g. [8,2,4,1,3]
            //1st iteration [2,4,1,3,8]
            //2nd [2,1,3,4,8]
            //3rd [1,2,3,4,8]

            bool isShorted = false;

            while(!isShorted)
            {
                isShorted = true;

                for (int i = 0; i < input.Length - 1; i++)
                {
                    if (input[i + 1] < input[i])
                    {
                        SwapNumbers(ref input[i + 1], ref input[i]);
                        isShorted = false;
                    }                    
                }

                if (isShorted)
                        return input;
            }

            

            return input;
        }


        private static void SwapNumbers(ref int a, ref int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;

        }

        public static void SelectionShort(int[] input)
        {
            //e.g. [8,2,4,1,3]
            //1st iteration [1,2,4,8,3]
            //2nd [1,2,4,8,3]
            //3rd [1,2,3,8,4]
            //4rd [1,2,3,4,8]

            //bool isShorted = false;
            int min;

            for (int i = 0; i < input.Length; i++)
            {
                min = i;

                //isShorted = true;

                for (int j = i ; j < input.Length; j++)
                {
                    if (input[j] < input[min])
                    {
                        min = j;
                        
                    }                      
                }

                SwapNumbers(ref input[min],ref input[i]);
                
            }
        }
    }
}
