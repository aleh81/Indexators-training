using System;
using System.Collections;
using System.Collections.Generic;

namespace IndeksatorTraining.UI
{
    public class Element<T>
    {
        public T Data { get; set; }

        public Element<T> Next { get; set; }

        public Element(T data)
        {
            Data = data;
        }
    }

    class ElementList<T> : IEnumerable<T>
    {
        Element<T> head;

        Element<T> tail;

        int count;

        public int Count => count;

        public Element<T> this[T index]
        {
            get
            {
                return GetElementByData(index);
            }
        }

        private Element<T> GetElementByData(T data)
        {
            Element<T> current = head;
            Element<T> previous = null;

            while (current != null)
            {
                if (!current.Data.Equals(data))
                {
                    previous = current;
                    current = current.Next;
                }

                if (previous != null && current.Next == null)
                {
                    tail = previous;
                }
                else
                {
                    head = head.Next;

                    if (head == null)
                    {
                        tail = null;
                    }
                }

                count--;

                return current;
            }

            return null;
        }

        public void Add(T data)
        {
            var element = new Element<T>(data);

            if (head == null)
            {
                head = element;
            }
            else
            {
                tail.Next = element;
            }

            tail = element;

            count++;
        }

        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            Element<T> current = head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var elList = new ElementList<string>
            {
                "Alexandr",
                "Oleg"
            };

            foreach (var element in elList)
            {
                Console.WriteLine(element);
            }

            var el = elList["Alexandr"];

            Console.WriteLine(el.Data);

            Console.ReadKey();
        }
    }
}
