using ÖDEV3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖDEV3.Cars
{
    class Mercedes : Arabalar, Interface1
    {
        public double ToplamYakit()
        {
            return 70.0;
        }
    }
}
