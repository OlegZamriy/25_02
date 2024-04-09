using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_02
{
    using System;

    public class Journal
    {
        private string journalName;
        private int yearFounded;
        private string journalDescription;
        private string contactPhone;
        private string email;

        public void SetJournalName(string name)
        {
            journalName = name;
        }

        public string GetJournalName()
        {
            return journalName;
        }

        public void SetYearFounded(int year)
        {
            yearFounded = year;
        }

        public int GetYearFounded()
        {
            return yearFounded;
        }

        public void SetJournalDescription(string description)
        {
            journalDescription = description;
        }

        public string GetJournalDescription()
        {
            return journalDescription;
        }

        public void SetContactPhone(string phone)
        {
            contactPhone = phone;
        }

        public string GetContactPhone()
        {
            return contactPhone;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }

        public string GetEmail()
        {
            return email;
        }

        public void DisplayJournalInfo()
        {
            Console.WriteLine("Назва журналу: " + journalName);
            Console.WriteLine("Рік заснування: " + yearFounded);
            Console.WriteLine("Опис журналу: " + journalDescription);
            Console.WriteLine("Контактний телефон: " + contactPhone);
            Console.WriteLine("Email: " + email);
        }
    }

}
