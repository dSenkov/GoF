using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Sandwich sandwich = Sandwich.Builder()
                .Size(Size.XL)
                .Sauce(Sauce.Ketchup)
                .Meat(Meat.Chicken)
                .WithCheese(true)
                .IsSpicy(true)
                .IsCold(false)
                .Build();
            Console.WriteLine(sandwich);

            Console.ReadKey();
        }
    }
}
