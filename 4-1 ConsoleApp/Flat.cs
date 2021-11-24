namespace ConsoleApp
{
    
    public class Flat
    {
        
        public int Number {get;set;}
        public string Person {get;set;}
        public int CountPersonLiving {get;set;}
        
        public Flat(int num) {
            Number = num;
        }
        public Flat(int num, string person) {
            Number = num;
            Person = person;
        }
        public Flat(int num, int personLiving) {
            Number = num;
            CountPersonLiving = personLiving;
        }


    }
}