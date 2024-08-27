using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pede_edad_ususario_si_no_es_mayor_decir_Eresunadolecent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ejercicio If . pedir la edad del usuario, sies mayor de edad decirle bienvenido, sino decirle Eres un adolecente
            Console.WriteLine("Edad: ");

            int edad = int.Parse(Console.ReadLine());


            if (edad >= 18)
            {
                Console.WriteLine("Binemvenido al mundo de las rsponsabilidades.");

            } else
            {
                Console.WriteLine("Eres un adolecente, disfruta de la vida.");
            }

            Console.ReadLine();
        }
    }
}
         
