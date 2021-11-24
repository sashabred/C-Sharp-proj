using System.Collections.Generic;

namespace LinqExample
{
    public class User
    {
        public string Name { get; }
        public int Age { get; private set; }
        public bool IsMale { get; }
        
        public User (string name = null, int age = 0, bool isMale = false)
        {
            Name = name;
            Age = age;
            IsMale = isMale;
        }

        public static List<User> GetUsersWithAge(params int[] ages)
        {
            List<User> users = new List<User>();
            foreach (int age in ages)
            {
                users.Add(new User { Age = age });
            }
            return users;
        }
    }
}
