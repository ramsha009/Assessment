namespace NameSorter.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestNameSorting()
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


            var sortedNames = unsortedNames
                .OrderBy(name => name.Split().Last())
                .ThenBy(name => string.Join(" ", name.Split().TakeWhile(part => part != name.Split().Last())))
                .ToArray();


            Assert.Equal(expectedSortedNames, sortedNames);
        }
    }
}
