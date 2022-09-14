
using System;

namespace ConsoleApp{
   class Resume {
   static void Main(string[] args)
    {
        Console.WriteLine ("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter your present Address: ");
        string praddress = Console.ReadLine();
        Console.Write("Enter your present Address: ");
        string paddress = Console.ReadLine();
        Console.Write("Enter your Date of Birth: ");
        string dob = Console.ReadLine();
        Console.Write("Enter your Age: ");
        string age = Console.ReadLine();
        Console.Write("Enter your Religion: ");
        string religion = Console.ReadLine();
        Console.Write("Enter your Weight: ");
        string weight = Console.ReadLine();
        Console.Write("Enter your Height: ");
        string height = Console.ReadLine();
        Console.Write("Enter your Civil Status: ");
        string civil = Console.ReadLine();
        Console.Write("Enter your Citizenship: ");
        string citizen = Console.ReadLine();
        Console.Write("Enter your Place of Birth: ");
        string pob = Console.ReadLine();
        Console.Write("Enter the name of your Father: ");
        string fname = Console.ReadLine();
        Console.Write("Enter the name of your Mother: ");
        string mname = Console.ReadLine();
        Console.Write("Enter your Address: ");
        string address = Console.ReadLine();
        Console.Write("Enter your Language or Dialect: ");
        string language = Console.ReadLine();
        Console.Write("Enter the name of the person to be notified in case of emergency: ");
        string emperson = Console.ReadLine();
        Console.WriteLine("================================================================");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Present Address: " + praddress);
        Console.WriteLine("Permanent Address: " + paddress );
        Console.WriteLine("Date of Birth: " + dob + "      Religion: " + religion);
        Console.WriteLine("Civil Status:" + civil + "      Age: " + age);
        Console.WriteLine("Citizenship:" + citizen + "     Weight: "+ weight);
        Console.WriteLine("Place of Birth: " + pob + "     Height:" + height);
        Console.WriteLine("Name of your Father: " + fname);
        Console.WriteLine("Name of your Mother: " + mname);
        Console.WriteLine("Address: " + address);
        Console.WriteLine("Language or Dialect Spoken: " + language);
        Console.WriteLine("Person to be notified in Case of Emergency: " + emperson);
        Console.Write("\nPress any key key to exit...");
        Console.ReadKey();
    }
}
}