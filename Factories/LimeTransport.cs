using AbstractFactoryDP.Aircraft;
using AbstractFactoryDP.LandVehicles;

namespace AbstractFactoryDP.Factories
{
    public class LimeTransport : ITransportFactory
    {
        public IAirCraft CreateTransportAirCraft()
        {
            return new Drone();
        }

        public ILandVehicle CreateTransportLandVehicle()
        {
            return new Scooter();
        }
    }
}
