

namespace Entities
{
    public class Kategori : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Urun>? Urunler { get; set; } // 1 kategori 1 den çok  ürünü olabilir buna 1 e çok ilişki denir 
        // ? işareti ile bu listeyi nullable yani boş da olabilir hale getirmiş oluruz.
    }
}
