using System;
using System.Linq;
using DelegatesInLINQ.Models;

namespace DelegatesInLINQ
{
    public static class Program
    {
        private static readonly Func<Employee, int, bool> AgeIsGreaterFunc = (employee, i)
            => employee.Age > i;

        private static readonly Func<Employee, double, bool> SalaryIsGreaterFunc = (employee, i)
            => employee.Salary > i;

        private static readonly Predicate<Employee> AgeIsGreaterPredicate = employee => employee.Age > 20;

        private static void Main()
        {
            var employees = new[]
            {
                new Employee("Ivan", "Ivanov", 20, 150.2),
                new Employee("Andrey", "Andreev", 30, 250.2),
                new Employee("Winston", "Cherchill", 40, 320.2),
                new Employee("Arkadiy", "Kulakosvkiy", 50, 420.2),
            };

            var selectAgeFunc = employees.Where(e => AgeIsGreaterFunc(e, 20)).ToList();
            selectAgeFunc.ForEach(e => Console.WriteLine($"{e.Firstname}, {e.Age}"));

            var selectSalaryFunc = employees.Where(e => SalaryIsGreaterFunc(e, 200)).ToList();
            selectSalaryFunc.ForEach(e => Console.WriteLine($"{e.Firstname}, {e.Salary}"));

            var selectAgePredicate = employees.Where(e => AgeIsGreaterPredicate(e)).ToList();
            selectAgePredicate.ForEach(e => Console.WriteLine($"{e.Firstname}, {e.Age}"));
        }
    }
}