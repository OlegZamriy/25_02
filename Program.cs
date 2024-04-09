using _25_02;
using System;

class Program
{
    static void Main()
    {
        Website website1 = new Website();

        website1.SetWebsiteName("Example.com");
        website1.SetWebsitePath("/home");
        website1.SetWebsiteDescription("This is an example website");
        website1.SetWebsiteIpAddress("192.168.1.1");

        website1.DisplayWebsiteInfo();
    }
}
