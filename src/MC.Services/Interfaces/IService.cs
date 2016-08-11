using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MC.Services.Interfaces
{
    public interface IService<T, in TK>
    {
        IEnumerable<T> GetAll();
        T GetSingle(TK entityKey);
        T Add(T job);
        void Delete(T job);
        T Edit(T job);
    }
}