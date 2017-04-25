using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namu_darbai_1
{
    class Uzduotis11
    {
        public void algos()
        {
            Console.WriteLine("Keliu menesiu algas noresite ivest?");
            var alguIvedimas = Convert.ToInt32(Console.ReadLine());
            
            int [] alguSkaicius = new int[alguIvedimas]; 
            var sum = 0;
            for (int i = 0; i < alguSkaicius.Length; i++)
            {
                Console.WriteLine("Iveskite alga.");
                alguSkaicius[i] = Convert.ToInt32(Console.ReadLine());
                sum += alguSkaicius[i];
            }

            //iskarto suskaiciuoja array suma. nereikia var sum ir sum += eiluciu!!!
            //int sum = alguSkaicius.Sum(); 
             
            Console.WriteLine("Per tris menesius uzdirbta: " + sum);

            //vidurkis
            Console.WriteLine("Vidutinis darbo uzmokestis: " + sum / alguIvedimas);
            Console.ReadLine();
        }
    }
}
