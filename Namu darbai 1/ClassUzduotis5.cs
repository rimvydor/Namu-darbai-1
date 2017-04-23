using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namu_darbai_1
{
    //Pirmąjį patiekalą pietums mama gamina t1 minučių, antrąjį - k minučių ilgiau negu pirmajį, 
    //    trečiąjį - k minučių  ilgiau negu antrąjį ir t.t.Parenkite programą, kuri apskaičiuotų,
    //    kiek patiekalų n suspės pagaminti mama kol vaikai sugrįš iš lauko, jei pietus virti pradėjo dabar,
    //    o vaikai iš lauko grįš po t minučių.Visi duomenys yra sveikojo tipo.

    public class ClassUzduotis5
    {
        int t1 = 61;
        int k = 23;
        int t = 90;

       public void maistoMet() {

            var pirmas = t1;
            var antras = pirmas + k;
            var trecias = antras + k;

            if (trecias < t)
            {
                Console.WriteLine("Mama suspes pagaminti tris patiekalus");
            }
            else if (antras < t) {
                Console.WriteLine("Mama suspes pagaminti du patiekalus");
            } else if (pirmas < t)
            {
                Console.WriteLine("Mama suspes pagaminti viena patiekala");
            } else
            {
                Console.WriteLine("Vaikai grizo anksciau, nei maistas buvo paruostas");
            }
        }
    }
}
