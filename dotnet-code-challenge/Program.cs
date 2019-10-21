using System;
using System.Collections.Generic;
using dotnet_code_challenge.Models;
using dotnet_code_challenge.Implementations;
using System.Linq;

namespace dotnet_code_challenge
{
    class Program
    {
        private static readonly string xmlPath = @"..\..\..\FeedData\Caulfield_Race1.xml";
        private static readonly string jsonPath = @"..\..\..\FeedData\Wolferhampton_Race1.json";
        static void Main(string[] args)
        {
            
            var caulfieldParser = new CaulfieldParser(new XmlReader(xmlPath));
            var wolferhamptonParser = new WolferHamptonParser(new JSonReader(jsonPath));

            var combinedList = caulfieldParser.GetHorses();
            var wolferHorses = wolferhamptonParser.GetHorses();
            combinedList.AddRange(wolferHorses);

            if (combinedList !=null && combinedList.Any())
            {
               combinedList.OrderBy(horse => horse.Price).ToList().ForEach(item => {
                   Console.WriteLine($"horse name: {item.Name} price: {item.Price}");
               });

                Console.ReadLine();
            }

        }
    }
}
