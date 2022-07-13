namespace AbstractFactoryDP.Aircraft
{
    public class Helicopter : IAirCraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Checando o vento... Vento favorável para decolagem.");
        }

        public void GetCargo()
        {
            Console.WriteLine("Pegamos os passageiros");
        }

        public void StartRoute()
        {
            GetCargo();
            CheckWind();
            Console.WriteLine("Iniciando Passeio.");
        }
    }
}
