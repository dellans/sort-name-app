using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorter
{
    public class SortingName
    {
        public static string[] OrderByLastName(List<NameModel> names)
        {
            string[] lastnames = new string[names.Count];
            string[] fullnames = new string[names.Count];
            int x = 0;
            foreach (var item in names) {
                lastnames[x] = item.lastName.ToString().ToLower();
                fullnames[x] = item.fullName.ToString();
                x++;
            }

            int min = 0;
            string name;
            string fullname;
            for (int i = 0; i < lastnames.Length - 1; i++)
            {
                for (int j = i + 1; j < lastnames.Length; j++)
                {
                    if (lastnames[i].Length < lastnames[j].Length)
                        min = lastnames[i].Length;
                    else
                        min = lastnames[j].Length;
                    for (int k = 0; k < min; k++)
                    {
                        if (lastnames[i][k] > lastnames[j][k])
                        {
                            name = lastnames[i];
                            fullname = fullnames[i];
                            lastnames[i] = lastnames[j];
                            fullnames[i] = fullnames[j];
                            lastnames[j] = name;
                            fullnames[j] = fullname;
                            break;
                        }
                        else if (lastnames[i][k] == lastnames[j][k])
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }

                    }
                }
            }

            return fullnames;
        }
    }
}
