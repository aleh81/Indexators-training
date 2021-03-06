﻿using System.Collections.Generic;
using System.Collections;
using System;


namespace IndeksatorTraining.UI
{
    class ElementList<TKey, TValue> : IEnumerable<TKey>
    {
        Element<TKey, TValue> head;

        Element<TKey, TValue> tail;

        private int count;

        public int Count => count;

        public Element<TKey, TValue> this[TKey index]
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

        private void InsertElement(Element<TKey, TValue> element, TKey key)
        {
            Element<TKey, TValue> current = head;
            Element<TKey, TValue> previous = null;
            Element<TKey, TValue> next = null;

            while (current != null)
            {
                if (current.Key.Equals(key))
                {
                    if (current.Next != null)
                    {
                        next = current.Next;
                        current.Next = element;
                        element.Next = next;
                    }
                    else
                    {
                        current.Next = element;
                    }

                    count++;
                }

                previous = current;
                current = current.Next;
            }
        }

        private Element<TKey, TValue> GetElementByData(TKey key)
        {
            var current = head;

            while (current != null)
            {
                if (current.Key.Equals(key))
                {
                    return current;
                }

                current = current.Next;
            }

            return null;
        }

        public bool Remove(TKey key)
        {
            Element<TKey, TValue> current = head;
            Element<TKey, TValue> previous = null;

            while (current != null)
            {
                if (!current.Value.Equals(key))
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

        public void Add(TKey key, TValue data)
        {
            var element = new Element<TKey, TValue>(key, data);

            if (ContainsKey(key))
            {
                throw new ArgumentException("ERROR: The key is contains in list");
            }

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
        //
        public bool ContainsKey(TKey key)
        {
            var current = head;

            while (current != null)
            {
                if (current.Key.GetHashCode() == key.GetHashCode())
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

        IEnumerator<TKey> IEnumerable<TKey>.GetEnumerator()
        {
            Element<TKey, TValue> current = head;

            while (current != null)
            {
                yield return current.Key;

                current = current.Next;
            }
        }
    }
}
