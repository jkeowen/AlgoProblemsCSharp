using System;

namespace AlgoProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] statuesArray = { 6, 2, 3, 8 };
            int count = ConsecutiveStatues(statuesArray);
            Console.WriteLine(count);
     
        }

        static int ConsecutiveStatues(int[] statues)
        {
           Array.Sort(statues);
           int count = 0;
           int leftPointer = 0;
           int rightPointer = 1;
            while(leftPointer < statues.Length -1 ) 
            {
                Console.WriteLine("Lp: " + leftPointer);

                int difference = statues[rightPointer] - statues[leftPointer];
                Console.WriteLine("diff: " + difference);
                if(difference > 1 ) 
                {
                    count += (difference - 1);
                }             
                leftPointer++;
                rightPointer++;
            }
           return count;
        }

        static int shapeArea(int n)
        {
            int area = 1;
            for(int i = 1; i < n; i++)
            {
                area += 4 * i;
            }
            return area;
        }


        static int yearToCentury(int year)
        {
            return Convert.ToInt32(Math.Round(Convert.ToDouble(year) / 100, 0, MidpointRounding.ToPositiveInfinity));
        }

        static bool checkPalindrome(string palindrome)
        {
            if(palindrome.Length == 0)
            {
                return true;
            }
            int leftPointer = 0;
            int rightPointer = palindrome.Length - 1;
            while (leftPointer < rightPointer)
            {
                if (palindrome[leftPointer] != palindrome[rightPointer]) 
                {
                    return false;
                }
                leftPointer++;
                rightPointer--; 
            }
            return true;
        }

        static int adjacentElementsProduct(int[] inputArray)
        {
            int leftPointer = 1;
            int rightPointer = 2;
            int product = inputArray[0] * inputArray[1];
            while(rightPointer < inputArray.Length) 
            {
                int currentProduct = inputArray[leftPointer] * inputArray[rightPointer];
                if(currentProduct > product)
                {
                    product = currentProduct;
                }
                leftPointer++;
                rightPointer++;
            }
            return product;
        }

    }

  
}