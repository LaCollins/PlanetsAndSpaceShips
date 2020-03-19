using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceShips
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            List<string> otherPlanets = new List<string>() { "Uranus", "Neptune" };

            planetList.AddRange(otherPlanets);

            planetList.Insert(1, "Venus");
            planetList.Insert(2, "Earth");

            planetList.Add("Pluto");

            List<string> rockyPlanets = planetList.GetRange(0, 4);

            planetList.Remove("Pluto");

            foreach (var planet in planetList)
            {
                Console.WriteLine(planet);
            }

            Console.ReadKey();
        }
    }
}
