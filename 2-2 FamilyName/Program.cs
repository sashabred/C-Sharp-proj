using System;
using System.Collections.Generic;

namespace FamilyName
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> family = new List<Person>();
            Person per1 = new Person () {
                familyName= "Sandanova"
            };
            family.Add(per1);
    
            family.Sort((x,y)=>x.familyName.CompareTo(y.familyName));

            family.ForEach(i => Console.WriteLine(i));
        }
    }
}
