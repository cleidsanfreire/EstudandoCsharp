using System;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Lucia");
            list.Add("Rosa");
            list.Add("Marta");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            list.Insert(2, "Marcos");

            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List Count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            Console.WriteLine("+-+-+-+-+-+-+-+-++-+-+-+-+-+-+-+-+-+-+");

            List<string> s3 = list.FindAll(x => x.Length > 5);
            foreach (string obj in s3)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("+-+-+-+-+-+-+-+-++-+-+-+-+-+-+-+-+-+-+");

            list.Remove("Bob");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("+-+-+-+-+-+-+-+-++-+-+-+-+-+-+-+-+-+-+");

            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("+-+-+-+-+-+-+-+-++-+-+-+-+-+-+-+-+-+-+");
            list.RemoveAt(1);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("+-+-+-+-+-+-+-+-++-+-+-+-+-+-+-+-+-+-+");
            list.RemoveRange(0, 3);
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}