using D13.Entities;
using System;

namespace D13.Services
{
    class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int months)
        {
            double basicPayment = contract.TotalValue / months;

            for(int i = 1; i <= months; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = basicPayment + _onlinePaymentService.Interest(basicPayment, i);
                double fullQuota = updatedQuota + _onlinePaymentService.PayamentFee(updatedQuota);
                contract.AddIntallment(new Installment(date, fullQuota));
            } 
        }

    }
}
