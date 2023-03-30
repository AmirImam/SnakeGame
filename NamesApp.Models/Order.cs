﻿namespace NamesApp.Models
{
    public class Order
    {
        public Order()
        {
            Id= Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public int Prductid { get; set; }
        public string ProductName { get; set; }=string.Empty;
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Value { get; set; }
    }
}