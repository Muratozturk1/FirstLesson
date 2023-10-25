// See https://aka.ms/new-console-template for more information
using LearnClass;

Console.WriteLine("Hello, World!");

Kurs kurs1 = new Kurs();
kurs1.egitmeni = "Abdullah Çatlı";
kurs1.kursAdi = "C#";
kurs1.izleyiciSayisi = 123;

Kurs kurs2 = new Kurs();
kurs2.egitmeni = "Tolunay Ören";    // Burada Mesela Tek Tek Tanımladıktan sonra hepsine ayrcı ayrı consol writline yazmak                                            
kurs2.kursAdi = "Java";             // yerine dizi şeklinde tutup bi kerede döndürebiliriz
kurs2.izleyiciSayisi = 102;

Kurs kurs3 = new Kurs();
kurs3.egitmeni = "Tadic";
kurs3.kursAdi = "Python";
kurs3.izleyiciSayisi = 98;

Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };
foreach (Kurs kurs in kurslar) 
{
    Console.WriteLine(kurs.kursAdi);
    Console.WriteLine(kurs.egitmeni);
    Console.WriteLine(kurs.izleyiciSayisi);
    Console.WriteLine("*********************");
}



