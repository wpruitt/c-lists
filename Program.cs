using System;
using System.Collections.Generic;

namespace lists
{
    class Program
    {
        static void Main(string[] args)
        {
        List<string> planetList = new List<string>(){"Mercury", "Mars"};
        planetList.Add("Jupiter");
        planetList.Add("Saturn");
        List<string> planetList2 = new List<string>(){"Neptune", "Uranus"};
        planetList.AddRange(planetList2);
        planetList.Insert(2, "Venus");
        planetList.Insert(2, "Earth");
        planetList.Add("Pluto");
        List<string> rockyPlanets = new List<string>(planetList.GetRange(0, 4));
         foreach(string planet in rockyPlanets)
        {
            Console.WriteLine(planet);
        }
        planetList.Remove("Pluto");
        foreach(string planet in planetList)
        {
            Console.WriteLine(planet);
        }
        }
    }
}
