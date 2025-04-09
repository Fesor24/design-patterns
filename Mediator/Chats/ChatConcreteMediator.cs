using System.Text.Json;

namespace Mediator.Chats;

public class ChatConcreteMediator : ChatMediator
{
    private List<User> _users = [];
    public void Notify(User sender, string message)
    {
        if (!_users.Any())
            return;

        foreach (User user in _users)
        {
            if (sender == user)
                continue;

            string chatMessage = JsonSerializer.Serialize(new
            {
                Recipient = user.Name,
                Sender = sender.Name,
                Message = message 
            });
            
            user.ReceiveMessage(chatMessage);
        }
    }

    public void AddUser(User user)
    {
        user.SetMediator(this);
        _users.Add(user);
    }

    public void AddUsers(List<User> users)
    {
        foreach (var user in users)
        {
            user.SetMediator(this);
            _users.Add(user);
        }
    }
}