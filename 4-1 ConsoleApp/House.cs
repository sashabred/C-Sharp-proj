using System;
using System.Collections.Generic;

namespace ConsoleApp
{
        [Serializable]
        public class House
    {   
        public string Street {get;set;}
        public int Number {get;set;}
         
         [NonSerialized]
         public List<Flat> FlatsList = new List<Flat>();
       
         public void AddFlat(Flat flat) {
            FlatsList.Add(flat);           
        }

        public void DeleteFlat(Flat flat) {
            FlatsList.Remove(flat);
        }
        public void RemoveAllFlats() {
            FlatsList.Clear();
        }     

      
    }
}