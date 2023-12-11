using Core.Services;

namespace TestProject
{
    public class ContractItemTest
    {
        private readonly IContractService contractService;
        public ContractItemTest(IContractService contractService)
        {
            this.contractService = contractService;
        }


    }
}
