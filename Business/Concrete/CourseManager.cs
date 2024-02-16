using System;
using System.Collections.Generic;
using Kodlama_IO_Odev2.Business.Abstract;
using Kodlama_IO_Odev2.DataAccess.Abstract;
using Kodlama_IO_Odev2.DataAccess.Concrete;

namespace Kodlama_IO_Odev2.Entitiy.Concrete
{
    public class CourseManager : ICourseService
    {
        private ICoursesDAL _courseDal;


        public CourseManager(ICoursesDAL courseDal)
        {
            _courseDal = courseDal;
        }
        public void Add(Course item)
        { 
            _courseDal.Add(item);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }
    }
}
