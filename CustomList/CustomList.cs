using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomList<T>
    {
        //Member Variables (HAS A)
        private T[] items;
        private int capacity;
        private int count;

        //Constructor
        public CustomList()
        {
            capacity = 4; 
            count = 0;
            CustomList<string> items = new CustomList<string>();
        }

        public T[] Items { get => items; set => items = value; }
        public int Count { get => count; set => count = value; }
        public int Capacity { get => capacity; set => capacity = value; }

        //Member Methods (CAN DO)
        public void Add(T item)     // Items[0] = item
        {

            Items[0] = item;
            string firstItem = "hello";
            string secondItem = "world";
            string thirdItem = "you";
            string fourthItem = "are";
            string fifthItem = "great";


          if (item.Equals(firstItem))
            {
                Items[0] = item;
            }
          else if (item.Equals(secondItem))
            {
                Items[1] = item;
            }
            else if (item.Equals(thirdItem))
            {
                Items[2] = item;
            }
            else if (item.Equals(fourthItem))
            {
                Items[3] = item;
            }
            else if(item.Equals(fifthItem)) // here we may want to create the capacity expander
            {

                Array.Resize(ref items, items.Length * 2);
            }
                   









            //'item' parameter should be added to internal 'items' array
            //if items array is at capacity, double capacity and create new array
            //transfer all items to new array
        }

        public bool Remove(T item)
        {
            //If 'item' exists in the 'items' array, remove its first instance
            //Any items coming after the removed item should be shifted down so there is no empty index.
            //If 'item' was removed, return true. If no item was removed, return false.
            return false;
        }

        public override string ToString()
        {
            //returns a single string that contains all items from array
            return "";
        }

        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> that contains all items from firstList and all items from secondList 
            return null;
        }

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            //returns a single CustomList<T> with all items from firstList, EXCEPT any items that also appear in secondList
            return null;
        }


    }
}
//Test notes to test repo