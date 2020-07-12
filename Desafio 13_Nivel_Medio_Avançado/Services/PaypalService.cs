using System;

namespace D13.Services
{
    class PaypalService : IOnlinePaymentService
    {
        //Calculations (1% monthly simple interest + 2% payment fee):

        private double FeePorcentage = 0.02;
        private double MonthInterest = 0.01;


        //Juros simples
        public double Interest(double amount, int month)
        {
            return amount * MonthInterest * month;
        }


        //TAXA DE PAGAMENTO
        public double PayamentFee(double amount)
        {
            return amount * FeePorcentage;
        }
    }
}
