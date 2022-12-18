﻿namespace ObjectOrientedProgramming.Payments
{
    public sealed class PaymentService
    {
        public PaymentService(IPayment payment)
        {
            Payment = payment;
        }

        private IPayment Payment { get; }

        public void Pay(decimal value)
        {
            Payment.Pay(value);
        }
    }
}
