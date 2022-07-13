using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDP.Aircraft
{
    public class Airplane : IAirCraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Checando o vento... Vento Ok! Decolagem autorizada.");
        }

        public void GetCargo()
        {
            Console.WriteLine("Passageiros embarcados");
        }

        public void StartRoute()
        {
            GetCargo();
            CheckWind();
            Console.WriteLine("Viagem iniciada");
        }
    }
}
