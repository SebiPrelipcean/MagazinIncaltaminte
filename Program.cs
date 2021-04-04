using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazinIncaltaminte
{
    class Program
    {
        static void Main(string[] args)
        {

            Incaltaminte Adidas = new Incaltaminte("Adidas,150,5,true,model 2019,#25RF7");
            Incaltaminte Nike = new Incaltaminte("Nike", 160, 6, true, "Model 2020","#25RF6");
            Console.WriteLine(Adidas.ToString());
            Console.WriteLine(Nike.ToString());
            Console.ReadKey();
        }
    }
}
