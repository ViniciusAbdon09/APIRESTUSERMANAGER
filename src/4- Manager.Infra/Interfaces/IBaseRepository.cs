using Manager.Domain.Entities;
using System.Threading.Tasks; //para utilizar os metodos async task
using System.Collections.Generic;
namespace Manager.Infra.Interfaces
{    
    public interface IBaseRepository<T> where T : Base // T é qualquer entidade que seja BASE ou seja todas as classes que herdarem da classe base
    {
         Task<T> Create(T obj);
         Task<T> Update(T obj);
         Task Remove(long id);
         Task<T> Get(long id);
         Task<List<T>> Get();
    }
}