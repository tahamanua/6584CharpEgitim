Console.WriteLine("Metotlar");

void ToplamaYap() //void metotlar geriye değer döndürmez. Sadece görevini yapar. // void tek iş yapar
{
    Console.WriteLine(10 + 8);

}
    
ToplamaYap();


void ToplamaYapParametreli(int sayi1, int sayi2) // metotlardan dışarıdan parametre gönderilerek kullanılabiilir.

{
    Console.WriteLine("Toplama Sonucu : ");
    Console.WriteLine( sayi1 + sayi2);

}
ToplamaYapParametreli(18, 34);
ToplamaYapParametreli(sayi2: 18, sayi1: 25);
ToplamaYapParametreli(sayi1: 825, sayi2: 53); // dilersek parametre isimlerini kullanarak belli edebiliriz

int ToplamaParametreli(int sayi1, int sayi2) // metot isminin önüne void yerine herhangi bir veri 
    // tipte değer dönüştürebilirz

{
    // eğer bir metot geriye değer döndürüyorsa metot içersinde (return) ifadesiyle bir değer döndürmeliyiz.
    return sayi1 + sayi2;// bu metotda gönderiecek değerleri topla ve bu toplam sonucu kullanılacağı yere gönder


}
Console.WriteLine("Değer Döndüren Toplama Sonucu : ");
 int İslemSonucu = ToplamaParametreli(8, 5); // toplama işleminin sonucunu bize getiren metodun
// getirdiği toplam değeri İslemSonucu değişkene aktardık.
Console.WriteLine(İslemSonucu);    // işlem sonucunu ekrana yazdırır

bool MailGönder (string email)
{
    // burada ki örnek mail gönderin
    // kod alanı
    if (email != "") // eğer mail değişkeni boş değilse
    {
        // mail gönderin kodlarını çalıştır
        // ve mail gönder
        return true; // geriye de mail gönderebildiğini anlayabilmemiz içinbize true döndür
    }
    return false; // if bloğu çalışmamışsa metot buraya kadar gelecek ve geriye false değeri döndürecek 
    //bizde mail gönderim işinin başarısız olduğunu anlayacağız.
}


Console.WriteLine("Mail Adresinizi Giriniz");
var mail = Console.ReadLine();

var sonuc = MailGönder(mail); //var ile metottan dönen veri tipini (bool) ile oto belirliyoruz.
if (sonuc == true)
    Console.WriteLine("Mailiniz Başarıyla Gönderildi");
else 
        Console.WriteLine("Mailiniz Gönderilmedi");
