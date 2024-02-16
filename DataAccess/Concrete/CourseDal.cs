using System;
using System.Collections.Generic;
using Kodlama_IO_Odev2.DataAccess.Abstract;
using Kodlama_IO_Odev2.Entitiy.Concrete;

namespace Kodlama_IO_Odev2.DataAccess.Concrete
{
    public class CourseDal : ICoursesDAL
    {
        List<Course> _courses = new List<Course>();

        public void Add(Course course)
        {
            Console.WriteLine($"***** YENİ KURS EKLENİYOR... *****\n" +
                              $"--KURS ID: {course.Id}\n" +
                              $"-- KURS ADI: {course.Title}\n" +
                              $"-- KURS AÇIKLAMA: {course.Description}\n" +
                              $"-- KURS HOCA :{course.Instructor}\n" +
                              $"-- KURS FİYATI: {course.Price}");
            _courses.Add(course);
            Console.WriteLine("\n=> YENİ KURS EKLENDİ ...\n\n");
        }

        public List<Course> GetAll()
        {
            Console.WriteLine("****>> KURSLAR <<****\n");
            _courses.ForEach(c => Console.WriteLine(
                $"-- KURS ADI: {c.Title}\n" +
                $"-- KURS AÇIKLAMA: {c.Description}\n" +
                $"-- KURS HOCA: {c.Instructor}\n" +
                $"-- KURS FİYATI: {c.Price}\n\n" +
                $"Toplam Kurs Sayısı: {_courses.Count}"));


            return null;
        }
    }
}
