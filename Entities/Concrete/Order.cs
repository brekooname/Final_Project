﻿using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Order : IEntity
    {
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        public int EmpleyeeId { get; set; }
        public DateTime OrderDate { get; set; }
        public string ShipCity { get; set; }
    }
}
