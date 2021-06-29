using System;
using System.Collections.Generic;

namespace Generic_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee()
            {
                ID = 101,
                Name = "Tipu",
                Gender = "Male",
                Salary = 25000
            };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Mubarak",
                Gender = "Male",
                Salary = 30000
            };
            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Putul",
                Gender = "Female",
                Salary = 40000
            };
            Employee emp4 = new Employee()
            {
                ID = 104,
                Name = "Sambit",
                Gender = "Female",
                Salary = 40000
            };
            Employee emp5 = new Employee()
            {
                ID = 105,
                Name = "Preety",
                Gender = "Female",
                Salary = 50000
            };

            Stack<Employee> stackEmployees = new Stack<Employee>();
            stackEmployees.Push(emp1);
            stackEmployees.Push(emp2);
            stackEmployees.Push(emp3);
            stackEmployees.Push(emp4);
            stackEmployees.Push(emp5);

            Console.WriteLine("--------All employee------");
            foreach (Employee emp in stackEmployees)
            {
                Console.WriteLine(emp.ID + " - " + emp.Name + " - " + emp.Gender + " - " + emp.Salary);
            }
            Console.WriteLine("Employee left in the Stack = " + stackEmployees.Count);

            Console.WriteLine("---------Peek employee---------");
            Employee peekEmployee = stackEmployees.Peek();
            Console.WriteLine(peekEmployee.ID + " - " + peekEmployee.Name + " - " + peekEmployee.Gender + " - " + peekEmployee.Salary);
            Console.WriteLine("Employee left in the Stack = " + stackEmployees.Count);

            Console.WriteLine("---------Pop employee---------");
            Employee popEmployee = stackEmployees.Pop();
            Console.WriteLine(popEmployee.ID + " - " + popEmployee.Name + " - " + popEmployee.Gender + " - " + popEmployee.Salary);
            Console.WriteLine("Employee left in the Stack = " + stackEmployees.Count);
            Console.WriteLine("------------------------------");

            // To check if an item exists in the stack, use Contains() method.
            if (stackEmployees.Contains(emp4))
            {
                Console.WriteLine(emp4.Name + " is in stack");
            }
            else
            {
                Console.WriteLine(emp4.Name + " is not in stack");
            }

            Console.ReadKey();
        }
    }
}
