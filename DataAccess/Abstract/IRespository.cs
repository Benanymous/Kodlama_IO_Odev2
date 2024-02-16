using System.Collections.Generic;

namespace Kodlama_IO_Odev2.Business.Abstract
{
    public interface IRespository<T> //where T:class,IEntitiy,new()
    {
        List<T> GetAll(); // Expression<Func<T,bool>> filter=null --filtre eklemek istersek
        void Add(T item);
    }
}
