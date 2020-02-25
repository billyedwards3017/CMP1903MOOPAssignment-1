using System;
using System.Collections.Generic;
using System.Text;

namespace CMP1903MAssignment1Calc
{
    class Country
    {
        public string Name { get; set; }
        public double Population { get; set; }
        public int Vote { get; set; }
        public bool IsEurozone { get; set; }

        public Country(string name, double pop, int vote, bool euro)
        {
            Name = name;
            Population = pop;
            Vote = vote;
            IsEurozone = euro;
        }

        public void GetVoteStatus()
        {
        Console.WriteLine(Vote);
        }

        public void SetVoteStatus()
        {
        Console.WriteLine("Enter vote for: {0}. 1 is for, -1 is against, 0 is abstain ", Name);
        Vote = Convert.ToSingle(Console.ReadLine());
        }
    }

    
}
