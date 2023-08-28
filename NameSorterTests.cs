using System;
using System.Linq;
using Xunit;

namespace NameSorter.Tests
{
    public class NameSortingTests
    {
        [Fact]
        public void TestSortingNames()
        {
            // Arranging
            string[] unsortedNames = new string[]
            {
                "Janet Parsons",
                "Vaughn Lewis",
                "Adonis Julius Archer",
                "Shelby Nathan Yoder",
                "Marin Alvarez",
                "London Lindsey",
                "Beau Tristan Bentley",
                "Leo Gardner",
                "Hunter Uriah Mathew Clarke",
                "Mikayla Lopez",
                "Frankie Conner Ritter"
            };

            string[] expectedSortedNames = new string[]
            {
                "Marin Alvarez",
                "Adonis Julius Archer",
                "Beau Tristan Bentley",
                "Hunter Uriah Mathew Clarke",
                "Leo Gardner",
                "Vaughn Lewis",
                "London Lindsey",
                "Mikayla Lopez",
                "Janet Parsons",
                "Frankie Conner Ritter",
                "Shelby Nathan Yoder"
            };


            var sortedNames = SortNames(unsortedNames); // Replace with your actual sorting method


            Assert.Equal(expectedSortedNames, sortedNames);
        }


        private string[] SortNames(string[] names)
        {

            return names.OrderBy(name => name.Split().Last())
                        .ThenBy(name => string.Join(" ", name.Split().TakeWhile(part => part != name.Split().Last())))
                        .ToArray();
        }
    }
}
