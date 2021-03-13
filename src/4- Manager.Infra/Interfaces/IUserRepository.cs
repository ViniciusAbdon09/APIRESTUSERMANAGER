using Manager.Domain.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Manager.Infra.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {   
        Task<User> GetByEmail(string email); //Busca um usuario por um emeil especifico
        Task<List<User>> SearchByEmail(string email); // Busca usuarios com parte, que contenha no email
        Task<List<User>> SearchByName(string name); // Busca usuarios que contenham o nome ou parte
    }
}