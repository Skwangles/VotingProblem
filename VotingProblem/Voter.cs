using System;
using System.Collections.Generic;
using System.Text;

namespace VotingProblem
{
    class Voter
    {
        public bool isInRace;
        int candidateNumber;
        public Voter( int number)
        {
            isInRace = true;//to start the candidate is always in the race
            this.candidateNumber = number;//tells class what number to search for
        }
        public string Count(string[] votes)//counts the amount of its numbers in first position, should be 0 when eliminated
        {
            int counted = 0;//resets count to 0 always
            for(int inc = 0; inc < votes.Length; inc++)
            {
               var stringy = votes[inc];
                
                
                if (int.Parse(stringy[0].ToString()) == candidateNumber)
                {
                    counted++;
                }
                
            }

            if (isInRace)//checks if the candidate has been eliminated from the race or not. 
            {
                return counted.ToString();
            }
            else
            {
                return "Eliminated";
            }
            
        }

        public string[] Eliminate(string[] vote)
        {
             
            for (int size = 0; size < vote.Length; size++)
            {
                vote[size] = vote[size].Replace(candidateNumber.ToString(), "");
                if (vote[size].Length < 5)
                {
                    vote[size] += "0";//adds the 0 to the end for 5 numbers   
                }
            }

            isInRace = false;
            return vote;
        }

        public string Number()
        {
            return candidateNumber.ToString();
        }


    }
}
