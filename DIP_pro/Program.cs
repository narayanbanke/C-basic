﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_pro
{
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
    }

    public class EmployeeBusinessLogic
    {
        EmployeeDataAccess _EmployeeDataAccess;
        public EmployeeBusinessLogic()
        {
            _EmployeeDataAccess = DataAccessFactory.GetEmployeeDataAccessObj();
        }
        public Employee GetEmployeeDetails(int id)
        {
            return _EmployeeDataAccess.GetEmployeeDetails(id);
        }
    }
    public class DataAccessFactory
    {
        public static EmployeeDataAccess GetEmployeeDataAccessObj()
        {
            return new EmployeeDataAccess();
        }
    }
    public class EmployeeDataAccess
    {
        public Employee GetEmployeeDetails(int id)
        {
            // In real time get the employee details from db
            //but here we are hard coded the employee details
            Employee emp = new Employee()
            {
                ID = id,
                Name = "Pranaya",
                Department = "IT",
                Salary = 10000
            };
            return emp;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {//<class name> <userdefined name> = new <class name>();}
            EmployeeBusinessLogic EmployeeBusinessLogic = new EmployeeBusinessLogic();
            Employee Employee= EmployeeBusinessLogic.GetEmployeeDetails(1);

            System.Console.WriteLine("ID" + Employee.ID);
            System.Console.WriteLine("Name" + Employee.Name);
            System.Console.WriteLine("Department" + Employee.Department);
            System.Console.WriteLine("Salary" + Employee.Salary);
            System.Console.ReadLine();
        }
    }
}