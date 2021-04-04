using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagazinIncaltaminte;

namespace NivelAcces
{
    public interface IStocareDataIncaltaminte
    {
        void AddIncaltaminte(Incaltaminte p);
        void UpdateData(List<Incaltaminte> x);
        List<Incaltaminte> GetIncaltaminte();
        void UpdateIncaltaminte(Incaltaminte x, int index);
    }
}
