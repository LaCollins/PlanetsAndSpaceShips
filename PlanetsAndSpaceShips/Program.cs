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

            Dictionary<string, List<string>> spaceShips = new Dictionary<string, List<string>>();

            spaceShips.Add("Curiosity", new List<string> { "Mars", "Mercury" });
            spaceShips.Add("Opportunity", new List<string> { "Mars", "Earth" });
            spaceShips.Add("Voyager", new List<string> { "Jupiter", "Saturn" });
            spaceShips.Add("MooBeam", new List<string> { "Venus", "Mercury" });

            var ships = spaceShips.Keys;

            foreach ( var planet in planetList )
            {
                var outString = $"{planet}: ";
                 
                foreach( var ship in ships)
                {
                    var visitedPlanets = spaceShips.GetValueOrDefault(ship);
                    if (visitedPlanets[0] == planet)
                    {
                        outString += ship + ", ";
                    }
                    else if (visitedPlanets[1] == planet)
                    {
                        outString += ship + ", ";
                    }
                }

                Console.WriteLine(outString.Remove((outString.Length - 2), 2));
            }

            Console.ReadKey();
        }
    }
}
