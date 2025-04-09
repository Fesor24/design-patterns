namespace Mediator;

public abstract class Colleague
{
    protected IMediator _mediator = null!;

    public void SetMediator(IMediator mediator)
    {
        _mediator = mediator;
    }
}