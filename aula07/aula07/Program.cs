using System;


namespace Course {
    class Program {
        static void Main(string[] args) {
            string original = "abc ABC def DEF    ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();

            Console.WriteLine("original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
        }
    }
}