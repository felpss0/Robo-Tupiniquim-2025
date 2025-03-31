
namespace RoboTupiniquim.ConsoleApp
{
    public class GridNavegacao
    {
        public static int limiteX;
        public static int limiteY;

        public static void LimiteDaArea()
        {
            Console.WriteLine("Digite o limite da area Horizontal (X): ");
            limiteX = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o limite da area Vertical (Y): ");
            limiteY = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Area de navegação definida 0 a {limiteX} no eixo X e 0 a {limiteY} no eixo Y");
        }
    }
}
