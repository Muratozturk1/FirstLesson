using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetManager
    {
        //naming convention doğru yazma tekniği class ve sınıfların baş harfı büyük
        public void Add(Product product) 
        {
            Console.WriteLine("Sepete Eklendi " +product.Name);

        }
        public void Ekle2(string name,double price,string description)
        {
            Console.WriteLine(name);
        }
    }
}
