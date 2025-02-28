using ÖDEV2.MAAŞLAR;

GenelMüdür Gm = new GenelMüdür();
Müdür M = new Müdür();
Programci P = new Programci();
Stajyer A = new Stajyer();

double toplamMaas = 0.0;

toplamMaas += Gm.MaasYazdir();
toplamMaas += M.MaasYazdir();
toplamMaas += P.MaasYazdir();
toplamMaas += A.MaasYazdir();

Console.WriteLine("TOPLAM MAAŞLAR = " + toplamMaas+" TL");