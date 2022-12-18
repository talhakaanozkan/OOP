namespace ObjectOrientedProgramming.Notifications
{
    public interface INotification<in TMessage> where TMessage : IMessage
    {
        void Notify(TMessage message);
    }
}
