using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "Teipei", "London", "Seattle", "Boston",
                                "Los Angeles", "Shanghai", "Hyderabad", "Kyoto"};

            IEnumerable<string> filteredcities2 = cities.Where(c => c.Length < 7)
                                            .OrderBy(c => c)
                                            .Select(c => c);

            IEnumerable<string> filteredCities1 = from city in cities
                                                  where city.Length < 7
                                                  orderby city
                                                  select city;

            foreach (var city in filteredCities1)
            {
                Console.WriteLine(city);
            }

            foreach (var city in filteredcities2)
            {
                Console.WriteLine(city);
            }

        }
    }
}
