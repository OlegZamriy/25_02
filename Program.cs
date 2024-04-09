using _25_02;
using System;

class Program
{
    static void Main()
    {
        Store store1 = new Store();

        store1.SetStoreName("Магазин Товари для дому");
        store1.SetAddress("вул. Центральна, 123");
        store1.SetStoreProfile("Продаж побутової техніки та меблів");
        store1.SetContactPhone("+1234567890");
        store1.SetEmail("store@example.com");

        store1.DisplayStoreInfo();
    }
}
