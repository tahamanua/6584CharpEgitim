// See https://aka.ms/new-console-template for more information
Console.WriteLine("Döngüler!");

Console.WriteLine("For Döngüsü");
int veritabanindangelenürünsayisi = 5;


for (int i = 0; i < 6; i++)

   
{
    Console.WriteLine("i nin değeri : " + i);

}

Console.WriteLine("While Döngüsü");

int j = 0;   // değişkeni dışarıda tanımladık
while (j < 6)  // şart koştuk
{
    Console.WriteLine("j nin değeri : " +  j);
    j++; // değişkenin değerini bir arttırıyoruz ki sonsuz döngüye girmesin
}

Console.WriteLine(" Do While Döngüsü");

int toplam = 10;
do
{
    Console.WriteLine("toplamın değeri : " + toplam);
    toplam++;
} while (toplam < 10);

Console.WriteLine("Foreach Döngüsü");

string[] kategoriler = { "Elekronik", "Bilgisayar", "telefon" };

foreach (var kategori1 in kategoriler) // diziler için en kullanışlı döngü
{
    Console.WriteLine("Kategori Adı : " + kategori1);
}

string[] urunler = { "Ürün 1", "Ürün 2", "Ürün 3" };

foreach (var kategori1 in kategoriler) // diziler için en kullanışlı döngü
{
    Console.WriteLine("Kategori Adı : " + kategori1);
    foreach (var urun in urunler) // diziler için en kullanışlı döngü
    {
        Console.WriteLine("\t Ürün Adı : " + urun);
    }


}



