using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinqExample;
using System.Collections.Generic;

namespace UnitTestLinq
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShouldMapStringsToUppercase()
        {
            List<string> input = new List<string> { "This", "is", "Linq", "example" };
            List<string> result = Program.MapToUpperCase(input);

            Assert.AreEqual(4, result.Count);
            bool expected = result.Contains("LINQ");
            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void ShouldReturnSquareRoot()
        {
            List<int> numbers = new List<int> { 1, 4, 16, 256 };
            List<int> squares = Program.ReturnSquareRoot(numbers);

            List<int> expected = new List<int> { 1, 2, 4, 16 };
            Assert.AreEqual(expected[0], squares[0]);
            Assert.AreEqual(expected[3], squares[3]);
        }

        [TestMethod]
        public void ShouldReturnAgeFromUser()
        {
            List<User> users = User.GetUsersWithAge(18, 20);
            List<int> ageFromUsers = Program.GetAgeFromUsers(users);

            List<int> expected = new List<int> { 18, 20 };
            Assert.AreEqual(expected[0], ageFromUsers[0]);
            Assert.AreEqual(expected[1], ageFromUsers[1]);
        }

        [TestMethod]
        public void ShouldReturnFirstTwo()
        {
            List<User> users = User.GetUsersWithAge(18, 20, 21, 22, 23);
            users = Program.GetLimitedUserList(users, 2);

            Assert.AreEqual(2, users.Count);
            List<User> expected = User.GetUsersWithAge(18, 20);
            Assert.AreEqual(expected[0].Age, users[0].Age);
            Assert.AreEqual(expected[1].Age, users[1].Age);
        }

        [TestMethod]
        public void ShouldReturnNumberOfUsersOlderThen25()
        {
            List<User> users = User.GetUsersWithAge(18, 20, 21, 22, 23, 24, 25, 26);
            int count = Program.CountUsersOlderThen25(users);

            Assert.AreEqual(1, count);            
        }

        [TestMethod]
        public void ShouldReturnDistinctAges()
        {
            List<User> users = User.GetUsersWithAge(18, 20, 20, 21, 22, 22, 23, 24, 25, 26);
            List<int> distinctAges = Program.GetDistinctAges(users);

            List<int> expected = new List<int> { 18, 20, 21, 22, 23, 24, 25, 26 };
            Assert.AreEqual(8, distinctAges.Count);
            Assert.AreEqual(expected[0], distinctAges[0]);
            Assert.AreEqual(expected[7], distinctAges[7]);
        }

        [TestMethod]
        public void ShouldSumIntegersInCollection()
        {
            List<int> integers = new List<int> { 1, 2, 3, 4, 5 };
            int result = Program.Sum(integers);

            int expected = 1 + 2 + 3 + 4 + 5;
            Assert.AreEqual(expected, result);            
        }

        [TestMethod]
        public void ShouldSkipInCollection()
        {
            List<int> integers = new List<int> { 1, 2, 3, 4, 5 };
            List<int> result = Program.Skip(integers, 2);

            List<int> expected = new List<int> { 3, 4, 5 };
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(expected[0], result[0]);
            Assert.AreEqual(expected[1], result[1]);
            Assert.AreEqual(expected[2], result[2]);
        }

        [TestMethod]
        public void ShouldReturnFirstNames()
        {
            List<string> names = new List<string> { "Richard Plantagenet", "Elizabeth Tudor", "James Stuart", "George Windsor"};
            List<string> result = Program.GetFirstNames(names);

            List<string> expected = new List<string> { "Richard", "Elizabeth", "James", "George" };
            Assert.AreEqual(4, result.Count);
            Assert.AreEqual(expected[0], result[0]);
            Assert.AreEqual(expected[3], result[3]);
        }

        [TestMethod]
        public void ShouldReturnDistinctLetters()
        {
            List<string> names = new List<string> { "Richard", "Elizabeth", "James", "George" };
            List<string> result = Program.GetDistinctLetters(names);

            List<string> expected = new List<string> { "R", "i", "c", "h", "a", "r", "d", "E", "l", "z", "b", "e", "t", "J", "m", "s", "G", "o", "g" };
            Assert.AreEqual(19, result.Count);
            Assert.AreEqual(expected[0], result[0]);
            Assert.AreEqual(expected[18], result[18]);
        }

        [TestMethod]
        public void ShouldSeparateNamesByComma()
        {
            List<User> users = new List<User> { new User("Richard"), new User("Elizabeth"), new User("James") };
            string result = Program.SeparateNamesByComma(users);
                       
            Assert.AreEqual("Richard, Elizabeth, James", result);
        }

        [TestMethod]
        public void ShouldPerformCalculations()
        {
            List<User> users = User.GetUsersWithAge(10, 20, 30);
            int max = Program.GetMaxAge(users);
            int min = Program.GetMinAge(users);
            double average = Program.GetAverageAge(users);

            Assert.AreEqual(10, min);
            Assert.AreEqual(30, max);
            Assert.AreEqual((10+20+30)/3.0, average);
        }

        public List<User> PrepareUsers()
        {
            User rick = new User("Richard", 42, true);
            User beth = new User("Elizabeth", 70, false);
            User james = new User("James", 57, true);
            User george = new User("George", 57, true);
            return new List<User> { rick, beth, james, george };
        }

        [TestMethod]
        public void ShouldPartitionByGender()
        {            
            List<User> input = PrepareUsers();
            Dictionary<bool, List<User>> result = Program.PartionUsersByGender(input);

            Assert.AreEqual(3, result[true].Count);
            Assert.AreEqual("Richard", result[true][0].Name);
            Assert.AreEqual("Elizabeth", result[false][0].Name);
        }

        [TestMethod]
        public void ShouldGroupByAge()
        {
            List<User> input = PrepareUsers();
            Dictionary<int, List<User>> result = Program.GroupByAge(input);

            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(2, result[57].Count);
            Assert.AreEqual("Elizabeth", result[70][0].Name);
            Assert.AreEqual("George", result[57][1].Name);
        }

        [TestMethod]
        public void ShouldCountGender()
        {
            List<User> input = PrepareUsers();
            Dictionary<bool, int> result = Program.CountGender(input);

            Assert.AreEqual(3, result[true]);
            Assert.AreEqual(1, result[false]);            
        }

        [TestMethod]
        public void ShouldMatchAge()
        {
            List<User> users = User.GetUsersWithAge(10, 20, 30);
            bool expected = Program.AnyMatch(users, 10);

            Assert.IsTrue(expected);            
        }

        [TestMethod]
        public void ShouldNoneMatchAge()
        {
            List<User> users = User.GetUsersWithAge(10, 20, 30);
            bool expected = Program.NoneMatch(users, 40);

            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void ShouldFindAnyUser()
        {            
            List<User> users = PrepareUsers();
            User user = Program.FindAny(users, "James");

            Assert.IsNotNull(user);
            Assert.AreEqual("James", user.Name);
        }

        [TestMethod]
        public void ShouldSortByAge()
        {
            List<User> users = PrepareUsers();
            List <User> sorted = Program.SortByAge(users);

            Assert.IsTrue(sorted.Count == 4);
            Assert.AreEqual("Richard", sorted[0].Name);
            Assert.AreEqual("Elizabeth", sorted[3].Name);
        }

        [TestMethod]
        public void ShouldFindOldest()
        {
            List<User> users = PrepareUsers();
            User oldest = Program.FindOldest(users);
                        
            Assert.AreEqual("Elizabeth", oldest.Name);
        }

        [TestMethod]
        public void ShouldSumAgeAsInt()
        {
            List<User> users = PrepareUsers();
            int sumAge = Program.SumAge(users);

            Assert.AreEqual(226, sumAge);
        }

        [TestMethod]
        public void ShouldGenerateFirstPrimeNumbers()
        {
            List<int> primeNumbers = Program.GenerateFirst10PrimeNumbers();

            Assert.IsTrue(primeNumbers.Count == 10);
            Assert.AreEqual(2, primeNumbers[0]);
            Assert.AreEqual(29, primeNumbers[9]);
        }

        [TestMethod]
        public void ShouldGenerate10RandomNumbers()
        {
            List<int> randomNumbers = Program.Generate10RandomNumbers();

            Assert.IsTrue(randomNumbers.Count == 10);            
        }
    }
}
