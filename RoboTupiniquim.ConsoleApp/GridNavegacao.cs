
namespace RoboTupiniquim.ConsoleApp
{
    class GridNavegacao
    {
        public static void LimiteDaArea()
        {
            Console.WriteLine("Digite o limite da Area Horizontal");
            double areaX = Convert.ToInt32(Console.ReadLine());

            double raio = Math.Pow(areaX, 2);

            Console.WriteLine($"A area utilizavel é: {raio}");





        }
    }
}
