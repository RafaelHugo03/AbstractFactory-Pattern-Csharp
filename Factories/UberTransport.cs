using AbstractFactoryDP.Aircraft;
using AbstractFactoryDP.LandVehicles;

namespace AbstractFactoryDP.Factories
{
    public class UberTransport : ITransportFactory
    {
        public IAirCraft CreateTransportAirCraft()
        {
            return new Airplane();
        }

        public ILandVehicle CreateTransportLandVehicle()
        {
            return new Car();
        }
    }
}
