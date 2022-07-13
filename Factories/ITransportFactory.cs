using AbstractFactoryDP.Aircraft;
using AbstractFactoryDP.LandVehicles;

namespace AbstractFactoryDP.Factories
{
    public interface ITransportFactory
    {
        IAirCraft CreateTransportAirCraft();
        ILandVehicle CreateTransportLandVehicle();
    }
}
