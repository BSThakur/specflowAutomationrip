using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowFraework
{
    public class EmployeeDetails
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Int64 Phone { get; set; }
        public string Email { get; set; }

        public int Add(int a)
        {
            return a;
            //#return FirstNumber + SecondNumber;
        }
    }
}