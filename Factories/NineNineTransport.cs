using AbstractFactoryDP.Aircraft;
using AbstractFactoryDP.LandVehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDP.Factories
{
    public class NineNineTransport : ITransportFactory
    {
        public IAirCraft CreateTransportAirCraft()
        {
            return new Helicopter();
        }

        public ILandVehicle CreateTransportLandVehicle()
        {
            return new MotorCycle();
        }
    }
}
