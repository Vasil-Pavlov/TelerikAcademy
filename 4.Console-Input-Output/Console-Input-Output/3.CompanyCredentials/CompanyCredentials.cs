using System;

class CompanyCredentials
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAddress = Console.ReadLine();
        int companyPhoneNumber = int.Parse(Console.ReadLine());
        int faxNumber = int.Parse(Console.ReadLine());
        string webSite = Console.ReadLine();
        string managerFirstName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        int managerPhoneNumber = int.Parse(Console.ReadLine());
        int managerAge = int.Parse(Console.ReadLine());

        Console.WriteLine(companyName);
        Console.WriteLine(companyAddress);
        Console.WriteLine(companyPhoneNumber);
        Console.WriteLine(faxNumber);
        Console.WriteLine(webSite);
        Console.WriteLine(managerFirstName);
        Console.WriteLine(managerLastName);
        Console.WriteLine(managerPhoneNumber);
        Console.WriteLine(managerAge);
    }
}