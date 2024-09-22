namespace EmployeeManagementSystem.Models
{
    public class Employee: EmplyeeActivity 
    {
        public int Id { get; set; }

        public int EmpNo { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Fullname => $"{FirstName} {MiddleName} {LastName}";

        public int PhoneNumber {  get; set; }
        
        public string EmailAdress { get; set; }

        public string Country { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }

        public string Department { get; set; }

        public string Designation { get; set; }
    }
}
