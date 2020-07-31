using System;

namespace Ex1.Entities
{
    class CarRental // Aluguel de carros
    {
        public DateTime Start  { get; set; }  //Entrada
        public DateTime Finish { get; set; }  //Saida
        public Invoice Invoice { get; set; }  //Nota Fiscal
        public Vehicle Vehicle { get; set; }  //Veiculo Modelo
/*
        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
        }
*/
    }
}
