using System;
using Enumeracao.Entities.Enums; //Necessario utilizar para criar a prop OrderStatus

namespace Enumeracao.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id 
                + ", "
                + Moment
                + ", "
                + Status;
        }
    }
}
