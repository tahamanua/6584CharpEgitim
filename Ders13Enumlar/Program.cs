namespace Ders13Enumlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enumlar!");
            Console.WriteLine("Enumaratorler nesneleri numaralandırmak için kullanılır");
            Console.WriteLine("İçersinde metot tanımlanamaz");
            Console.WriteLine("Arayüz(iterface)kullanamazlar");
            Console.WriteLine("Enum İçersinde property kullanılmaz");
            byte a = (byte)Meyveler.Karpuz;
            byte b = (byte)Meyveler.Portakal;
            byte c = (byte)Meyveler.Çilek;
            
            Console.WriteLine($"Meyveler : Karpuz = {a} , Portakal = {b} , Çilek = {c} ");
            Console.WriteLine($"Meyveler : Karpuz ={Meyveler.Karpuz}, Portakal = {Meyveler.Portakal}, Çilek = {Meyveler.Çilek} ");

            int SiparisDurum = 1;
            if (SiparisDurum == 0)
            {
               Console.WriteLine("Sipariş Durumu : " + SiparisDurumu.OnayBekliyor);
            }
            if (SiparisDurum == 1)
            {
               Console.WriteLine("Sipariş Durumu : " + SiparisDurumu.Onaylandı);
            }
            if (SiparisDurum == 2)
            {
               Console.WriteLine("Sipariş Durumu : " + SiparisDurumu.Hazırlanıyor);
            }
            if (SiparisDurum == 3)
            {
               Console.WriteLine("Sipariş Durumu : " + SiparisDurumu.KargoyaVerildi);
            }

        }
        enum Aylar : byte
        {
            Ocak , Şubat , Mart , Nisan , Mayıs , Haziran , Temmuz , Ağustos , Eylül , Ekim , Kasım , Aralık
        }
        enum CalisilanGunler 
        {
            Pazartesi , Salı , Çarşamba , Perşembe , Cuma
        }
        enum SiparisDurumu
        {
            OnayBekliyor , Onaylandı , Hazırlanıyor , KargoyaVerildi
        }
        enum Meyveler : int
        {
            Çilek = 3 , Karpuz = 1 , Portakal = 5 , // sıra numarası verebiliriz 
        }
    }
}