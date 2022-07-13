namespace AbstractFactoryDP.LandVehicles
{
    public class MotorCycle : ILandVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos a encomenda");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Motocicleta ja está na rota de entrega.");
        }
    }
}
