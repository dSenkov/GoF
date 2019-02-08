using System;

namespace Builder
{
    class SandwichBuilder
    {
        Sandwich sandwich = new Sandwich();

        public SandwichBuilder Size(Size size)
        {
            sandwich.Size = size;
            return this;
        }

        public SandwichBuilder Sauce(Sauce sauce)
        {
            sandwich.Sauce = sauce;
            return this;
        }

        public SandwichBuilder Meat(Meat meat)
        {
            sandwich.Meat = meat;
            return this;
        }

        public SandwichBuilder IsCold(bool isCold)
        {
            sandwich.IsCold = isCold;
            return this;
        }

        public SandwichBuilder IsSpicy(bool isSpicy)
        {
            sandwich.IsSpicy = isSpicy;
            return this;
        }

        public SandwichBuilder WithCheese(bool withCheese)
        {
            sandwich.WithCheese = withCheese;
            return this;
        }

        public Sandwich Build()
        {
            return sandwich;
        }      
    }
}