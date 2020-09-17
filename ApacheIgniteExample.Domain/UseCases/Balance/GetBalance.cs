using System;
using System.Threading;
using System.Threading.Tasks;

namespace ApacheIgniteExample.Domain.Commands.Balance
{
    public class GetBalance
    {
        public Guid AccountId { get; set; }
    }

    public class GetBalanceHandler
    {
        public Task<GetBalanceResult> Execute(GetBalance command, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    public class GetBalanceResult
    {
        public class BalanceAvailableAmountInfo
        {
            public decimal D0 { get; set; }
            public decimal D1 { get; set; }
            public decimal D2 { get; set; }
        }

        public class BalanceCurrentAmountInfo
        {
            public decimal D0 { get; set; }
            public decimal D1 { get; set; }
            public decimal D2 { get; set; }
            public decimal D3 { get; set; }
            public decimal DayStart { get; set; }
            public decimal Dn { get; set; }
            public decimal CashOnHand { get; set; }
            public decimal Now { get; set; }
            public decimal Total { get; set; }
            public decimal TotalD1 { get; set; }
            public decimal TotalD2 { get; set; }
            public decimal TotalD3 { get; set; }
            public decimal Blocked { get; set; }
        }

        public class ExecutedOrdersAmountInfo
        {
            public decimal Buy { get; set; }
            public decimal Sell { get; set; }
            public decimal BuyD1 { get; set; }
            public decimal BuyD2 { get; set; }
            public decimal BuyD3 { get; set; }
            public decimal SellD1 { get; set; }
            public decimal SellD2 { get; set; }
            public decimal SellD3 { get; set; }
        }

        public class OpenOrdersAmountInfo
        {
            public decimal Buy { get; set; }
            public decimal[] BuyD { get; set; }
            public decimal BuyD1 { get; set; }
            public decimal BuyD2 { get; set; }
            public decimal BuyD3 { get; set; }
            public decimal Sell { get; set; }
            public decimal[] SellD { get; set; }
            public decimal SellD1 { get; set; }
            public decimal SellD2 { get; set; }
            public decimal SellD3 { get; set; }
        }

        public decimal AppliedRate { get; set; }
        public BalanceAvailableAmountInfo Available { get; set; }
        public decimal Blocked { get; set; }
        public decimal Cash { get; set; }
        public BalanceCurrentAmountInfo Current { get; set; }
        public decimal DayStartWithoutBlocked { get; set; }
        public decimal EvaluatedAmount { get; set; }
        public ExecutedOrdersAmountInfo ExecutedOrders { get; set; }
        public string Id { get; set; }
        public decimal Interest { get; set; }
        public OpenOrdersAmountInfo OpenOrders { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public decimal Yield { get; set; }
        public decimal ProjectedAmount { get; set; }
        public decimal CashForWithdrawAvailable { get; set; }
        public decimal WithdrawRequestAmount { get; set; }
    }
}