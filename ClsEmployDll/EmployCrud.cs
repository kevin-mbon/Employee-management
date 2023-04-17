using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

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
                return "RECORD NOT FOUND";
            }
        }
        public StringBuilder Validation(Employ employ)
        {
            StringBuilder sb = new StringBuilder();
            bool flag = true;
            if (employ.Employno <= 1)
            {
                sb.AppendLine("ID MUST GREATER THAN 0");
                flag = false;
            }
            if (employ.Name.Length < 4)
            {
                sb.AppendLine("CHARACTER MUST BE GREATER THAN FOUR");
                flag = false;
            }
            if (employ.Salary < 1000)
            {
                sb.AppendLine("SALARY MUST BE GREATER 1K");
                flag = false;
            }
            else
            {

                if (flag == true)
                {
                    sb.AppendLine("VALIDATION PASS");
                    {
                        employList.Add(employ);
                        sb.AppendLine("EMPLOY ADDED SUCCESSFUL");

                    }

                }
            }

            return sb;
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
                        if (updEmploy.Name.Length < 2)
                        {
                           
                            return "Name must be atleast four characters";
                           
                        }
                        else
                        {
                            employ.Name = updEmploy.Name;
                        
                        }
                         if (updEmploy.Salary < 100)
                        {
                            return "base salary must be 1k";
                        }else { employ.Salary = updEmploy.Salary; }

                    }
                    }
                    return "RECORD UPDATED";
                }
                return "RECORD NOT FOUND****";
            }
            public static Employ SearchEmploy(int employno)
            {
                Employ employ = null;
                foreach (Employ em in employList)
                {
                    if (em.Employno == employno)
                    {
                        employ = em;
                    }
                }
                return employ;
            }

            public List<Employ> Show()
            {

                return employList;
            }
        }
    }
