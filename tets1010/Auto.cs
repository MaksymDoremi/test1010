using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tets1010
{
    internal class Auto
    {
        private int nadrz;
        public int litryPaliva;

        public Auto(int nadrz, int litryPaliva)
        {
            Nadrz = nadrz;
            if (litryPaliva > nadrz)
            {
                //error
                //Console.WriteLine("paliva je vic nez nadrze takze smula");
            }
            else
            {
                LitryPaliva = litryPaliva;
            }


        }

        public int Nadrz
        {
            get { return nadrz; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("nadrz je mensi nez 0");
                }
                nadrz = value;
            }
        }

        public int LitryPaliva
        {
            get { return litryPaliva; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("litry jsou min nez 0 litru");
                }
                litryPaliva = value;
            }
        }

        public void Dolit(int value)
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("nesmis dolit min nez nula paliva");
            }
            else
            {
                if (LitryPaliva + value > Nadrz)
                {
                    throw new ArgumentOutOfRangeException("Doliti paliva preplnuje nadrz");
                }
                else
                {
                    LitryPaliva = LitryPaliva + value;
                }
            }
        }

        public override string ToString()
        {
            return "Auto ma nadrz " + Nadrz + " l a palivo " + LitryPaliva + " l";
        }

    }
}
