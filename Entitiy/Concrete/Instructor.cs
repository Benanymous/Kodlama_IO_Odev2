using Kodlama_IO_Odev2.Entitiy.Abstract;

namespace Kodlama_IO_Odev2.Entitiy.Concrete
{
    public class Instructor: IEntitiy
    {
        public int Id { get; set; }
        public int InstructorId { get; set; }
        public string InstructorName { get; set; }
    }
}
