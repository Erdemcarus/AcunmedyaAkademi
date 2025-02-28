using ÖDEV1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖDEV1.Cars
{
    class Porsche:Arabalar,Yetenek2
    {
        public void Ucmak(string isim)
        {
            Console.WriteLine(isim + "hava da uçar ");

        }

    }
}
