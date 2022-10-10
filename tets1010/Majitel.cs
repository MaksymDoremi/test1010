using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tets1010
{
    internal class Majitel
    {
        private string name;
        private string surname;
        private Auto vozidlo;

        public Majitel(string name, string surname, Auto vozidlo)
        {
            Name = name;
            Surname = surname;
            Vozidlo = vozidlo;
           
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }

        public Auto Vozidlo
        {
            get { return vozidlo; }
            set
            {
                vozidlo = value;
            }
        }

        public override string ToString()
        {
            return "Majitel "+Name+" "+Surname+" ma "+vozidlo;
        }
    }
}
