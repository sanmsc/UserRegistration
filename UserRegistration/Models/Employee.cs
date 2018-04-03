using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserRegistration.Models
{
    public class Employee
            {

        public int EmployeeId { get; set; }

        public String Name { get; set; }


        public String Mail { get; set; }


        public String Dept { get; set; }


        public DateTime StartDate { get; set; }
        
    }

    class EmployeeRepository
    {
        private static List<Employee> employee = new List<Employee>()
        {
        new Employee{EmployeeId=1 , Name= "A",  Mail="a@example.com" , Dept="ITD" , StartDate=DateTime.Today   },
        new Employee{EmployeeId=2 , Name= "B",  Mail="b@example.com" , Dept="IS" , StartDate=DateTime.Today   },
        new Employee{EmployeeId=3 , Name= "C",  Mail="c@example.com" , Dept="IST" , StartDate=DateTime.Today   }
        };
       public List<Employee> GetAll()
        {

            return employee;
        }
    }

}