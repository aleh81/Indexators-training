using System;
using System.Collections.Generic;

namespace IndeksatorTraining.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestString_String();

            TestInt_String();

            Console.ReadKey();
        }

        static void TestString_String()
        {
            var elList = new ElementList<string, string>
            {
                {"alexkey", "Alexandr"},
                { "olegKey", "Oleg"},
                { "genadiKey", "Genadiy"},
                { "sergeyKey", "Sergey"}
            };

            Console.WriteLine(elList["sergeyKey"]);

            Display(elList);

            elList.Remove("Genadiy");

            Hr();
            Console.WriteLine("AfterRemove");

            Display(elList);

            var element = new Element<string, string>("sonyaKey", "Sonya");
            elList["sergeyKey"] = element;

            Hr();
            Console.WriteLine("After Insert element:");

            Display(elList);
        }

        static void TestInt_String()
        {
            var elIntList = new ElementList<int, string>
            {
                {1, "Alexandr"},
                {2, "Oleg"},
                {3, "Genadiy"},
                {4, "Sergey"}
            };

            Console.WriteLine("List with int keys:");

            DisplayAlternative(elIntList);

            try
            {
                elIntList.Add(1, "Fedia");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        static void Hr() => Console.WriteLine(new string('-', 20));

        static void Display<TKey, TValue>(ElementList<TKey, TValue> elements)
        {
            Hr();

            Console.WriteLine($"Count Elements: {elements.Count}");

            foreach (var element in elements)
            {
                Console.WriteLine(element);
            }
        }

        static void DisplayAlternative(ElementList<int, string> elements)
        {
            Hr();

            var div = new Dictionary<string, string>();

            for (var i = 0; i <= elements.Count; i++)
            {
                Console.WriteLine(elements[i]);
            }
        }
    }
}
