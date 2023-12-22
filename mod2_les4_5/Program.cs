using System;

namespace mod2_les4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter user data");
            Console.WriteLine("Enter firstname: ");
            string firstname = Console.ReadLine();

            Console.WriteLine("Enter lastname: ");
            string lastname = Console.ReadLine();

            Console.WriteLine("Enter email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Enter phone number: ");
            string phonenumber = Console.ReadLine();

            Console.WriteLine("Enter age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter weight(given in kg): ");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter height(given in cm): ");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("The given data is: ");
            Console.WriteLine($"{firstname} {lastname}");
            Console.WriteLine($"Email: {email}");
            Console.WriteLine($"Phone number: {phonenumber}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Weight: {weight} kg");
            Console.WriteLine($"Height: {height} cm");

        }
    }
}


            

