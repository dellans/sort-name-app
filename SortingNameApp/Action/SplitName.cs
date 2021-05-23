using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorter
{
    public class SplitName
    {
        public static NameModel SplittedName(string name)
        {
            NameModel person;
            string[] splitted_name = name.Split(' ');
            if (splitted_name.Length == 1)
            {
                person = new NameModel(name, "", "", splitted_name[0]);
            }
            else if (splitted_name.Length == 2)
            {
                person = new NameModel(name, "", splitted_name[0], splitted_name[1]);
            }
            else
            {
                person = new NameModel(name, splitted_name[0], splitted_name[1], splitted_name[2]);
            }

            return person;
        }
    }
}
