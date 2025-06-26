using System;
using System.Collections.Generic;
using System.Globalization;

namespace ListExercicies
{
    internal class Employees
    {
        public int Id { get; private set; }
        public string Name { get; set; }

        public double Salary { get; private set; }

        public Employees(int id, string name, double salario)
        {
            Id = id;
            Name = name;
            Salary = salario;
        }
        
        public void IncreaseSalary(double percentage)
        {
            Salary += Salary * percentage / 100;
        }  

        public override string ToString()
        {
            return $"{Id}, {Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
