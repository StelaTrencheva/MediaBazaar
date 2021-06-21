﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

using ProjectClasses.LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses.LogicLayer.Tests
{
    [TestClass()]
    public class WeekScheduleTests
    {
        private List<Shift> shifts = new List<Shift>();
        private int employeeIdCounter = 1;

        [TestMethod()]
        public void GenerateWeekSchedule()
        {
            for (DateTime i = new DateTime(2021, 5, 31); i <= new DateTime(2021, 6, 6); i = i.AddDays(1))
            {
                for (int j = 0; j < 4; j++)
                {
                    shifts.Add(new Shift((ShiftType)j, i, new List<Employee>()));
                }
            }

            DBMediatorShifts dBMediator = new DbMediatorShiftsTest(
                CreateFulltimeEmployees(0)
                .Concat(
                    CreateEightyPercentEmployees(0)    
                )
                .Concat(
                     CreateFlexEmployees(20)
                ).ToList()
            );

            WeekSchedule ws = new WeekSchedule(new DateTime(2021,6,1), new Department(2678,"test"), dBMediator);

            Assert.Fail();
        }

        private List<EmployeeInSchedule> CreateFulltimeEmployees(int count)
        {
            return CreateEmployees(count, ContractType.FULLTIME);
        }

        private List<EmployeeInSchedule> CreateEightyPercentEmployees(int count)
        {
            return CreateEmployees(count, ContractType.EIGHTYPERCENT);
        }

        private List<EmployeeInSchedule> CreateFlexEmployees(int count)
        {
            return CreateEmployees(count, ContractType.FLEX);
        }

        private List<EmployeeInSchedule> CreateEmployees(int count, ContractType contract)
        {
            List<EmployeeInSchedule> employees = new List<EmployeeInSchedule>();
            for (int i = 0; i < count; i++)
            {
                EmployeeInSchedule employee = new EmployeeInSchedule(CreateEmployee(contract));
                AddShiftsToEmployee(employee);
                employees.Add(employee);
            }

            return employees;
        }

        private void AddShiftsToEmployee(EmployeeInSchedule employee)
        {
            foreach (Shift shift in shifts)
            {
                employee.AddAvailability(shift);
            }
        }

        private Employee CreateEmployee(ContractType contract)
        {
            return new Employee(this.employeeIdCounter++, "1", "1", "1", Gender.MALE, "11", "1", new DateTime(), "1", "1", "1", "1", "1", new DateTime(), "1", "1", 1, new DateTime(), contract, EmployeeType.STORE_WORKER);
        }
    }

    class DbMediatorShiftsTest : DBMediatorShifts
    {
        private List<EmployeeInSchedule> employeeInSchedules;

        public DbMediatorShiftsTest(List<EmployeeInSchedule> employeeInSchedules)
        {
            this.employeeInSchedules = employeeInSchedules;
        }

        public override List<EmployeeInSchedule> GetEmployeesAvailabilityPerDepartmentAndWeekNumber(Department department, int week)
        {
            return employeeInSchedules;
        }
    }
}