using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorter
{
    public class DisplayInfo
    {
        public static void StartingApps() {
            Console.WriteLine("Sorted List Name : \n");
        }

        public static void WritingNames(string name)
        {
            Console.WriteLine(name);
        }

        public static void EndingApps()
        {
            Console.WriteLine("\n Press any key to end application...");
            Console.ReadLine();
        }
    }
}
