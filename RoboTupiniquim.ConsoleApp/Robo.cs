

namespace RoboTupiniquim.ConsoleApp
{
    class Robo
    {
        public static int posicaoX;
        public static int posicaoY;
        public static string direcao;

        

        public static void PosicaoInicialRobo() 
        {
            Console.WriteLine("Digite a posição inicial do robo");
            Console.WriteLine("--------------------------------");
            Console.Write("Posição X: ");
            posicaoX = Convert.ToInt32(Console.ReadLine());

            Console.Write("Posição Y: ");
            posicaoY = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o lado que o robo vai estar olhando (Norte,Sul,Leste,Oeste) ");
            direcao = Convert.ToString(Console.ReadLine().ToUpper());


        }

        public static void StatusRobo()
        {
            Console.WriteLine($"Posição ({posicaoX},{posicaoY}), Direção: {direcao}");
        }
    }
}
