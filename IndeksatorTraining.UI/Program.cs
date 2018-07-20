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

            Console.WriteLine(elList["alexkey"]);

            //Console.WriteLine(list["Frodo"]);

            //Console.WriteLine(new string('-', 20));
            //Display(elList);

            ////var el = elList["Alexandr"];

            ////Console.WriteLine(el.Data);

            //elList.Remove("Genadi");

            //Console.WriteLine("After delete:");

            //Display(elList);

            //Console.WriteLine("Insert Element:");

            //var element = new Element<string>("Пятница");

            //elList["Ania"] = element;

            //Display(elList);

            Console.ReadKey();
        }

        public static void Display<TKey, TValue>(ElementList<TKey, TValue> elements)
        {
            Console.WriteLine($"Count Elements: {elements.Count}");

            foreach (var element in elements)
            {
                Console.WriteLine(element);
            }
        }
    }
}
