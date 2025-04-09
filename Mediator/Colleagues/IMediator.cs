namespace Mediator;

public interface IMediator
{
    void Notify(Colleague colleague, string @event);
}