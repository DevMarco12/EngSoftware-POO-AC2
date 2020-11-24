using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC2_EngSoftware_POO
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pato pt = new Pato_Ruivo(); // Instância de "Pato" herdando "Pato_Ruivo"

            Console.WriteLine(pt.Mostrar());
            Console.WriteLine(pt.nadar());
            Console.WriteLine(pt.comportamentoPato());

            pt.setComportamento(new Voar_Foguete()); // Delegação

            Console.WriteLine(pt.comportamentoPato());

            Console.ReadLine();
        }
    }
}
