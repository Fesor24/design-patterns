using System.Net.Sockets;

namespace Mediator.Chats;

public abstract class User
{
    protected ChatMediator _mediator;

    public User(string name)
    {
        Name = name;
    }
    public void SetMediator(ChatMediator mediator)
    {
        _mediator = mediator;
    }
    
    public string Name { get; init; }
    
    public abstract void ReceiveMessage(string message);
    public abstract void SendMessage(string message);
}