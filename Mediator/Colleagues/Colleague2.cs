using static System.Console;

namespace Mediator;

public class Colleague2 : Colleague
{
    public void Operation2()
    {
        WriteLine("Message from colleague 2");
        _mediator.Notify(this,$"Message sent from colleague 2. TimeStamp: {DateTime.UtcNow}");
    }
    
    public void ReceiveMessage(string @event)
    {
        WriteLine($"Message received from colleague 2: {@event}");
    }
}