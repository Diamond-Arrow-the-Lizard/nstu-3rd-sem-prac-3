using System;
using System.Collections;
using System.Collections.Generic;

namespace Prac_3 {

    public class Tasks {

        public void TaskCreateUnsortedCollection(int deleteIndex, int searchVar) {

            Random rnd = new Random();
            ArrayList Heap = new ArrayList();

            Heap.Add(rnd.Next(1, 10));
            Heap.Add(rnd.Next(1, 10));
            Heap.Add(rnd.Next(1, 10));
            Heap.Add(rnd.Next(1, 10));
            Heap.Add(rnd.Next(1, 10));

            Heap.Add("Vasya");

            foreach (var i in Heap)
            {
                Console.Write(i + " ") ;
            }
            Console.WriteLine("\n ArrayList has " + Heap.Count + " elements");

            Heap.Remove(deleteIndex);

            bool found = false;
            foreach(var item in Heap) {

                if (Convert.ToString(searchVar).Equals(Convert.ToString(item)))
                {
                    found = true;
                    Console.WriteLine("Found at index " + Heap.IndexOf(item));
                    break;
                }
                
            }

            if(found == false)
                Console.WriteLine("Searched variable is absent");

            Console.WriteLine("\n");
        }

        public void TaskCreateSortedCollection(int deleteAmount) {
            
            Stack<char> Letters = new Stack<char>();

            char x = 'a';
            for(int i = 0; i < 10; i++) {
                x = (char)(Convert.ToUInt16(x) + 1);
                Letters.Push(x);

            }

            foreach(var i in Letters)
                Console.Write(i + " ");
            Console.WriteLine("\n");

            while(deleteAmount != 0) {
                Letters.Pop();
                --deleteAmount;
            }

            foreach(var i in Letters)
                Console.Write(i + " ");
            Console.WriteLine("\n");

            // TODO rest of the Task 2, and the other stuff

        }


    }


    public class Program {

        public static void Main(string[] args) {

            Tasks Task = new Tasks();

            Task.TaskCreateUnsortedCollection(2, 5);
            Task.TaskCreateSortedCollection(3);

        }

    }

}
