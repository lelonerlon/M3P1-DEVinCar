using DEVinCar.Domain.DTOs;
using DEVinCar.Domain.Interfaces.Repositories;
using DEVinCar.Domain.Interfaces.Services;
using DEVinCar.Domain.Models;

namespace DEVinCar.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepositorie _userRepositorie;
        public UserService(IUserRepositorie userRepositorie)
        {
            _userRepositorie = userRepositorie;
        }

        public void Atualizar(User user)
        {
            throw new NotImplementedException();
        }

        public void Excluir(User user)
        {
            throw new NotImplementedException();
        }

        public bool ExisteMatricula(int matricula)
        {
            throw new NotImplementedException();
        }

        public void Inserir(User user)
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            return _userRepositorie.GetById(id);
        }

        public IList<UserDTO> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}