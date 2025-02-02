﻿using System.ComponentModel.DataAnnotations;

namespace Server.Application.Models
{
    public class CartProducts
    {
        [Key]
        public int ID { get; set; }
        public Product? Product { get; set; }
        public Customer? Customer { get; set; }
        public bool IsPaid { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }


        public CartProducts() { }
        public CartProducts(Product Product, Customer Customer, int Price, int Quantity)
        {
            this.Product = Product;
            this.Customer = Customer;
            this.Price = Price;
            this.Quantity = Quantity;
        }
    }
}
