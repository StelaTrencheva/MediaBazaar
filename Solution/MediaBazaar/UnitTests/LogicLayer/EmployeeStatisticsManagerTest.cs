using Microsoft.VisualStudio.TestTools.UnitTesting;

using ProjectClasses.LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectClasses;

namespace UnitTests.LogicLayer.Tests
{
    [TestClass()]
    public class EmployeeStatisticsManagerTest
    {
        EmpStatisticManager employeeStatsManager;

        [TestMethod()]
        public void GetListOfAllEmployeesTest()
        {
            int i = 0;
            employeeStatsManager = new EmpStatisticManager(DatabaseType.TEST);
            foreach(Employee emp in employeeStatsManager.GetListOfAllEmployees())
            {
                Assert.AreEqual(emp.Id, this.GetEmployeeIDs()[i]);
                i++;
            }
        }

        public int[] GetEmployeeIDs()
        {
            int[] empIDs = new int[]{2,3,4,6,7,8,9,12,28,40,51,57,58,59,60,61,74,75,79,81,82,83,84,124,125,126,127,128,129,130,131,132,133,134,135,136,137,138,139,140,141,142,143};
            return empIDs;
        }

        public void GetEmployeeContractualHoursTest()
        {
            employeeStatsManager = new EmpStatisticManager(DatabaseType.TEST);
            double[] listEightypercentFulltime = new double[] {5.7,40,160,2080};
            int[] listFlexLeft = new int[] { 0, 0, 0, 0 };

            CollectionAssert.AreEqual(listEightypercentFulltime, employeeStatsManager.GetEmployeeContractualHours("FULLTIME"));
            CollectionAssert.AreEqual(listEightypercentFulltime, employeeStatsManager.GetEmployeeContractualHours("EIGHTYPERCENT"));
            CollectionAssert.AreEqual(listFlexLeft, employeeStatsManager.GetEmployeeContractualHours("LEFT"));
            CollectionAssert.AreEqual(listFlexLeft, employeeStatsManager.GetEmployeeContractualHours("FLEX"));
        }

        public void GetEmployeeHoursPerTimeUnitTest()
        {

        }


    }
}
