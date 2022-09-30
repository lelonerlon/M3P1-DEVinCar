using DEVinCar.Domain.DTOs;
using DEVinCar.Domain.Models;

namespace DEVinCar.Domain.Interfaces.Services
{
    public interface IUserService
    {
        IList<UserDTO> ObterTodos();
        User GetById(int id);
        void Inserir(User user);
        void Excluir(User user);
        void Atualizar(User user);
        bool ExisteMatricula(int matricula);
    }
}