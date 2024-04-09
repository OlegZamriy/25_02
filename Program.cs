using _25_02;
using System;

class Program
{
    static void Main()
    {
        City city1 = new City();

        city1.SetCityName("Київ");
        city1.SetCountryName("Україна");
        city1.SetPopulation(2800000);
        city1.SetAreaCode(44);
        city1.SetDistricts(new string[] { "Шевченківський", "Печерський", "Голосіївський" });

        city1.DisplayCityInfo();
    }
}
