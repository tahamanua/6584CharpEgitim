
/*
 *  public : yazdığımız kod bloğuna proje nin her yerinden erişebilmemizi sağlar
 *  protected : ait olduğu sınıftan ve o sınıftan  türetilen sınıflardan erişilebilir
 *  internal : Etkin projeye ait sınıflardan erişilebilir.
 *  private : yalnızca bulunduğu sınıftan erişilebilir.
 *  1 öğe sadece 1 tane erişim belirteci alabiliyor.
 *  
 */
// bir projeden  örneğin ( Ders09ErisimBelirleyiciler) solition içersindeki başka bir projeye 
// örneğin (Ders08Classlar) erişmek için 2 proje arasında bağlantı kurmalıyız.
// bu bağlantıyı projemizdeki  dependencies e sağ tıklayıp add project reference a tıklayıp açılan
// pencerede bağlanmak istediğimizx projeye tik atıp tamam diyerek bağlantı kurabiliriz.

using Ders08Classlar;
using Ders09ErisimBelirleyiciler; // bu satır kullanıcı classını bu sayfada kullanabilmemiz için

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Erişim Belirleyiciler");
        Kategori kategori = new Kategori();
        //kategori. Kategori class ı içersindeki  değişkene erişim belirteci verilmediği için buradan erişemiyoruz.
        kategori.Adi = "Bilgisayar";

       Urun urun = new Urun();
        urun.Adi = "Monitör";
        urun.Fiyati = 9999;
        // urun .   diğerlerine burdan erişemiyoruz.
        Console.WriteLine($"Ürün Bilgileri : \n Ürün Kategorisi : {kategori.Adi}  \n Ürün Adı : {urun.Adi} \n Ürün Fiyati : {urun.Fiyati} TL");
        Console.WriteLine();

        Kullanici kullanici = new()
        {
            Adi = "Ali", SoyAdi = "Can" 
        };
        SiniftaMetotKullanimi siniftaMetot = new(); // bu class Ders08Classlar projesinden geldi
       var sonuc = siniftaMetot.LoginKontrol(kullanici.Adi,kullanici.SoyAdi);
        Console.WriteLine("Login Sonucu : " + sonuc);
    }        


}

class Kategori
{

    public string Adi; // Her yerden erişilebilir.
    string Aciklamasi; // sadece bu class dan erişim sağlayabiliriz.
}





class Urun
{
    private int Id; // gizli sadece bu classtan erişim sağlanabilir.
    internal string Adi; // bu projede erişilebilir
    protected string Aciklamasi; // bu sınıf ve miras alındığı yerde 
    public decimal Fiyati;// her yerden erişim sağlanabilir.

}