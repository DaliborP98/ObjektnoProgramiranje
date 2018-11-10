using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Informacije i1 ;
            i1 = new Informacije();
            double prijedeniKM;
            double PotrosnjaGoriva;
            double PotrosnjaGorivaNaOdredeniKM;
            string odabir;
            double CijenaGoriva;
            string djeljenjeTroska;
            int osobe;
            Console.WriteLine("***********MJESECNI IZRACUN KOLIKO CE VAS KOSTATI GORIVO***********");
            Console.Write("Upisite koliko kilometara ce te proci ");
            prijedeniKM = Convert.ToDouble(Console.ReadLine());
            i1.setprijedeniKM(prijedeniKM);
            Console.Write("Koliko vam auto trosi litara u prosjeku ");
            PotrosnjaGoriva = Convert.ToDouble(Console.ReadLine());
            i1.setpotrosnjaGoriva(PotrosnjaGoriva);
            Console.Write("U prosjeku na 100 km? (da/ne) ");
            odabir = Console.ReadLine();
            if (odabir.Equals("Da") || odabir.Equals("da"))
            {
                i1.setPotrosnjaGorivaNaOdredeniKM(100);
            }
            else
            {
                Console.Write("Na koliko km onda ");
                PotrosnjaGorivaNaOdredeniKM = Convert.ToDouble(Console.ReadLine());
                i1.setPotrosnjaGorivaNaOdredeniKM(PotrosnjaGorivaNaOdredeniKM);
            }
            Console.Write("Upisite trenutnu cijenu goriva ");
            CijenaGoriva = Convert.ToDouble(Console.ReadLine());
            i1.setcijenaGoriva(CijenaGoriva); 
            Console.WriteLine("To ce vas kostati {0} kn " , i1.izracunMjesecno());
            Console.Write("Djelite li trosak (da/ne) ");
            djeljenjeTroska = Console.ReadLine();
            if (djeljenjeTroska.Equals("Da") || djeljenjeTroska.Equals("da"))
            {
                Console.Write("Sa koliko osoba dijelite trosak ");
                osobe = Convert.ToInt32(Console.ReadLine());
                i1.setDjeljenjeTroska(osobe);
                Console.WriteLine("Mjesecni trosak iznosi {0} kn po osobi ", i1.getDjeljenjeTroska());
            }
   
        }
    }
    }
