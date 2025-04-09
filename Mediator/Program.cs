// Behavioral pattern...

using Mediator;
using Mediator.Chats;

Console.WriteLine("Hello from Mediator!!!");

//Colleague1 colleague1 = new();
//Colleague2 colleague2 = new();
//ConcreteMediator mediator = new(colleague1, colleague2);

//colleague1.Operation1();
//colleague2.Operation2();


// Chat example
ChatConcreteMediator mediator = new();

RegularUser mike = new("Mike");
RegularUser michonne = new("Michonne");

AdminUser tony = new("Tony");

mediator.AddUsers([mike, michonne, tony]);


mike.SendMessage("Hello!!!");
michonne.SendMessage("Hi");
mike.SendMessage("I am okay. How you doing??");
michonne.SendMessage("I am good.");

tony.BroadcastMessage("Keep chat friendly.");
