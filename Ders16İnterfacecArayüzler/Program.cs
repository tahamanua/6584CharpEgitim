namespace Ders16İnterfacecsArayüzler
{

    interface OrnekArayuz // class yerine interface yazıyoruz 
    {
        public int Id { get; set; }
    }
    interface IDemo
    {
        void Goster(); // interface de metot imzası tanımlama
    }
    interface icerebildikleri : IDemo
    {
        public int Sayi1 { get; set; }
        int sayi { get; set; }
        static int sayi2 { get; set; }
        void Topla();
        int ToplamaYap();
    }
    class ArayüzKullanımı : icerebildikleri //bir interface den class a kalıtım yaparsak interface deki hiçbir şey class ta kullanılmka zorunda olur.
                                            //İnterfacein üzerine gelip implement interface demeliyiz.
    {
        public int Sayi1 { get; set; }
        int icerebildikleri.sayi { get; set; }

        public void Goster()
        {
            Console.WriteLine(Sayi1);
        }

        public void Topla()
        {
            throw new NotImplementedException();
        }

        public int ToplamaYap()
        {
            throw new NotImplementedException();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İnterfacecs - Arayüzler!");
            ArayüzKullanımı arayüzKullanımı = new();
            arayüzKullanımı.Sayi1 = 18;
            arayüzKullanımı.Goster();
        }
    }
    interface ISinifGereksinimleri
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Description { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public DateTime GuncellemeTarihi { get; set; }

    }
    interface IVeriTabaniIslemleri
    {
        void Add();
        void Update();
        void Delete();
        void Get();
        void GetAll();


    }
    class Urun : ISinifGereksinimleri, IVeriTabaniIslemleri
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Description { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public DateTime GuncellemeTarihi { get; set; }
        public int Stok { get; set; }
        public decimal Fiyat { get; set; }
        public String Resim { get; set; }

        public void Add()
        {
            Console.WriteLine(Name + "Eklendi!");
        }

        public void Delete()
        {
            throw new NotImplementedException(Name + "Silindi!");
        }

        public void Get()
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
    class Kategori : ISinifGereksinimleri , IVeriTabaniIslemleri
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int Description { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public DateTime GuncellemeTarihi { get; set; }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Get()
        {
            throw new NotImplementedException();
        }

        public void GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
        public void Yazdır()
        {
            throw new NotImplementedException();
        }
    }
}