using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Ex24_enumeracoes_e_composicoes.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public Enums.OrderStatus Status { get; set; }

        public override string ToString()
        {
            return this.Id
                +", "
                + this.Moment
                +", "
                + this.Status;
        }
    }


    
}
