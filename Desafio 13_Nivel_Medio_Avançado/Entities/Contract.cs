using System;
using System.Collections.Generic;
using System.Text;

namespace D13.Entities
{
    class Contract
    {
        public int                  Number                    { get; set; } //Numero do contrato
        public DateTime             Date                      { get; set; } // Data inicial do contrato
        public double               TotalValue                { get; set; } // Valor total do contrato
        public List<Installment>    installments = new List<Installment>(); // Lista de parcelas!

        public Contract(int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            //Installment = new List<Installment>();
        }

        //Metodo para adicionar uma parcela,  recebendo a propria lista de parcelas
        public void AddIntallment(Installment installment)
        {
            //lista de parcelas, recebendo uma nova parcela
            installments.Add(installment);
        }

    }
}
