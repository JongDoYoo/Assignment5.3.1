using System.ComponentModel.Design;
using System.Numerics;

namespace Assignment5._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] flowerbed1 = { 1, 0, 0, 0, 0, 1 };
            int n1 = 1;
            Console.WriteLine($"Can plant {n1} flowers {NumofFlowers(flowerbed1, n1)}"); 
        }
        static bool NumofFlowers(int[] flowerbed, int n)
        {
             int counter = 0;
             for (int middle = 0; middle < flowerbed.Length-1; middle++)
            {
                int left = middle - 1;
                int right = middle + 1;

                if (flowerbed[middle] == 0 &&                           //if there is no plant where I'm standing in the loop, 
                   (middle == 0 || flowerbed[left] == 0) &&             //if Im in the beginning, there is no left of me
                   (middle == flowerbed.Length-1 || flowerbed[right] == 0))
                {
                    flowerbed[middle] = 1;
                    counter++;
                }   
            }                 
             if (counter < n)
            {
                return false;
            }
             return true;
        }   
    }
}
//{ 0, 0, 0, 0, 0, 1 };

//if (flowerbed[i] == 0 &&
//                (i == 0 || flowerbed[i - 1] == 0) &&
//                (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0))
