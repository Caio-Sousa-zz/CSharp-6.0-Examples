using System;

namespace C__6._0
{
    class Program
    {
        static void Main(string[] args)
        {
            
            stringInterpolationExample();
            nullConditionalOperatorExample();
            nameOfOperatorExample();
        }

        private static void stringInterpolationExample()
        {
            Console.WriteLine("\nString interpolation example \n");
            string t = "random variable value";
            Console.WriteLine($"Display variable value: {t}");
            Person p = new Person();
            p.name = "tony";
            Console.WriteLine($"Display name value: {p.name}");
        }

        private static void nullConditionalOperatorExample()
        {
            Console.WriteLine("\nNull conditional operator\n");
            Person p = new Person();
            Console.WriteLine($"Display name value: {p?.name ?? "Null Name"}");
            p.name = "John";
            Console.WriteLine($"Display name value: {p?.name ?? "Null Name"}");
            Console.WriteLine($"Display address value: {p?.address ?? "Null Address"}");
            p.address = "Street 123";
            Console.WriteLine($"Display address value: {p?.address ?? "Null Address"}");
        }


        private static void nameOfOperatorExample()
        {
            Console.WriteLine("\nnameof operator example \n");
            Console.WriteLine($"Name of Class:{nameof(Person)}");
            Console.WriteLine($"Name of Attribute:{nameof(Person.name)}");
        }
    }

    public class Person
    {
        public string name { get; set; }

        public string address { get; set; }
    }

    // Indent shift + alt + f
}