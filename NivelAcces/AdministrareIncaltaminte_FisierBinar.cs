using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagazinIncaltaminte;

namespace NivelAcces
{
    public class AdministrareIncaltaminte_FisierBinar :IStocareDataIncaltaminte
    {
        string NumeFisier { get; set; }
        public AdministrareIncaltaminte_FisierBinar(string NumeFisier)
        {
            this.NumeFisier = NumeFisier;
        }

        public void AddIncaltaminte(Incaltaminte x)
        {
            throw new Exception("Optiunea AddIncaltaminte nu este implementata");
        }
        public List<Incaltaminte> GetIncaltaminte()
        {
            throw new Exception("Optiunea GetIncaltaminte nu este implementata");
        }
        public List<Incaltaminte> GetIncaltaminteIndex(int index)
        {
            throw new Exception("Optiunea GetIncaltaminteIndex nu este implementata");
        }
        public void UpdateIncaltaminte(Incaltaminte x, int index)
        {
            throw new Exception("Optiunea UpdateIncaltaminte nu este implementata");
        }

        public void UpdateData(List<Incaltaminte> x)
        {
            throw new Exception("Optiunea UpdateData nu este implementata");
        }
    }
}
