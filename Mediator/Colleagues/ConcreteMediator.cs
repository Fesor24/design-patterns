using static System.Console;

namespace Mediator;

public class ConcreteMediator : IMediator
{
    private readonly Colleague1 _colleague1;
    private readonly Colleague2 _colleague2;

    public ConcreteMediator(Colleague1 colleague1, Colleague2 colleague2)
    {
        _colleague1 = colleague1;
        _colleague1.SetMediator(this);
        
        _colleague2 = colleague2;
        _colleague2.SetMediator(this);
    }
    
    public void Notify(Colleague sender, string @event)
    {
        WriteLine($"Concrete mediator notified by {sender.GetType().Name}");

        if (sender == _colleague1)
        {
            // call method on colleague 2
            _colleague2.ReceiveMessage(@event);
        }

        if (sender == _colleague2)
        {
            // call method on colleague 1
            _colleague1.ReceiveMessage(@event);
        }
    }
}