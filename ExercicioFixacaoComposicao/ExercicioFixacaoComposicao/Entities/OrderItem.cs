﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioFixacaoComposicao.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem() { }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return $"Name: {Product.Name}, " +
                $"Value: ${Price.ToString("F2", CultureInfo.InvariantCulture)}, " +
                $"Quantity: {Quantity}, " +
                $"Subtotal: ${SubTotal().ToString("F2",CultureInfo.InvariantCulture)}";
        }
    }
}
