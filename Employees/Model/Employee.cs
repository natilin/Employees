using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Model
{
    internal class Employee
    {
        public Employee(string tz, string idNumber, string firstName, string lastName, Gender gender, StatusFamily statusFamily, Address address, DateTime dateOfBirth)
        {
            Tz = tz;
            IdNumber = idNumber;
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            StatusFamily = statusFamily;
            Address = address;
            DateOfBirth = dateOfBirth;
        }
        public string Tz {  get; set; }
        public string IdNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public StatusFamily StatusFamily { get; set; }
        public Address Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get { return DateTime.Now.Year - DateOfBirth.Year; } }

    }
    internal class Address
    {
            public Address(int stNumber, string street, string city)
            {
                StNumber = stNumber;
                Street = street;
                City = city;
            }

            public int StNumber {  get; set; }
            public string Street { get; set; }
            public string City { get; set; }    
            
    }

    
}
