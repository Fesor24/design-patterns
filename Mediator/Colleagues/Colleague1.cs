using static System.Console;

namespace Mediator;

public class Colleague1 : Colleague
{
    public void Operation1()
    {
        WriteLine("Message from colleague 1");
        _mediator.Notify(this,$"Message sent from colleague 1. TimeStamp: {DateTime.UtcNow}");
    }

    public void ReceiveMessage(string @event)
    {
        WriteLine($"Message received from colleague 1: {@event}");
    }
}