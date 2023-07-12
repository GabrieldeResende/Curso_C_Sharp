using System;
using System.Collections.Generic;

namespace Course {
    class program {
        static void Main(string[] args) {
                
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Gabriel");
            list.Insert(1, "marco");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("list count: " + list.Count);
        }
    }
}