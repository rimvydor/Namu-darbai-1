using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namu_darbai_1
{
    //Programa klausia vartotojo ar giedras dangus.
    //    Kaip atsakymą vartotojas paspaudžia klavišą 1, 
    //    jeigu dangus yra giedras, ir 0 priešingu atveju. 
    //    Programa spausdina ekrane įvestą reikšmę ir ją perduoda 
    //    metodui (funkcijai), kuri analizuoja atsakymą ir išveda ekrane pilną pranešimą.

   public class ClassUzduotis6
    {

    public void DangusMet()
        {
            Console.WriteLine("Paziurekite pro langa. Koks dabar dangus?");
            Console.WriteLine("Jei dangus giedras spauskite - 1 " +
                "Jei dangus nera giedras spauskite - 0");
            //Console.WriteLine();
            var giedras = Convert.ToInt32(Console.ReadLine());

            // var negiedras = Convert.ToInt32(Console.ReadLine());

            if (giedras == 0)
            {
                Console.WriteLine("Jus paspaudete 0, tai reiskia, kad dangus nera giedras");
            }
            else if (giedras == 1)
            {
                Console.WriteLine("Jus paspaudete 1, tai reiskia, kad dangus yra giedras");
            }
            else {
                Console.WriteLine("Jus ivedete netinkama reiksme");
            }
        }
        
    }
}
