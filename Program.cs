using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        static void RandomArray(){
            Random rand = new Random();
            List<int> newList = new List<int>();
            for (int i = 0; i < 10; i++){
                newList.Add(rand.Next(5,25));
            }
            int[] newArray = new int[newList.Count];
            for (int i = 0; i < newList.Count; i++){
                newArray[i] = newList[i];
                // Console.WriteLine(newArray[i]);
            }

            int max = Int32.MinValue;
            int min = Int32.MaxValue;
            int sum = 0;
            for (int i = 0; i < newArray.Length; i++){
                if (newArray[i] > max){
                    max = newArray[i];
                }
                if (newArray[i] < min){
                    min = newArray[i];
                }
                sum += newArray[i];
            }
            Console.WriteLine("Max: {0}", max);
            Console.WriteLine("Min: {0}", min);
            Console.WriteLine("Sum: {0}", sum);
        }
        static void CoinToss(){
            Random rand = new Random();
            Console.WriteLine("Tossing a Coin!");
            int side = rand.Next(0,2);
            if (side == 1){
                Console.WriteLine("The Coin Landed on Heads!");
            } else {
                Console.WriteLine("The Coin Landed on Tails!");
            }
        }
        static void TossMultipleCoins(int num){
            Random rand = new Random();
            double count = 0;
            double tosses = num;
            for (int i = 0; i < num; i++){
                Console.WriteLine("Tossing a Coin!");
                int side = rand.Next(0,2);
                if (side == 1){
                    Console.WriteLine("The Coin Landed on Heads!");
                    count += 1;
                } else {
                    Console.WriteLine("The Coin Landed on Tails!");
                }
            }
            double ratio = count/tosses;
            Console.WriteLine("Heads/Toss Ratio: {0}", ratio);
        }
        static void Names(){
            Random rand = new Random();
            string[] nameList = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            for(var i = 0; i < nameList.Length - 1; i++){
                int randidx = rand.Next(i + 1, nameList.Length - 1);
                string temp = nameList[i];
                nameList[i] = nameList[randidx];
                nameList[randidx] = temp;
                Console.WriteLine(nameList[i]);
            }
            List<string> newList = new List<string>();
            for (int i = 0; i < nameList.Length; i++){
                if (nameList[i].Length >= 5){
                    newList.Add(nameList[i]);
                }
            }
            string[] newArray = new string[newList.Count];
            for (int i = 0; i < newList.Count; i++){
                newArray[i] = newList[i];
                Console.WriteLine(newArray[i]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // RandomArray();
            // CoinToss();
            // TossMultipleCoins(3);
            Names();
        }
    }
}
