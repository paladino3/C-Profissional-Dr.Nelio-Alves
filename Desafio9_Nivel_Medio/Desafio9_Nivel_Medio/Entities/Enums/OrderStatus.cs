using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio9_Nivel_Medio.Entities.Enums
{
    enum OrderStatus : int
    {
        PendingPayamment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
