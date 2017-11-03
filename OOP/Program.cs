using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Dom mojDom = new Dom("Activ 1", "aktivni", "nie", 3, 70.9f, 35.8f);
            mojDom.PoskytniInformacie();
            Console.WriteLine("Percento zastavanej plochy je {0}", mojDom.ZistiVyuzitelnostZastavanejPlochy());

            Dom susedovDom = new Dom("Activ 2", "aktivni", "nie", 3, 70.9f, 35.8f);
            susedovDom.PoskytniInformacie();
            Console.WriteLine("Percento zastavanej plochy je {0}", susedovDom.ZistiVyuzitelnostZastavanejPlochy());

            Chata chata = new Chata("chata 1", "pasivna", "10", 50, 200.5f, 100, "ano a velka");
            chata.PoskytniInformacie();

            Console.ReadLine();

        }
    }
}
