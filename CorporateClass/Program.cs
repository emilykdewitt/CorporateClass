using CorporateClass.Classes;
using System;

namespace CorporateClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var companyName = "Waffle House";
            var companyCreatedOn = "8/2/2014";
            DateTime companyCreationDate = Convert.ToDateTime(companyCreatedOn);

            Console.WriteLine("Enter your first name.");
            var firstNameInput = Console.ReadLine();

            Console.WriteLine("Enter your last name.");
            var lastNameInput = Console.ReadLine();

            Console.WriteLine("Enter your job title.");
            var jobTitleInput = Console.ReadLine();

            var myCompany = new Company(companyName, companyCreationDate);
            myCompany.AddEmployee(firstNameInput, lastNameInput, jobTitleInput);

            Console.WriteLine("Enter your first name");
            var firstNameInput2 = Console.ReadLine();

            Console.WriteLine("Enter your last name");
            var lastNameInput2 = Console.ReadLine();

            Console.WriteLine("Enter your job title");
            var jobTitleInput2 = Console.ReadLine();

            myCompany.AddEmployee(firstNameInput2, lastNameInput2, jobTitleInput2);

            Console.WriteLine("Enter your first name");
            var firstNameInput3 = Console.ReadLine();

            Console.WriteLine("Enter your last name");
            var lastNameInput3 = Console.ReadLine();

            Console.WriteLine("Enter your job title");
            var jobTitleInput3 = Console.ReadLine();

            myCompany.AddEmployee(firstNameInput3, lastNameInput3, jobTitleInput3);

            myCompany.showCurrentEmployees();
            Console.WriteLine("Enter the index of the employee you'd like to remove.");
            var numOfEmployeeToRemove = Console.ReadLine();
            var intOfEmployeeToRemove = Int32.Parse(numOfEmployeeToRemove);

            myCompany.RemoveEmployee(intOfEmployeeToRemove);

            myCompany.showCurrentEmployees();

        }
    }
}
