using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagazinIncaltaminte;

namespace NivelAcces
{
    public class AdministrareIncaltaminte_FisierText: IStocareDataIncaltaminte
    {
        private int ID_PRIMA_PERECHE = 1;
        private int INCREMENT = 1;
        private const int PAS_ALOCARE = 10;
        public string NumeFisier { get; set; }

        public AdministrareIncaltaminte_FisierText(string numefisier)
        {
            this.NumeFisier = numefisier;
            Stream sFisierText = File.Open(numefisier, FileMode.OpenOrCreate);
            sFisierText.Close();
        }

        public void AddIncaltaminte(Incaltaminte p)
        {
            try
            {
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier,true))
                {
                    swFisierText.WriteLine(p.ConversieLaSir());
                }
            }
            catch(IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch(Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }

        public void UpdateData(List<Incaltaminte> x)
        {
            try
            {
                using (StreamWriter swFiserText = new StreamWriter(NumeFisier,false))
                {
                    foreach(Incaltaminte p in x)
                    {
                        swFiserText.WriteLine(p.ConversieLaSir());
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch(Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
        }

        public List<Incaltaminte> GetIncaltaminte()
        {
            List<Incaltaminte> inca = new List<Incaltaminte>();
            try
            {
                using (StreamReader sr = new StreamReader(NumeFisier))
                {
                    string linie;
                    while ((linie = sr.ReadLine()) != null)
                    {
                        Incaltaminte x = new Incaltaminte(linie);
                        inca.Add(x);
                    }
                }
            }
            catch(IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch(Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

            return inca;
        }

        public void UpdateIncaltaminte(Incaltaminte x, int index)
        {
            List<Incaltaminte> Inc = GetIncaltaminte();
            int indexIncaltaminte = 0;

            try
            {
                using (StreamWriter swFisierText = new StreamWriter(NumeFisier,false))
                {
                    foreach(Incaltaminte s in Inc)
                    {
                        if(indexIncaltaminte == index)
                        {
                            swFisierText.WriteLine(x.ConversieLaSir());
                        }
                        else
                        {
                            swFisierText.WriteLine(s.ConversieLaSir());
                        }
                        indexIncaltaminte++;
                    }
                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch(Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }

        }

        public List<Incaltaminte> GetIncaltaminteIndex(int index)
        {
            List<Incaltaminte> inca = new List<Incaltaminte>();

            try
            {
                using(StreamReader sr = new StreamReader(NumeFisier))
                {
                    string linie;
                    int nrIncaltaminte = 0;
                    while((linie = sr.ReadLine())!=null)
                    {
                        Incaltaminte w = new Incaltaminte(linie);
                        inca.Add(w);
                        if(nrIncaltaminte == index)
                        {
                            return inca;
                        }
                        nrIncaltaminte++;
                    }

                }
            }
            catch (IOException eIO)
            {
                throw new Exception("Eroare la deschiderea fisierului. Mesaj: " + eIO.Message);
            }
            catch (Exception eGen)
            {
                throw new Exception("Eroare generica. Mesaj: " + eGen.Message);
            }
            return null;
        }
    }
}
