using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClsEmployDll
{
    public class Employ
    {
        public string Name { get; set; }
        public int Employno { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return "NO " + Employno + " Name " + Name + " Salary " + Salary;
        }
    }
}
