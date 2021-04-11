using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaar
{
    public class ContractHistoryManager
    {
        DatabaseMediator DatabaseMediator;
        List<ContractHistory> contractHistories;
        
        public List<ContractHistory> ContractHistories
        {
            get { return contractHistories; }
        }

        public ContractHistoryManager(int id)
        {
            DatabaseMediator = new DatabaseMediator();
            contractHistories = DatabaseMediator.GetContractHystory(id);
        }

    }
}
