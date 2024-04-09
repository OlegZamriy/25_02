using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_02
{
    using System;

    public class Website
    {
        private string websiteName;
        private string websitePath;
        private string websiteDescription;
        private string websiteIpAddress;

        public void SetWebsiteName(string name)
        {
            websiteName = name;
        }

        public string GetWebsiteName()
        {
            return websiteName;
        }

        public void SetWebsitePath(string path)
        {
            websitePath = path;
        }

        public string GetWebsitePath()
        {
            return websitePath;
        }

        public void SetWebsiteDescription(string description)
        {
            websiteDescription = description;
        }

        public string GetWebsiteDescription()
        {
            return websiteDescription;
        }

        public void SetWebsiteIpAddress(string ipAddress)
        {
            websiteIpAddress = ipAddress;
        }

        public string GetWebsiteIpAddress()
        {
            return websiteIpAddress;
        }

        public void DisplayWebsiteInfo()
        {
            Console.WriteLine("Назва сайту: " + websiteName);
            Console.WriteLine("Шлях до сайту: " + websitePath);
            Console.WriteLine("Опис сайту: " + websiteDescription);
            Console.WriteLine("IP-адреса сайту: " + websiteIpAddress);
        }
    }

}
