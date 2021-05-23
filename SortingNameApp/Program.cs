using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace NameSorter
{
    public class Program
    {
        static void Main(string[] args)
        {
            var directory = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string textFile = directory.ToString() + @"\unsorted-names-list.txt";
            string createdTextFile = directory.ToString() + @"\sorted-names-list.txt";

            DisplayInfo.StartingApps();

            string[] sortedName = SortListOfNames(textFile);

            CreateFile.CreateTxtFile(textFile, sortedName);

            DisplayInfo.EndingApps();
        }
        
        public static string[] SortListOfNames(string txtFile)
        {

            // Read a text file line by line.  
            string[] names = File.ReadAllLines(txtFile);

            //Assign every line to a model
            List<NameModel> personList = new List<NameModel>();
            foreach (string name in names)
            {
                NameModel person = SplitName.SplittedName(name);
                personList.Add(person);
            }

            //IEnumerable<NameModel> sortedName = personList.OrderBy(s => s.lastName).ThenBy(s => s.middleName).ThenBy(s => s.firstName);

            //Sorting list of names
            string[] sortedName = new string[names.Length];
            sortedName = SortingName.OrderByLastName(personList);

            return sortedName;
        }
    }
}
