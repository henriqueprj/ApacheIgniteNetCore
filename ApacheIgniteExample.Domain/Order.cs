using System;

namespace ApacheIgniteExample.Domain
{
    public class Order
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Symbol { get; set; }
        public decimal Quantity { get; set; }
        public OrderSide Side { get; set; }
        public OrderType Type { get; set; }
        public OrderStatus Status { get; set; }
        public decimal Price { get; set; }
        public decimal TriggerPrice { get; set; }
        public DateTime? ExpiresAt { get; set; }
        public DateTime CreatedAt { get; set; }

    }

    public enum OrderStatus
    {
        Open = 0,
        Executed,
        PartialExecuted,
        Cancelled
    }

    public enum OrderType
    {
        Limit = 0,
        Pending,
        Market,
        Stop
    }

    public enum OrderSide
    {
        Buy = 0,
        Sell
    }
}
