using System;
using Xunit;

namespace NameSorterTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            string[] expected = new string[]{
                                               "Hailey Avie Annakin",
                                               "Erna Dorey Battelle",
                                               "Selle Bellison",
                                               "Flori Chaunce Franzel",
                                               "Orson Milka Iddins",
                                               "Odetta Sue Kaspar",
                                               "Roy Ketti Kopfen",
                                               "Madel Bordie Mapplebeck",
                                               "Debra Micheli",
                                               "Leonerd Adda Mitchell Monaghan"
                                   };

            //Actual
            var directory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            string textFile = directory.ToString() + @"\unsorted-names-list.txt";
            string[] actual = NameSorter.Program.SortListOfNames(textFile);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
