﻿using Basket.Domain.Data.Entities.Base;

namespace Basket.Domain.Data.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
