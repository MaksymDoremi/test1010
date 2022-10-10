using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tets1010
{
    internal class NakladniAuto : Auto
    {
        private int hmotaNakladu;
        public NakladniAuto(int nadrz, int litryPaliva, int hmotaNakladu) : base(nadrz, litryPaliva)
        {
            HmotaNakladu = hmotaNakladu;
        }

        public int HmotaNakladu
        {
            get { return hmotaNakladu; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("Hmota nakladu je mensi nez 0");
                }
                hmotaNakladu = value;
            }
        }

        public override string ToString()
        {
            return "Nakladni "+base.ToString()+" a uveze "+HmotaNakladu+" kg";
        }
    }
}
