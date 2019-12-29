using System;
using System.Collections;

namespace SortedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sortedList = new SortedList();

            sortedList.Add(3, "Three");
           // sortedList.Add("four", 9); // Throw exception: InvalidOperationException
            sortedList.Add(1, "One");
            sortedList.Add(9, 6);
            sortedList.Add(8, "Five");
            sortedList.Add(2, "Two");
            Console.WriteLine(sortedList[1]);
            Console.WriteLine(sortedList[1].GetType());

            Console.WriteLine();

            foreach (DictionaryEntry kvp in sortedList)
            {
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);
            }
                

            Console.WriteLine();

            SortedList mySortedList = new SortedList()
                            {
                                {"one", 1},
                                {"two", 2},
                                {"three", 3},
                                {"four", "Four"}
                            };
            Console.WriteLine(mySortedList["three"]);
            Console.WriteLine(mySortedList["three"].GetType());

            for (int i = 0; i < mySortedList.Count; i++)
            {
                Console.WriteLine("key: {0}, value: {1}",
                    mySortedList.GetKey(i), mySortedList.GetByIndex(i));
            }

            Console.WriteLine();

            mySortedList.Remove("one");//removes element whose key is 'one'
            mySortedList.RemoveAt(0);//removes element at zero index i.e first element: four

            foreach (DictionaryEntry kvp in mySortedList)
                Console.WriteLine("key: {0}, value: {1}", kvp.Key, kvp.Value);

            Console.WriteLine();

            SortedList aSortedList = new SortedList()
            {
                                { 3, "Three"},
                                { 4, "Four"},
                                { 1, "One"},
                                { 8, "Eight"},
                                { 2, "Two"}
            };

            Console.WriteLine(aSortedList.Contains(2)); // returns true
            Console.WriteLine(aSortedList.Contains(4)); ; // returns true
            Console.WriteLine(aSortedList.Contains(6)); ; // returns false
            Console.WriteLine(aSortedList.ContainsKey(2)); // returns true
            Console.WriteLine(aSortedList.ContainsKey(6)); // returns false
            Console.WriteLine(aSortedList.ContainsValue("One")); // returns true
            Console.WriteLine(aSortedList.ContainsValue("2")); // returns false
        }
    }
}
