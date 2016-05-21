﻿namespace ValidationByDecoratorSamples
{
    public class Order
    {
        public int Id { get; set; }

        public string CustomerName { get; set; }

        public string ProductName { get; internal set; }

        public int Amount { get; internal set; }

        public int UnitPrice { get; internal set; }

        public int TotalPrice { get; internal set; }
    }
}