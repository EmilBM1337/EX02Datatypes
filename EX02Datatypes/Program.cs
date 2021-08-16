using System;

namespace EX02Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Emil";
            string lastName = "Mathiesen";
            int age = 22;

            Console.WriteLine($"Fornavn: {firstName}. Efternavn: {lastName}. Alder: {age}.");

            string title = "Lord of The Rings - The Two Towers";
            long isbn = 9780007117116;
            int pages = 450;
            double price = 249.95;

            Console.WriteLine(title);
            Console.WriteLine(isbn);
            Console.WriteLine(pages);
            Console.WriteLine(price);

            int maxInt = int.MaxValue;
            int minInt = int.MinValue;

            Console.WriteLine(maxInt);
            Console.WriteLine(minInt);
        }
    }
}
