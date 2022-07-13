namespace AbstractFactoryDP.LandVehicles
{
    public class Car : ILandVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos os passageiros");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Viagem iniciada.");
        }
    }
}
