using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson10.HashTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable openWith = new Hashtable();

            // Add some elements to the hash table. There are no
            // duplicate keys, but some of the values are duplicates.
            openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");
            // In (Keys; Values)
            Console.WriteLine("Keys in HashTable");
            foreach (var item in openWith.Keys)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            Console.WriteLine("Key : Value in HashTable");
            foreach (var key in openWith.Keys)
            {
                Console.WriteLine(key + ": " + openWith[key]);
            }
            Console.ReadLine();

            Console.WriteLine(" Value in HashTable");
            foreach (var value in openWith.Values)
            {
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
    }
}
