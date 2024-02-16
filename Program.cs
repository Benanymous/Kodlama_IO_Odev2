using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kodlama_IO_Odev2.Business.Abstract;
using Kodlama_IO_Odev2.DataAccess.Concrete;
using Kodlama_IO_Odev2.Entitiy.Concrete;

namespace Kodlama_IO_Odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Course course = new Course(1,
                "C# KURSU",
                "Uygulamalar ile C#",
                2,
                "Murat Emre Ateş",
                1,
                0);

            Course course2 = new Course(1,
                "C# KURSU",
                "C# Form Uygulamaları",
                1,
                "Engin Demiroğ",
                2,
                0);
            ICourseService manager = new CourseManager(new CourseDal());
            manager.Add(course);
            manager.Add(course2);
            manager.GetAll();



            Console.ReadLine();
        }
    }
}
