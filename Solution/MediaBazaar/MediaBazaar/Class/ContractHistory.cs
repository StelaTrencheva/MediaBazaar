using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    public class ContractHistory
    {
        int empid;
        ContractType contract;
        DateTime startdate;
        DateTime lastdate;
        //Constructor
        public ContractHistory(int empid, ContractType contract, DateTime startdate, DateTime lastdate)
        {
            this.empid = empid;
            this.contract = contract;
            this.startdate = startdate;
            this.lastdate = lastdate;
        }
        public override string ToString()
        {
            return $"{contract} From: {startdate.ToString("yyyy-MM-dd")} To: {lastdate.ToString("yyyy-MM-dd")}";
        }
    }
}
