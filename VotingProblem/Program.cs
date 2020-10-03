using System;
using System.Collections.Generic;

namespace VotingProblem
{
    class Program
    {

        static void Main(string[] args)
        {
            //
            //Setup
            //
            var one = new Voter(1);
            var two = new Voter(2);
            var three = new Voter(3);
            var four = new Voter(4);
            var five = new Voter(5);
            var Candidates = new List<Voter>
            {
                one,
                two,
                three,
                four,
                five
            };
            //
            // End Of Setup
            //
            string EliminationMessage = "";
            string[] voteRecord = System.IO.File.ReadAllLines(@"C:\Users\tree_\Downloads\Votes.txt");//gets the votes from the file
           

            //Process
            Display("First Preferences:");
            FindLeast();
            Display("After initial elimination");
            FindLeast();
            Display("After second elimination");
            FindLeast();
            Display("After third elimination");
            FindLeast();
            Display("After fourth and final elimination");




            void DebugDisplay()//for checking the value of what the modified votes are
            {
                foreach(string s in voteRecord)
                {
                    Console.WriteLine(s);
                }


            }
           
            void FindLeast()
            {
                var points = new List<int>();

                if (one.isInRace) { points.Add(int.Parse(one.Count(voteRecord))); }//checks to see if the candidate is in the race before adding the the current list
                if (two.isInRace) { points.Add(int.Parse(two.Count(voteRecord))); }
                if (three.isInRace) { points.Add(int.Parse(three.Count(voteRecord))); }
                if (four.isInRace) { points.Add(int.Parse(four.Count(voteRecord))); }
                if (five.isInRace) { points.Add(int.Parse(five.Count(voteRecord))); }
              
                points.Sort();
                points.Reverse();

                foreach (Voter v in Candidates)
                {
                    if (v.isInRace)//makes sure the candidate is still in the race
                    {
                        if (int.Parse(v.Count(voteRecord)) == points[points.Count - 1])
                        {
                            voteRecord = v.Eliminate(voteRecord);//class will remove itself from array
                            EliminationMessage = "Candidate " + v.Number() + " was eliminated";
                            break;
                        }
                    }
                }
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
                Console.WriteLine(EliminationMessage);
                Console.WriteLine("");
                if(Status == "After fourth and final elimination")
                {
                    foreach(Voter v in Candidates)
                    {
                        if (v.isInRace)
                        {
                            Console.WriteLine("Candidate " + v.Number() + " is elected.");
                        }
                    }


                }


            }
        }
    }
}
