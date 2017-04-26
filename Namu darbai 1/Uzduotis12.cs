using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namu_darbai_1
{
   public class Uzduotis12
    {

        public void prekyba ()
        {
            Console.WriteLine("Kiek ledu pardavete pirma diena?");
            var pirmaDiena = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Keliomis porcijomis daugiau pardvete kiekviena kita diena?");
            var pardaveDaugiau = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Kelias dienas prekiavote?");
            var dienos = Convert.ToInt32(Console.ReadLine());

            var sum = 0;
           
            for (int i = 0; i < dienos; i++)
            {
                var ledai = pirmaDiena;
                pirmaDiena += pardaveDaugiau;
                sum += ledai;
                Console.WriteLine(ledai);

            }
            Console.WriteLine(sum);
        }
    }
}
