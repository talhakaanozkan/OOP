namespace ObjectOrientedProgramming.Payments
{
    public sealed class CreditCard : IPayment
    {
        public void Pay(decimal value)
        {
            Console.WriteLine(nameof(CreditCard));
        }
    }
}
