using System;
using System.Collections.Generic;
using System.Text;

namespace CorporateClass.Classes
{
    class Employee
    {
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string JobTitle { get; set; }
        public DateTime StartDate { get; set; }

        public Employee(string employeeFirstName, string employeeLastName, string jobTitle, DateTime startDate)
        {
            EmployeeFirstName = employeeFirstName;
            EmployeeLastName = employeeLastName;
            JobTitle = jobTitle;
            StartDate = startDate;

        }
    }
}
