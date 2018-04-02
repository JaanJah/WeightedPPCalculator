using System;
using System.Collections.Generic;

namespace WeightedPPCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] ppScores = new double[100]; //change the number to how many scores you want to enter
            List<double> ppList = new List<double>();
            double totalPP = 0;
            for (int i = 0; i < ppScores.Length; i++)
            {
                Console.WriteLine("Enter your {0}. score", i + 1);
                double score = double.Parse(Console.ReadLine());
                ppScores[i] = score;
                ppList.Add(ppScores[i] * Math.Pow(0.95, (i)));
            }
            //For testing purposes
            foreach (double item in ppList)
            {
                Console.WriteLine("Weighted pp: {0}", item);
                totalPP += item;
            }
            Console.WriteLine(totalPP);
            Console.ReadLine();
        }
    }
}
