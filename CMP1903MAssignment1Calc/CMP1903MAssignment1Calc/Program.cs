using System;

namespace CMP1903MAssignment1Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] countryname = { "Austria", "Belgium", "Bulgaria", "Croatia", "Cyprus", "Czech Republic", "Denmark", "Estonia", "Finland", "France", "Germany", "Greece", "Hungary", "Ireland", "Italy", "Latvia", "Luxembourg", "Malta", "Netherlands", "Poland", "Romania", "Slovakia", "Slovenia", "Spain", "Sweden" };
            float[] countrypop = { 1.98f, 2.56f, 1.56f, 0.91f, 0.20f, 2.35f, 1.30f, 0.30f, 1.23f, 14.98f, 18.54f, 2.40f, 2.18f, 1.10f, 13.65f, 0.43f, 0.62f, 0.14f, 0.11f, 3.89f, 8.49f, 2.30f, 4.34f, 1.22f, 0.47f, 10.49f, 2.29f };
            int[] countryvote = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            //1 is for, 0 is abstain, and -1 is against
            bool[] iseurozone = { true, true, false, false, true, false, false, true, true, true, true, true, false, true, true, true, true, true, true, true, false, true, false, true, true, true, false };
            Country[] countries = new Country[countryname.Length];

            for (int i = 0; i < countryname.Length; i++)
            {
                countries[i] = new Country(countryname[i], countrypop[i], countryvote[i], iseurozone[i]);
            }


            int voteFor = 0;
            string countryMajority = "Rejected";
            float voteForPop = 0;

            for (int x = 0; x < countryvote.Length; x++)
            {
                if (countryvote[x] == 1)
                {
                    voteFor += 1;
                    voteForPop += countrypop[x];
                }

                
            }
            //This will add up the amount of 'for' votes, as in the qualified majority rule an 'against' and an 'abstain' both count against the vote

            if (voteFor >= 15 && voteForPop >= 65)
            {
                countryMajority = "Passed"; 
            }
            else
            { 
                countryMajority = "Failed";

            }
                // This checks the current status of the vote

            Console.WriteLine($"Currently, the vote is {countryMajority}");

            Console.WriteLine("Would you like to change the votes?");
            

        }
    }
}
