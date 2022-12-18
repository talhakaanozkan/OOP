namespace ObjectOrientedProgramming.Notifications
{
    public sealed record SmsMessage(string To, string Body) : IMessage;
}
