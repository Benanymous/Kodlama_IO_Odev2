using Kodlama_IO_Odev2.Entitiy.Abstract;

namespace Kodlama_IO_Odev2.Entitiy.Concrete
{
    public class Course: IEntitiy
    {
        public Course(int id, string title, string description, int instructorId,string instructor, int categoryId, double price)
        {
            Id = id;
            Title = title;
            Description = description;
            InstructorId = instructorId;
            Instructor = instructor;
            CategoryId = categoryId;
            Price = price;
        }

        public Course()
        {
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int InstructorId { get; set; }
        public string Instructor { get; set; }
        public int CategoryId { get; set; }
        public double Price { get; set; }
    }
}
