using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gorivo
{
    class Informacije
    {

        private double PrijedeniKM = 0;
        private double PotrosnjaGoriva = 0;
        private double PotrosnjaGorivaNaOdredeniKM = 0;
        private double CijenaGoriva = 0;
        private double DjeljenjeTroska = 0;

        public void setprijedeniKM(double PrijedeniKM)
        {
            this.PrijedeniKM = PrijedeniKM;
        }
        public double getprijedeniKM()
        {
            return PrijedeniKM;
        }
        public void setpotrosnjaGoriva(double PotrosnjaGoriva)
        {
            this.PotrosnjaGoriva = PotrosnjaGoriva;
        }
        public double getpotrosnjaGoriva()
        {
            return PotrosnjaGoriva;
        }
        public void setcijenaGoriva(double CijenaGoriva)
        {
            this.CijenaGoriva = CijenaGoriva;
        }
        public double getcijenaGoriva()
        {
            return CijenaGoriva;
        }
        public void setPotrosnjaGorivaNaOdredeniKM(double PotrosnjaGorivaNaOdredeniKM)
        {
            this.PotrosnjaGorivaNaOdredeniKM = PotrosnjaGorivaNaOdredeniKM;
        }
        public double getPotrosnjaGorivaNaOdredeniKM()
        {
            return PotrosnjaGorivaNaOdredeniKM;
        }
        public double izracunMjesecno()
        {
            
            return ((getprijedeniKM() / getPotrosnjaGorivaNaOdredeniKM()) * getpotrosnjaGoriva()) * getcijenaGoriva();

        }
        public void setDjeljenjeTroska(int osoba)
        {
            DjeljenjeTroska = osoba;
        }
        public double getDjeljenjeTroska()
        {
      
            return izracunMjesecno() / DjeljenjeTroska;
        }


    }
}
