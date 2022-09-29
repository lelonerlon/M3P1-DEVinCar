using DEVinCar.Domain.DTOs;
using DEVinCar.Domain.Interfaces.Services;
using DEVinCar.Domain.Models;

namespace DEVinCar.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserService _alunoRepositorio;
        public UserService(IUserService alunoRepositorio)
        {
            _alunoRepositorio = alunoRepositorio;
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

        public User ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IList<UserDTO> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}