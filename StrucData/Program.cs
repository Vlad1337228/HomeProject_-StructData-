using System;

namespace StrucData
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleLinkedList<int> db = new DoubleLinkedList<int>();
            db.Add(1);
            db.Add(2);
            db.Add(1);
            db.Add(2);
            db.Add(1);
            db.Add(2);
            db.Add(3);
            db.Add(5);
            db.Add(7);
            db.Add(23);
            Console.WriteLine(db.Count);

            Console.WriteLine();
            foreach (var item in db)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            db.Remove(23);
            foreach (var item in db)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine(db.Count);
        }
    }
}
