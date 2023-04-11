using System;
using System.Collections;
using System.Collections.Generic;
namespace ClsEmployDll
{
     
    public class EmployCrud
    {
        static List<Employ> employList;
        //static List elist
        static EmployCrud()
        {
            employList = new List<Employ>();
        }
        public string DeleteEmploy(int employno)
        {
            Employ employ = SearchEmploy(employno);
            if (employ != null)
            {
                employList.Remove(employ);
                return "EMPLOY DELETED SUCCEFFULY";
            }
            else
            {
                return"RECORD NOT FOUND";
            }
        }
        public string UpdateEmploy(Employ updEmploy)
        { 
            Employ res = SearchEmploy(updEmploy.Employno);
            if (res != null)
            {


                foreach (Employ employ in employList)
                {
                    if (employ.Employno == updEmploy.Employno)
                    {
                        employ.Name = updEmploy.Name;
                        employ.Salary = updEmploy.Salary;
                    }
                }
                return "RECORD UPDATED";
            }
            return "RECORD NOT FOUND****";
        }
        public static Employ SearchEmploy(int employno)
        {
            Employ employ = null;
            foreach(Employ em in employList)
            {
                if(em.Employno == employno)
                {
                    employ = em; 
                }
            }
            return employ;
        }
        public string AddEmploy(Employ employ)
        {
            employList.Add(employ);
            return "Employ added successfully...";
        }
        public List<Employ> Show()
        {
           
            return employList;
        }
    }
}