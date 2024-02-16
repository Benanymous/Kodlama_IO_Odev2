using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_IO_Odev2.Business.Abstract
{
    public interface IBusinessRespository<T>
    {
        void Add(T item);
        List<T> GetAll();
    }
}
