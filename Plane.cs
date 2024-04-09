using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_02
{
    using System;

    public class Plane
    {
        private string planeName;
        private string manufacturer;
        private int yearOfManufacture;
        private string planeType;

        public Plane()
        {
            planeName = "";
            manufacturer = "";
            yearOfManufacture = 0;
            planeType = "";
        }

        public Plane(string name, string manufacturer, int year, string type)
        {
            planeName = name;
            this.manufacturer = manufacturer;
            yearOfManufacture = year;
            planeType = type;
        }

        public void SetPlaneName(string name)
        {
            planeName = name;
        }

        public string GetPlaneName()
        {
            return planeName;
        }

        public void SetManufacturer(string manufacturer)
        {
            this.manufacturer = manufacturer;
        }

        public string GetManufacturer()
        {
            return manufacturer;
        }

        public void SetYearOfManufacture(int year)
        {
            yearOfManufacture = year;
        }

        public int GetYearOfManufacture()
        {
            return yearOfManufacture;
        }

        public void SetPlaneType(string type)
        {
            planeType = type;
        }

        public string GetPlaneType()
        {
            return planeType;
        }

        public void DisplayPlaneInfo()
        {
            Console.WriteLine("Назва літака: " + planeName);
            Console.WriteLine("Виробник: " + manufacturer);
            Console.WriteLine("Рік випуску: " + yearOfManufacture);
            Console.WriteLine("Тип літака: " + planeType);
        }
    }

}
