using ÖDEV1.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖDEV1.Cars
{
    class Mercedes:Arabalar,Yetenek2,Yetenek3

    {

        public void Yuzme(string isim)
        {
            Console.WriteLine(isim + " deniz de yüzer");

        }
        public void Ucmak(string isim)
        {

            Console.WriteLine(isim + " hava da uçar");
        }

    }
}
