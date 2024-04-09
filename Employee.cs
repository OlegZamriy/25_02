using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_02
{
    using System;

    public class Employee
    {
        private string fullName;
        private DateTime dateOfBirth;
        private string contactPhone;
        private string workEmail;
        private string position;
        private string jobDescription;

        public Employee()
        {
            fullName = "";
            dateOfBirth = DateTime.MinValue;
            contactPhone = "";
            workEmail = "";
            position = "";
            jobDescription = "";
        }

        public void SetFullName(string name)
        {
            fullName = name;
        }

        public string GetFullName()
        {
            return fullName;
        }

        public void SetDateOfBirth(DateTime dob)
        {
            dateOfBirth = dob;
        }

        public DateTime GetDateOfBirth()
        {
            return dateOfBirth;
        }

        public void SetContactPhone(string phone)
        {
            contactPhone = phone;
        }

        public string GetContactPhone()
        {
            return contactPhone;
        }

        public void SetWorkEmail(string email)
        {
            workEmail = email;
        }

        public string GetWorkEmail()
        {
            return workEmail;
        }

        public void SetPosition(string pos)
        {
            position = pos;
        }

        public string GetPosition()
        {
            return position;
        }

        public void SetJobDescription(string desc)
        {
            jobDescription = desc;
        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine("ПІБ: " + fullName);
            Console.WriteLine("Дата народження: " + dateOfBirth.ToString("dd.MM.yyyy"));
            Console.WriteLine("Контактний телефон: " + contactPhone);
            Console.WriteLine("Робочий email: " + workEmail);
            Console.WriteLine("Посада: " + position);
            Console.WriteLine("Обов'язки:");
            Console.WriteLine(jobDescription);
        }
    }

}
