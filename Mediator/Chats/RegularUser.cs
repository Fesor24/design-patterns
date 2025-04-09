using static System.Console;

namespace Mediator.Chats;

public class RegularUser : User
{
    public RegularUser(string name) : base(name)
    {
    }
    
    public override void ReceiveMessage(string message)
    {
        WriteLine($"Message received. {message}");
    }

    public override void SendMessage(string message)
    {
        _mediator.Notify(this, message);
    }
}