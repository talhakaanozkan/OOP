namespace ObjectOrientedProgramming.Notifications
{
    public sealed record EmailMessage(string To, string Body, string Subject) : IMessage;
}
