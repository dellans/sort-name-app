using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace NameSorter
{
    public class CreateFile
    {
        public static void CreateTxtFile(string txtPath, string[] stringToWrite)
        {
            if (File.Exists(txtPath))
            {
                File.Delete(txtPath);
            }

            // Create a new file     
            using (StreamWriter sw = File.CreateText(txtPath))
            {
                foreach (var line in stringToWrite)
                {
                    sw.WriteLine(line.ToString());
                    DisplayInfo.WritingNames(line.ToString());
                }
            }
        }
    }
}
