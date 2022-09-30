using DEVinCar.Domain.Models;
using Escola.Domain.Interfaces.Repositories;

namespace DEVinCar.Infra.Datas.Repositories
{
    public class UserRepositorie : IUserRepositorie
    {
        private readonly DevInCarDbContext _context;
        public UserRepositorie(DevInCarDbContext context)
        {
            _context = context;
        }

        public void Atualizar(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public void Excluir(User user)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
                
        public void Inserir(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public User ObterPorId(int id)
        {
            return _context.Users.Find(id);
        }

        public IList<User> ObterTodos()
        {
            return _context.Users.ToList();
        }
    }
}
