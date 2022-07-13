namespace AbstractFactoryDP.LandVehicles
{
    public class Scooter : ILandVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a Encomenda.");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Os Patinetes ja estão em rota de entrega.");
        }
    }
}
