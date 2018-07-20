using System;
using System.Collections.Generic;

namespace IndeksatorTraining.UI
{
    class Program
    {
        static void Main(string[] args)
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

        static void DisplayAlternative<Tkey, TValue>(ElementList<Tkey, TValue> elements)
        {
            Hr();
        }
    }
}
