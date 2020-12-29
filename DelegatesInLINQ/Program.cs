using System;
using System.Linq;
using DelegatesInLINQ.Extensions;
using DelegatesInLINQ.Models;

namespace DelegatesInLINQ
{
    public static class Program
    {
        private static readonly Func<Employee, int, bool> Func1 = (employee, i)
            => employee.Age > i;

        private static readonly Func<Employee, double, bool> Func2 = (employee, i)
            => employee.Salary > i;

        private static readonly Predicate<Employee> P1 = employee => employee.Age > 22;
        private static readonly Predicate<Employee> P2 = employee => employee.Salary > 120;
        private static readonly Predicate<Employee> P3 = employee => employee.Firstname.Contains("Name");

        private static void Main()
        {
            var employees = new[]
            {
                new Employee("Name 0", "Surname 0", 20, 100),
                new Employee("Name 1", "Surname 1", 21, 110),
                new Employee("Name 2", "Surname 2", 22, 120),
                new Employee("Name 3", "Surname 3", 23, 130),
                new Employee("Name 4", "Surname 4", 24, 140),
                new Employee("Name 5", "Surname 5", 25, 150),
                new Employee("Name 6", "Surname 6", 26, 160),
            };

            Console.WriteLine("Age greater than 30: ");
            var selectAgeFunc = employees.Where(e => Func1(e, 20)).ToList();
            selectAgeFunc.ForEach(Console.WriteLine);

            Console.WriteLine("\nSalary greater than 200: ");
            var selectSalaryFunc = employees.Where(e => Func2(e, 200)).ToList();
            selectSalaryFunc.ForEach(Console.WriteLine);

            Console.WriteLine("\nAge grater than 20 predicate: ");
            var selectAgePredicate = employees.Where(e => P1(e)).ToList();
            selectAgePredicate.ForEach(Console.WriteLine);

            Console.WriteLine("\nEnumerable AND: ");
            var enumerableAnd = employees.PredicatesAnd(P1, P2, P3).ToList();
            enumerableAnd.ForEach(Console.WriteLine);
            
            Console.WriteLine("\nEnumerable OR: ");
            var enumerableOr = employees.PredicatesOr(P1, P2, P3).ToList();
            enumerableOr.ForEach(Console.WriteLine);
        }
    }
}