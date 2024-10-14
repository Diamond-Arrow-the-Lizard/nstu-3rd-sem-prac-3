using System;
using System.Collections;

namespace Prac_3 {

    public class Tasks {

        public void TaskCreateCollection(int deleteIndex, int searchVar) {

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

        }



    }


    public class Program {

        public static void Main(string[] args) {

            Tasks Task = new Tasks();

            Task.TaskCreateCollection(2, 5);

        }

    }

}
