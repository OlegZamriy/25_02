using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_02
{
    using System;

    public class Store
    {
        private string storeName;
        private string address;
        private string storeProfile;
        private string contactPhone;
        private string email;

        public void SetStoreName(string name)
        {
            storeName = name;
        }

        public string GetStoreName()
        {
            return storeName;
        }

        public void SetAddress(string address)
        {
            this.address = address;
        }

        public string GetAddress()
        {
            return address;
        }

        public void SetStoreProfile(string profile)
        {
            storeProfile = profile;
        }

        public string GetStoreProfile()
        {
            return storeProfile;
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

        public void DisplayStoreInfo()
        {
            Console.WriteLine("Назва магазину: " + storeName);
            Console.WriteLine("Адреса: " + address);
            Console.WriteLine("Опис профілю магазину: " + storeProfile);
            Console.WriteLine("Контактний телефон: " + contactPhone);
            Console.WriteLine("Email: " + email);
        }
    }

}
