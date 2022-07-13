namespace AbstractFactoryDP.Aircraft
{
    public class Drone : IAirCraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Checando o vento... Vento favorável para decolagem");
        }

        public void GetCargo()
        {
            Console.WriteLine("pegamos a encomenda");
        }

        public void StartRoute()
        {
            GetCargo();
            CheckWind();
            Console.WriteLine("Drone á caminho");
        }
    }
}
