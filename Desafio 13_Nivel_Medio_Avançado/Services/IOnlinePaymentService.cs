namespace D13.Services
{
    interface IOnlinePaymentService
    {

        //TAXA DE PAGAMENTO

        public double PayamentFee(double amount); // somente a assinatura do metodo 

        //Juros
        public double Interest(double amount, int month); // somente a assinatura do metodo
       
    }
}
