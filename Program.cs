using _25_02;
using System;

class Program
{
    static void Main()
    {
        Journal journal1 = new Journal();

        journal1.SetJournalName("Science Journal");
        journal1.SetYearFounded(2000);
        journal1.SetJournalDescription("A journal for scientific research articles.");
        journal1.SetContactPhone("+1234567890");
        journal1.SetEmail("science@example.com");

        journal1.DisplayJournalInfo();
    }
}
