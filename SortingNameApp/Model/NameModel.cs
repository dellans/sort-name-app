using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorter
{
    public class NameModel
    {
        public string fullName { get; set; }
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public NameModel(string name, string fname, string mname, string lname)
        {
            fullName = name;
            firstName = fname;
            middleName = mname;
            lastName = lname;
        }
    }
}
