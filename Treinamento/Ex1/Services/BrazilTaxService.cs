namespace Ex1.Services
{
    class BrazilTaxService : ITaxService
    {
        public double Tax(double amount) //Servico De Taxacao do Brasil
        {
            if (amount <= 100.00)
            {
                return amount * 0.20;
            }
            else
            {
                return amount * 0.15;
            }
        } 
    }
}
