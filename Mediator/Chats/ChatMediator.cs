namespace Mediator.Chats;

public interface ChatMediator
{
    void Notify(User sender, string message);
}