using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NivelAcces
{
    public static class IStocareFactoryIncaltaminte
    {
        private const string FORMAT_SALVARE = "FormatSalvare";
        private const string NUME_FISIER = "NumeFisierMasini";
        public static IStocareDataIncaltaminte GetAdministratorStocare()
        {
            var formatSalvare = ConfigurationManager.AppSettings[FORMAT_SALVARE];
            var numeFisier = ConfigurationManager.AppSettings[NUME_FISIER];
            if (formatSalvare != null)
            {
                switch (formatSalvare)
                {
                    default:
                    case "bin":
                        return new AdministrareIncaltaminte_FisierBinar(numeFisier + "." + formatSalvare);
                    case "txt":
                        return new AdministrareIncaltaminte_FisierText(numeFisier + "." + formatSalvare);
                }
            }

            return null;
        }
    }
}
