using System;
using System.Collections.Generic;

namespace C__6._0
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            stringInterpolationExample();
            nullConditionalOperatorExample();
            nameOfOperatorExample();
            exceptionFilterExample();
            indexInitializer();
            usingStatic();
            */
            autoPropertyInitializer();
        }

        // 1.1 String Interpolation.
        private static void stringInterpolationExample()
        {
            displayTitle("String interpolation example");
            string t = "random variable value";
            Console.WriteLine($"Display variable value: {t}");
            Person p = new Person();
            p.name = "tony";
            Console.WriteLine($"Display name value: {p.name}");
        }

        // 1.2 Null conditional operator example.
        private static void nullConditionalOperatorExample()
        {
            displayTitle("Null conditional operator");
            Person p = new Person();
            Console.WriteLine($"Display name value: {p?.name ?? "Null Name"}");
            p.name = "John";
            Console.WriteLine($"Display name value: {p?.name ?? "Null Name"}");
            Console.WriteLine($"Display address value: {p?.address ?? "Null Address"}");
            p.address = "Street 123";
            Console.WriteLine($"Display address value: {p?.address ?? "Null Address"}");
        }

        // 1.3 Name of operator example.
        private static void nameOfOperatorExample()
        {
            displayTitle("nameof operator example");
            Console.WriteLine($"Name of Class:{nameof(Person)}");
            Console.WriteLine($"Name of Attribute:{nameof(Person.name)}");
        }

        // 1.4 Expression-bodied members example.
        private static void displayTitle(string title) => Console.WriteLine($"\n{title} \n");

        // 1.5 Exception filters example
        private static void exceptionFilterExample()
        {
            int x = 54;
            int y = 0;
            try
            {
                int result = x / y;
            }
            catch (Exception ex) when (ex.Message.Contains("divide"))
            {
                Console.WriteLine($"Message2: {ex.Message}");
            }
        }

        // 1.6 Index intializer
        private static void indexInitializer()
        {
            Dictionary<int, string> intializedList = new Dictionary<int, string>
            {
                [1] = "Index one",
                [2] = "Index two",
                [3] = "Index three"
            };

            Console.WriteLine($"Index 1: {intializedList[1]}");
            Console.WriteLine($"Index 2: {intializedList[2]}");
            Console.WriteLine($"Index 3: {intializedList[3]}");
        }

        // 1.7 Using static
        private static void usingStatic()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine($"Sum a + b static {Calculator.sumStatic(a, b)}");
            Console.WriteLine($"Sum a + b not static {new Calculator().sumNotStatic(a, b)}");
        }

        // 1.8 Auto property initializer
        private static void autoPropertyInitializer()
        {
            InitializerExample init = new InitializerExample();
            Console.WriteLine($"Default age: {init.age}");
            Console.WriteLine($"Default address: {init.address}");
        }

        // 1.9 Overload method
        private static void overloadMethod(string v)
        {
            Console.WriteLine($"Display string: {v}");
        }

        // 1.9 Overload method
        private static void overloadMethod(int v)
        {
            Console.WriteLine($"Display int: {v}");
        }

        // 1.9 Overload method
        private static void overloadMethod(object v)
        {
            Console.WriteLine($"Display object: {v}");
        }

        // 1.9 Overload method
        private static void overloadMethod(bool v)
        {
            Console.WriteLine($"Display boolean: {v}");
        }

        // 1.9 Overload method
        private static void overloadMethod(Person v)
        {
            Console.WriteLine($"Display person: {v}");
        }


        
        // 2.0 Read only auto properties
        private static void ReaOnlyAutoProperties()
        {
            Console.WriteLine($"Read only accessor: {new ReadOnlyExample().age}");
        }
    }
    public class Person
    {
        public string name { get; set; }

        public string address { get; set; }
    }

    public class Calculator
    {
        public static int sumStatic(int a, int b) => a + b;

        public int sumNotStatic(int a, int b) => a + b;
    }

    public class InitializerExample
    {
        public int age { get; set; } = 10;

        public string address { get; set; } = "Default Address";
    }

    public class ReadOnlyExample
    {
        public int age { get; } = 27;
    }
}