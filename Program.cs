using AbstractFactoryDP.App;
using AbstractFactoryDP.Factories;

Menu();
void Menu() 
{
    Console.WriteLine("Qual empresa deseja chamar?\n1 - Para Lime \n2 - Para Uber \n3 - Para 99 \n0 - para sair\n");
    int opt = int.Parse(Console.ReadLine());

    switch (opt) 
    {
        case 1: Lime(); break;  
        case 2: Uber(); break;
        case 3: NineNine(); break;
        case 0: Console.WriteLine("Finalizando"); break;
        default: Console.WriteLine("Opção inválida"); Menu(); break;
    }
}
void Lime() 
{
    Console.Clear();
    var app = ConfigureApplication(new LimeTransport());
    Console.Write("O que deseja \n1 - Para Patinete \n2 - Para Drone \n3 - Para voltar ao menu\n ");
    int opt = int.Parse(Console.ReadLine());

    switch (opt) 
    {
        case 1: app.StartLandVehicleRoute(); break;
        case 2: app.StartAirCraftRoute(); break;
        case 3: Menu(); break;
        default: Console.WriteLine("Opção inválida"); Menu(); break;
    }
        
}
void Uber() 
{
    Console.Clear();
    var app = ConfigureApplication(new UberTransport());
    Console.Write("O que deseja? \n1 - Para Carro \n2 - Para Avião \n3 - Para voltar ao menu\n ");
    int opt = int.Parse(Console.ReadLine());

    switch (opt) 
    {
        case 1: app.StartLandVehicleRoute(); break;
        case 2: app.StartAirCraftRoute(); break;
        case 3: Menu(); break;
        default: Console.WriteLine("Opção inválida"); Menu(); break;
    }
        
}
void NineNine() 
{
    Console.Clear();
    var app = ConfigureApplication(new NineNineTransport());
    Console.Write("O que deseja? \n1 - Para Moto \n2 - Para Helicóptero \n3 - Para voltar ao menu\n ");
    int opt = int.Parse(Console.ReadLine());

    switch (opt) 
    {
        case 1: app.StartLandVehicleRoute(); break;
        case 2: app.StartAirCraftRoute(); break;
        case 3: Menu(); break;
        default: Console.WriteLine("Opção inválida"); Menu(); break;
    }
        
}
Application ConfigureApplication(ITransportFactory transportFactory) 
{
    Application app;
    app = new Application(transportFactory);
    return app;
}


