using _25_02;
using System;

class Program
{
    static void Main()
    {
        Employee employee1 = new Employee();

        employee1.SetFullName("Іванов Іван Іванович");
        employee1.SetDateOfBirth(new DateTime(1985, 10, 15));
        employee1.SetContactPhone("+380971234567");
        employee1.SetWorkEmail("ivanov@example.com");
        employee1.SetPosition("Програміст");
        employee1.SetJobDescription("Розробка програмного забезпечення.");

        employee1.DisplayEmployeeInfo();
    }
}
