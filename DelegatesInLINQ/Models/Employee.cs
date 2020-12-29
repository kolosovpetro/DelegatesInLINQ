namespace DelegatesInLINQ.Models
{
    public class Employee
    {
        public string Firstname { get; }
        public string Lastname { get; }
        public int Age { get; }
        public double Salary { get; }

        public Employee(string firstname, string lastname, int age, double salary)
        {
            Firstname = firstname;
            Lastname = lastname;
            Age = age;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"Name: {Firstname}, Firstname: {Lastname}, Age: {Age}, Salary {Salary}";
        }
    }
}