﻿namespace Ex43.Services
{
    class BrazilTaxService 
    {
        public double Tax(double amount)
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
