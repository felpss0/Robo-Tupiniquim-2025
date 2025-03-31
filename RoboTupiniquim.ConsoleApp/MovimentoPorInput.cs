using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboTupiniquim.ConsoleApp
{
    public class MovimentoPorInput
    {

        public static void InputUsuario() 
        {
            Console.WriteLine("Digite os comandos para o robo (M = Mover, E = Esquerda ,D = Direita)");
            string comandos = Convert.ToString(Console.ReadLine().ToUpper());

            foreach (char comando in comandos) 
            {
                switch (comando) 
                {
                    case 'M':
                        Robo.AndarEmFrente();
                        break;
                    case 'E':
                        Robo.VirarEsquerda();
                        break;
                    case 'D':
                        Robo.VirarDireita();
                        break;
                }
            }
        }
    }
}
