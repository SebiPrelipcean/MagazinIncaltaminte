using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinIncaltaminte
{
    public class Incaltaminte
    {
        public string Denumire { get; set; }
        public float Pret { get; set; }
        public int Bucati { get; set; }
        public bool Disponibil { get; set; }
        public string Detalii { get; set; }
        public string Codprodus { get; set; }
        public string gen { get; set; }


        public Incaltaminte(string date)
        {
            string[] aux = date.Split(',');
            Denumire = aux[0];
            Pret = Convert.ToInt32(aux[1]);
            Bucati = Convert.ToInt32(aux[2]);
            Disponibil = Convert.ToBoolean(aux[3]);
            Detalii = aux[4];
            Codprodus = aux[5];

        }

        public Incaltaminte(string _den, float _pret,int _buc,bool _dis, string _det, string _cod )
        {
            this.Denumire = _den;
            this.Pret = _pret;
            this.Bucati = _buc;
            this.Disponibil = _dis;
            this.Detalii = _det;
            this.Codprodus = _cod;
        }

        public override string ToString()
        {
            return "Denumire: " + Denumire + "\nPret: " + Pret + "\nBucati: " + Bucati + "\nDisponibil: " + Disponibil + "\nDetalii: " + Detalii + "\nCod Produs: " + Codprodus;
        }

        public string ConversieLaSir()
        {
            return string.Format(Denumire + "," + Pret + "," + Bucati + "," + Disponibil + "," + Detalii + "," + Codprodus + "\n");
        }
    }


}
