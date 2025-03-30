

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
            direcao = Convert.ToString(Console.ReadLine());

            switch (direcao) 
            {
                case "norte": direcao = "Norte";break;
                case "sul": direcao = "Sul"; break;
                case "leste": direcao = "Leste"; break;
                case "oeste": direcao = "Oeste"; break;
            }

        }

        public static void AndarEmFrente() 
        {

            switch (direcao) 
            {
                case "Norte": posicaoY++; break;
                case "Sul": posicaoY--; break;
                case "Leste": posicaoX++; break;
                case "Oeste": posicaoX--; break;
            }
        }

        public static void VirarDireita() 
        {
            switch (direcao) 
            {
                case "Norte": direcao = "Leste"; break;
                case "Leste": direcao = "Sul"; break;
                case "Sul": direcao = "Oeste"; break;
                case "Oeste": direcao = "Norte"; break;
            }
            Console.WriteLine($"O robo virou a direita. Agora está voltado para {direcao}");
        }

        public static void VirarEsquerda() 
        {
            switch (direcao) 
            {
                case "Norte": direcao = "Oeste"; break;
                case "Oeste": direcao = "Sul"; break;
                case "Sul": direcao = "Leste"; break;
                case "Leste": direcao = "Norte"; break;
            }
        }

        public static void StatusRobo()
        {
            Console.WriteLine($"Posição ({posicaoX},{posicaoY}), Direção: {direcao}");
        }
    }
}
