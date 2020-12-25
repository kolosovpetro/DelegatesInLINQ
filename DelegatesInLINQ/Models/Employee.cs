namespace DelegatesInLINQ.Models
{
    public class Employee
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public Employee(string firstname, string lastname, int age, double salary)
        {
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
            Salary = salary;
        }

        public Employee()
        {
        }
    }
}