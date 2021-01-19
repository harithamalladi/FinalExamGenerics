//Write a generic class that meets the following requirements:
//1)    That constrains a developer to only instantiate the class based on value types
//2)    Contains a private generic collection
//3)    Has a method to add items to the private collection
//4)    Has a method that will return an  item from the list (e.g. item 3 or item 4 in the list)
//5)    Has a method that returns a sorted collection with the items in descending order

using System;
using System.Collections.Generic;
using System.Collections;

namespace FinalExamGenerics
{
 class Program
        {
            static void Main(string[] args)
            {
                GenericClass<string> gs = new GenericClass<string>();
                gs.addElements("abc");
                gs.addElements("xyz");
                gs.addElements("ybu");
            gs.SortElements();

                Console.Write(gs.getElements(2));

                GenericClass<int> gs1 = new GenericClass<int>();
                gs1.addElements(1002);
                gs1.addElements(2004);
                gs1.addElements(5144);
                gs1.addElements(3939);
            gs1.SortElements();

                Console.Write(gs1.getElements(1));

            }
        }

        public class GenericClass<T> : IEnumerable<T>
        {
            private List<T> list = new List<T>();

            public void addElements(T item)
            {
                list.Add(item);
                Console.WriteLine("Added Item:{0}", item);
            }

            public T getElements(int index)
            {
                Console.WriteLine("get elements from list: {0}", index);
                return list[index];

            }

            public IEnumerator<T> GetEnumerator()
            {
                return list.GetEnumerator();
            }

            public void SortElements()
            {
                list.Sort();
                list.Reverse();
                Console.WriteLine("After sorting:");
                foreach (var item in list)
                    Console.WriteLine(item);

            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }