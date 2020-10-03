using System;
using System.Collections.Generic;

namespace VotingProblem
{
    class Program
    {

        static void Main(string[] args)
        {
            var one = new Voter(1);
            var two = new Voter(2);
            var three = new Voter(3);
            var four = new Voter(4);
            var five = new Voter(5);


            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\tree_\Downloads\Votes.txt");
            /*
            string[,] voteRecord = new string[lines.Length];
            int counter = 0;
            foreach (string line in lines)
            {
                var temp = line.Split("");
                int increment = 0;
                foreach (string num in temp)
                {
                    voteRecord[counter, increment] = num;
                    increment++;
                }
                counter++;

            }
            */
            Display("First Preferences:");
            FindLeast();


            void FindLeast()
            {
                var voteCount = new int[,]
                {
                    {int.Parse(one.Count(voteRecord)), 1 },
                    { int.Parse(two.Count(voteRecord)), 2 },
                    { int.Parse(three.Count(voteRecord)), 3 },
                    { int.Parse(four.Count(voteRecord)), 4 },
                    { int.Parse(five.Count(voteRecord)), 5 }
                };

            }


            //functions
            void Display(string Status)
            {
                Console.WriteLine(Status);
                Console.WriteLine("Candidate 1: " + one.Count(voteRecord).ToString());
                Console.WriteLine("Candidate 2: " + two.Count(voteRecord).ToString());
                Console.WriteLine("Candidate 3: " + three.Count(voteRecord).ToString());
                Console.WriteLine("Candidate 4: " + four.Count(voteRecord).ToString());
                Console.WriteLine("Candidate 5: " + five.Count(voteRecord).ToString());

            }
        }
    }
}
