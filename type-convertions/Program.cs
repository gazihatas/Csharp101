// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



/* 
 * Implicit Conversion (Bilinçsiz Dönüşüm)
 * Tanım : Düşük kapasiteli bir değişkenin  kendinden daha yüksek kapasiteli başka bir değişkene atanma işlemidir.
 * Çevirim işlemini sizin yerinize makine yapar.
*/
Console.WriteLine("***** Implicit Conversion *****");
byte a = 5;
sbyte b = 30;
short c = 10;

int d = a + b + c; //integer veri tipi diğer veri tiplerinden daha fazla kapasitesi vardır, arada bir kapasite uyumsuzluğu olsaydı atama işlemi olmazdı.
Console.WriteLine("d:" + d);

long h = d;
Console.WriteLine("h:" + h);

float i = h;
Console.WriteLine("i:" + i);

string e = "Gazi";
char f = 'h';
object g = e + f + d;
Console.WriteLine("g:" + g);



/*
 * Explicit Conversion (Bilinçli Dönüşüm)
 * Tanım: C#'ın kendi kednine yapamayacağı dönüşümlerdir. Convert ve Parse kullanarak derleyiciye dönüşümleri ifade ederiz
 * 
*/
Console.WriteLine("***** Explicit Conversion *****");

int x = 4;
byte y = (byte)x;
Console.WriteLine("y:" + y);

int z = 100;
byte t = (byte)z;
Console.WriteLine("t:" + t);

float w = 10.3f;//çevirimlerde veri kaybı olabilir
byte v = (byte)w;
Console.WriteLine("v:" + v);

// **** ToString Metodu *****
Console.WriteLine("***** ToString Metodu *****");
int xx = 6;
string yy = xx.ToString();
Console.WriteLine("yy:" + yy);

string zz = 1.5f.ToString();
Console.WriteLine("zz:" + zz);

//Sytem.Convert
Console.WriteLine("***** System.Convert sınıfı *****");
string s1 = "10", s2 = "20";
int sayi1, sayi2;
int Toplam;

sayi1 = Convert.ToInt32(s1);
sayi2 = Convert.ToInt32(s2);

Toplam = sayi1 + sayi2;
Console.WriteLine("Toplam:" + Toplam);

//Parse
Console.WriteLine("***** Parse *****");