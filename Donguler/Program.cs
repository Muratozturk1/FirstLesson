// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*for (int i = 0; i < 10; i++) 
{
    Console.WriteLine(i);
}*/
string kurs1 = "Yazılım Geliştirici Yetiştirme Kmampı";
string kurs2 = "Programlamaya Başlangıç için Temel Kurs";
string kurs3 = "Java";

/*Aşağıdaki sistemi Genelde gerçek hayatta iş ortamında şu şekil tutarız
string[] kurslar = kurslariGetir();*/
string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kmampı","Programlamaya Başlangıç için Temel Kurs", "Java" };
for (int i = 0; i < kurslar.Length; i++) 
{
    Console.WriteLine(kurslar[i]);
}

foreach (string kurs in kurslar) 
{
    Console.WriteLine(kurs);
}
Console.WriteLine(400/15);

