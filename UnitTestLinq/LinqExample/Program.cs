using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExample
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public static List<int> ReturnSquareRoot(List<int> numbers)
        {
          List<int> result = new List<int>();
          foreach(int num in numbers)
          {
            numbers.Add((int)Math.Sqrt(num));
          }
          return result;
        }

        public static List<int> GetAgeFromUsers(List<User> users)
        {
            return null;
        }

        public static List<int> GetDistinctAges(List<User> users)
        {
            return null;
    }

        public static List<User> GetLimitedUserList(List<User> users, int limit)
        {
          return null;
        }

        public static int CountUsersOlderThen25(List<User> users)
        {
          return 0;
        }

        public static List<string> MapToUpperCase(List<string> strings)
        {
          return null;
        }

        public static int Sum(List<int> integers)
        {
          return 0;
        }

        public static List<int> Skip(List<int> integers, int toSkip)
        {
          return null;
        }

        public static List<string> GetFirstNames(List<string> names)
        {
          return null;
        }

        public static List<string> GetDistinctLetters(List<string> names)
        {
          return null;
        }

        public static string SeparateNamesByComma(List<User> users)
        {
          return null;
        }

        public static double GetAverageAge(List<User> users)
        {
          return 0;
        }

        public static int GetMaxAge(List<User> users)
        {
          return 0;
        }

        public static int GetMinAge(List<User> users)
        {
          return 0;
        }

        public static Dictionary<bool, List<User>> PartionUsersByGender(List<User> users)
        {
          return null;
        }

        public static Dictionary<int, List<User>> GroupByAge(List<User> users)
        {
          return null;
        }

        public static Dictionary<bool, int> CountGender(List<User> users)
        {
          return null;
        }

        public static bool AnyMatch(List<User> users, int age)
        {
          return false;
        }

        public static bool NoneMatch(List<User> users, int age)
        {
          return false;
        }

        public static User FindAny(List<User> users, string name)
        {
          return null;
        }

        public static List<User> SortByAge(List<User> users)
        {
          return null;
        }

        public static List<int> GenerateFirst10PrimeNumbers()
        {
          return null;
        }

        public static bool IsPrime(int number)
        {
            for (int i = 2; i <= Math.Sqrt(number)+double.Epsilon; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public static List<int> Generate10RandomNumbers()
        {
            var rnd = new Random();
            return null;
        }

        public static User FindOldest(List<User> users)
        {
          return null;
        }

        public static int SumAge(List<User> users)
        {
            return 0;
        }

    }
}
