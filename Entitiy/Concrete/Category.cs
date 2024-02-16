using Kodlama_IO_Odev2.Entitiy.Abstract;

namespace Kodlama_IO_Odev2.Entitiy.Concrete
{
    public class Category:IEntitiy
    {

        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
