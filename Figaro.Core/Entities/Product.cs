﻿using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Figaro.Core.Entities
{
  public class Product: EntityObject
    {
        [Required]
        public string ProductNr { get; set; }

        [MinLength(1),MaxLength(75),DisplayName("Produktbez.")]
        public string Name { get; set; }

        [DisplayName("Preis")]
        public double Price { get; set; }

        public IEnumerable<OrderItem> OrderItems { get; set; }

        public Product()
        {
            OrderItems = new List<OrderItem>();
        }
    }
}
