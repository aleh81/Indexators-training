using System;

namespace IndeksatorTraining.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            var elList = new ElementList<string>
            {
                "Alexandr",
                "Oleg",
                "Genadi",
                "Ania"
            };

            Display(elList);

            //var el = elList["Alexandr"];

            //Console.WriteLine(el.Data);

            elList.Remove("Genadi");

            Console.WriteLine("After delete:");

            Display(elList);

            Console.ReadKey();
        }

        public static void Display<T>(ElementList<T> elements) where T : class
        {
            foreach(var element in elements)
            {
                Console.WriteLine(element);
            }
        }
    }
}
