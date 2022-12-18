﻿namespace ObjectOrientedProgramming.Payments
{
    public sealed class DebitCard : IPayment
    {
        public void Pay(decimal value)
        {
            Console.WriteLine(nameof(DebitCard));
        }
    }
}
