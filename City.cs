using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_02
{
    using System;

    public class City
    {
        private string cityName;
        private string countryName;
        private int population;
        private int areaCode;
        private string[] districts;

        public City()
        {
            cityName = "";
            countryName = "";
            population = 0;
            areaCode = 0;
            districts = new string[0];
        }

        public void SetCityName(string name)
        {
            cityName = name;
        }

        public string GetCityName()
        {
            return cityName;
        }

        public void SetCountryName(string name)
        {
            countryName = name;
        }

        public string GetCountryName()
        {
            return countryName;
        }

        public void SetPopulation(int pop)
        {
            population = pop;
        }

        public int GetPopulation()
        {
            return population;
        }

        public void SetAreaCode(int code)
        {
            areaCode = code;
        }

        public int GetAreaCode()
        {
            return areaCode;
        }

        public void SetDistricts(string[] dist)
        {
            districts = dist;
        }

        public void DisplayCityInfo()
        {
            Console.WriteLine("Назва міста: " + cityName);
            Console.WriteLine("Назва країни: " + countryName);
            Console.WriteLine("Кількість жителів: " + population);
            Console.WriteLine("Телефонний код: " + areaCode);
            Console.WriteLine("Райони міста:");
            foreach (var district in districts)
            {
                Console.WriteLine("- " + district);
            }
        }
    }

}
