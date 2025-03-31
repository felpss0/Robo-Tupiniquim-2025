namespace RoboTupiniquim.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GridNavegacao.LimiteDaArea();

            Robo.PosicaoInicialRobo();

            MovimentoPorInput.InputUsuario();
            Robo.StatusRobo();


            Console.ReadLine();
            

        }
    }
}
