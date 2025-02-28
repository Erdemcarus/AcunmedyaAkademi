using ÖDEV3.Cars;

Bmw B = new Bmw();
Mercedes M = new Mercedes();
Porsche P = new Porsche();

double ToplamYakitlar = 0.0;

ToplamYakitlar += B.ToplamYakit();
ToplamYakitlar += M.ToplamYakit();
ToplamYakitlar += P.ToplamYakit();

Console.WriteLine("TOPLAM YAKILAN YAKIT= " + ToplamYakitlar + " LT'DİR");
