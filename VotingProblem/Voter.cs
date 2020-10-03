using System;
using System.Collections.Generic;
using System.Text;

namespace VotingProblem
{
    class Voter
    {
        private bool isInRace;
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
                if(int.Parse(votes[inc][0]) == candidateNumber)
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

        public string[,] Eliminate(string[] vote)
        {
            //here remove the Candidate's number and shift all others to the left. 

            return vote;
        }



    }
}
