using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class Person : ICloneable                   // Prototype pattern is already implemented in standart C# library, so we don't have to reinvent anything :)
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person() {}
        public Person(Person person)
        {
            FirstName = person.FirstName;
            LastName = person.LastName;
            Age = person.Age;
        }

        public object Clone()
        {
            return new Person(this);
        }

        public override string ToString()
        {
            return "Hash code: " + GetHashCode() + " - " + FirstName + ' ' + LastName + ", " + Age + " y.o.";
        }
    }
}
