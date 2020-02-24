using System;

namespace CMP1903MAssignment1Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] countryname = { "Austria", "Belgium", "Bulgaria", "Croatia", "Cyprus", "Czech Republic", "Denmark", "Estonia", "Finland", "France", "Germany", "Greece", "Hungary", "Ireland", "Italy", "Latvia", "Luxembourg", "Malta", "Netherlands", "Poland", "Romania", "Slovakia", "Slovenia", "Spain", "Sweden" };
            float[] countrypop = { 1.98f, 2.56f, 1.56f, 0.91f, 0.20f, 2.35f, 1.30f, 0.30f, 1.23f, 14.98f, 18.54f, 2.40f, 2.18f, 1.10f, 13.65f, 0.43f, 0.62f, 0.14f, 0.11f, 3.89f, 8.49f, 2.30f, 4.34f, 1.22f, 0.47f, 10.49f, 2.29f };
            Country c = new Country(name, pop, vote, euro);
        }
    }
}
