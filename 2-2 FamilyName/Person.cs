
using System.Collections.Generic;

namespace FamilyName
{
    public class Person:IComparer<Person>
    {
        public  string Fam {get;set;}

        public int Compare(Person x, Person y)
        {
            return x.Fam.CompareTo(y.Fam);
        }
        
    }
}