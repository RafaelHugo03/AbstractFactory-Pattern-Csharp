using AbstractFactoryDP.Aircraft;
using AbstractFactoryDP.Factories;
using AbstractFactoryDP.LandVehicles;

namespace AbstractFactoryDP.App
{
    public class Application
    {
        private IAirCraft aircraft;
        private ILandVehicle vehicle;

        public Application(ITransportFactory factory)
        {
            vehicle = factory.CreateTransportLandVehicle();
            aircraft = factory.CreateTransportAirCraft();
        }
        public void StartLandVehicleRoute() => vehicle.StartRoute();
   
        public void StartAirCraftRoute() => aircraft.StartRoute();
        
    }
}
