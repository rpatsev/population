using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Population
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<City> citiesList = new List<City>();
            string listOfCities = "Kharkiv=1431000,Kiev=2804000,Las Vegas=603400";
            string[] dividors = { "," };
            string[] cities = listOfCities.Split(dividors, StringSplitOptions.RemoveEmptyEntries);
            int maxCityNameLength = 0;
            int maxCityPopulation = 0;
            foreach(var city in cities)
            {
                string[] innerDividors = { "=" };
                int dividorPosition = city.IndexOf(innerDividors[0]);
                var cityName = city.Substring(0, dividorPosition);
                if(cityName.Length > maxCityNameLength)
                {
                    maxCityNameLength = cityName.Length;
                }
                var cityPopulation = city.Substring(dividorPosition + 1, city.Length - dividorPosition - 1);
                Console.WriteLine($"CityName: "+cityName);
                Console.WriteLine($"CityPopulation: "+cityPopulation);
                //citiesList.Add(cityName, cityPopulation);
                string[] cityParameters = city.Split(innerDividors, StringSplitOptions.RemoveEmptyEntries);
            }
            //Console.WriteLine($"Longest name: "maxCityNameLength);
            Console.ReadKey();
        }

        
    }
}
