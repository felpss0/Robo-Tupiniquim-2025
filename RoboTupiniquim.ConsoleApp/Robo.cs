
namespace RoboTupiniquim.ConsoleApp
{
    class Robo
    {
        public static int posicaoX = 0;
        public static int posicaoY = 0;
        public static string direcao = "N";

        public static void PosicaoInicialRobo()
        {
            Console.WriteLine("Digite a posição inicial do robo");
            Console.Write("Posição X:");
            posicaoX = Convert.ToInt32(Console.ReadLine());
            Console.Write("Posição Y:");
            posicaoY = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o lado que o robo vai estar olhando");
            direcao = Convert.ToString(Console.ReadLine());
        }

        public static void MovimentosRobo()
        {
            string comandos = "EMEMEMEMM";



        }



    }
}
