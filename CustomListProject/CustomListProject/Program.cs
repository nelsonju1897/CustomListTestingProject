﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> myList = new CustomList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Remove(3);


            //CustomList<int> myList = new CustomList<int>();
            //myList.Add(1);
            //Console.WriteLine(myList.Capacity);
            //Console.WriteLine(myList.Count);
            //myList.Add(2);
            //Console.WriteLine(myList.Capacity);
            //Console.WriteLine(myList.Count);
            //myList.Add(3);
            //Console.WriteLine(myList.Capacity);
            //Console.WriteLine(myList.Count);
            //myList.Add(4);
            //Console.WriteLine(myList.Capacity);
            //Console.WriteLine(myList.Count);
            //myList.Add(5);
            //Console.WriteLine(myList.Capacity);
            //Console.WriteLine(myList.Count);
            //myList.Add(6);
            //Console.WriteLine(myList.Capacity);
            //Console.WriteLine(myList.Count);
            //myList.Add(7);
            //Console.WriteLine(myList.Capacity);
            //Console.WriteLine(myList.Count);
            //myList.Add(8);


            Console.WriteLine(myList.Capacity);
            Console.WriteLine(myList.Count);
            //Console.WriteLine(myList[3]);
            //Console.WriteLine(myList[7]);
            Console.ReadLine();


        }
    }
}
