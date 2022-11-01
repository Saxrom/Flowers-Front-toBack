using System;
namespace Front_toBack_3.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public double Price { get; set; }

        public int CategoryId { get; set; }
    }
}

