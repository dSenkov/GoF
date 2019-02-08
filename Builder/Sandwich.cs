using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Sandwich
    {
        public Size Size { get; set; }
        public Sauce Sauce { get; set; }
        public Meat Meat { get; set; }
        public bool IsCold { get; set; }
        public bool IsSpicy { get; set; }
        public bool WithCheese { get; set; }
        
        public static SandwichBuilder Builder()
        {
            return new SandwichBuilder();
        }

        public override string ToString()
        {
            return "Sandwich " +
                (Size.ToString() != null ? "size " + Size + " " : "") +
                (Sauce.ToString() != null ? "with " + Sauce + " " : "") +
                (Meat.ToString() != null ? "with " + Meat + " " : "") +
                (WithCheese ? "with cheese " : " ") + 
                (IsCold ? "COLD " : "") + 
                (IsSpicy ? "SPICY " : "");
        }
    }

    public enum Size
    {
        M,
        L,
        XL,
        XXL
    }

    public enum Sauce
    {
        Ketchup,
        Mayonnaise,
        Mustard
    }

    public enum Meat
    {
        Chicken,
        Ham,
        Salami,
        Salmon
    }
}
