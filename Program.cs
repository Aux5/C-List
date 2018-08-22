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
planetList.Insert(1, "Venus");
planetList.Insert(2, "Earth");


List<string> lastPlanetList = new List<string>(){"Neptune", "Uranus"};
lastPlanetList.Add("Pluto");

List<string> rockyPlanets = planetList.GetRange(0,4);
planetList.AddRange(lastPlanetList);
planetList.Remove("Pluto");


List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>();
Dictionary<string, string> viking = new Dictionary<string,string>(){{"Mercury", "Viking"}};
Dictionary<string, string> opportunity = new Dictionary<string,string>(){{"Venus", "Opportunity"}};
Dictionary<string, string> mariner10 = new Dictionary<string,string>(){{"Mars", "Mariner 10"}};
Dictionary<string, string> EXProbe1 = new Dictionary<string,string>(){{"Jupiter", "EXProbe1"}};
Dictionary<string, string> EXProbe2 = new Dictionary<string,string>(){{"Saturn", "EXProbe2"}};
Dictionary<string, string> EXProbe3 = new Dictionary<string,string>(){{"Neptune", "EXProbe3"}};
Dictionary<string, string> EXProbe4 = new Dictionary<string,string>(){{"Uranus", "EXProbe4"}};

probes.Add(viking);
probes.Add(opportunity);
probes.Add(mariner10);
probes.Add(EXProbe1);
probes.Add(EXProbe2);
probes.Add(EXProbe3);
probes.Add(EXProbe4);


// foreach (KeyValuePair<int, string> number in numberTable)
// {
//     Console.WriteLine(number);
// }




foreach (string planet in planetList)
{
    List<string> visitedProbes = new List<string>();

    foreach (Dictionary<string,string> probe in probes)
    {
        if (probe.ContainsKey(planet)){
            visitedProbes.Add(probe[planet]);
        }
    }
    Console.WriteLine($"{planet}: {String.Join(",", visitedProbes)}");
}
        }
    }
}
