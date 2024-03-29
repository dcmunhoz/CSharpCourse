﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public Double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return $"{Product.Name}, Quantity: {Quantity}, Subtotal: {SubTotal().ToString("F2")} ";
        }
    }
}
