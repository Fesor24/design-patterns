using static System.Console;

namespace Mediator.Chats;

public class AdminUser : User
{
    public AdminUser(string name) : base(name)
    {
    }
    public override void ReceiveMessage(string message)
    {
        WriteLine($"Message received. \n {message}");
    }

    public override void SendMessage(string message)
    {
        _mediator.Notify(this, message);
    }

    public void BroadcastMessage(string message)
    {
        _mediator.Notify(this, message);
    }
}