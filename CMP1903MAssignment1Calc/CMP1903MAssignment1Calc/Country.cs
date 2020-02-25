using System;
using System.Collections.Generic;
using System.Text;

namespace CMP1903MAssignment1Calc
{
    class Country
    {
        private string Name { get; set; }
        private double Population { get; set; }
        private int Vote { get; set; }
        //private bool IsEurozone { get; set; }

        public Country(string name, double pop, int vote)
        {
            Name = name;
            Population = pop;
            Vote = vote;
            //IsEurozone = euro;
        }

        public void GetVoteStatus()
        {
        Console.WriteLine(Vote);
        }

        public int SetVoteStatus()
        {
        Console.WriteLine("Do you want to change {0}'s vote? y/n", Name);
        string changevote = Console.ReadLine();
        if (changevote == "y")
        {
        Console.WriteLine("Enter vote for: {0}. 1 is for, -1 is against, 0 is abstain ", Name);
        Vote = Convert.ToInt32(Console.ReadLine());
        return Vote;
        }
        return Vote;
        }

        public double GetPop()
        {
            return Population;
        }
    }

    
}
