using Manager.Domain.Entities;
using Manager.Infra.Interfaces;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq; // para utilizar o where
using Manager.Infra.Context;

namespace Manager.Infra.Repositories
{
    //metodos genericos
    public class BaseRepository<T> : IBaseRepository<T> where T : Base
    {
        private readonly ManagerContext _context; //recebedo via injeção de dependencia um contexto

        public BaseRepository(ManagerContext context)
        {
            _context = context;
        }

        // quando um metodo é virtual significa que ele pode ser sobreescrito
         public virtual async Task<T> Create(T obj){
             _context.Add(obj); // usa o contexto pra adicionar o obj
             await _context.SaveChangesAsync(); // salva o objeto de forma assisncrona

             return obj;
         }

         public virtual async Task<T> Update(T obj){
             _context.Entry(obj).State = EntityState.Modified; // diz que o estado do objeto foi modificado e o EF entende que é um upadate
             await _context.SaveChangesAsync();

             return obj;
         }

         public virtual async Task Remove(long id){
             var obj = await Get(id); // verificando se existe o registro no banco

             if(obj != null){
                _context.Remove(obj);
                await _context.SaveChangesAsync();
             }
         }

        public virtual async Task<T> Get(long id){
            var obj = await _context.Set<T>()
                                    .AsNoTracking() // para não mapiar o objeto no banco
                                    .Where(x => x.Id == id )
                                    .ToListAsync();

            return obj.FirstOrDefault(); // retorna o primeiro
        }

        public virtual async Task<List<T>> Get(){
            return await _context.Set<T>()
                                .AsNoTracking()
                                .ToListAsync();
        }
    }
}