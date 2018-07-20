using System.Collections.Generic;
using System.Collections;


namespace IndeksatorTraining.UI
{
    class ElementList<T> : IEnumerable<T>
    {
        Element<T> head;

        Element<T> tail;

        private int count;

        public int Count => count;

        public Element<T> this[T index]
        {
            get
            {
                return GetElementByData(index);
            }

            set
            {
                InsertElement(value, index);
            }
        }

        private void InsertElement(Element<T> element, T data)
        {
            Element<T> current = head;
            Element<T> previous = null;
            Element<T> tmp = null;

            while(current != null)
            {
                if (current.Data.Equals(data))
                {
                    if(current.Next != null)
                    {
                        tmp = current.Next;

                        current.Next = element;

                        element.Next = tmp;
                    }
                    else
                    {
                        current.Next = element;
                    }
                }

                previous = current;
                current = current.Next;
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

        public bool Remove(T data)
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

                if (previous != null)
                {
                    previous.Next = current.Next;

                    if (current.Next == null)
                    {
                        tail = previous;
                    }
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

                return true;
            }

            return false;
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

        public bool Contains(T data)
        {
            Element<T> current = head;

            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    return true;
                }

                current = current.Next;
            }

            return false;
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
}
