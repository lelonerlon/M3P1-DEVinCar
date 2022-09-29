using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DEVinCar.Domain.Interfaces.Repositories;
using DEVinCar.Domain.Models;

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
            _contexto.Alunos.Update(user);
            _contexto.SaveChanges();
        }

        public void Excluir(User aluno)
        {
            _contexto.Alunos.Remove(aluno);
            _contexto.SaveChanges();
        }

        public bool ExisteMatricula(int matricula)
        {
            return _contexto.Alunos.Any(x => x.Matricula == matricula);
        }

        public void Inserir(User aluno)
        {
            _contexto.User.Add(aluno);
            _contexto.SaveChanges();
        }

        public Aluno ObterPorId(int id)
        {
            return _contexto.User.Find(id);
        }

        public IList<Aluno> ObterTodos()
        {
            return _contexto.User.ToList();
        }
    }
}
