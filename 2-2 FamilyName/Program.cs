using System;
using System.Collections.Generic;

namespace FamilyName
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<Person> familyNames = new SortedSet<Person> ();
           
            familyNames.Add(new Person{Fam ="Sandanova"});
            familyNames.Add(new Person{Fam ="Tsidipova"});
            familyNames.Add(new Person{Fam ="Yan"});
            familyNames.Add(new Person{Fam ="Aru"});

            
            familyNames.ForEach(i => Console.WriteLine(i));
    
           
        }
    }
}
