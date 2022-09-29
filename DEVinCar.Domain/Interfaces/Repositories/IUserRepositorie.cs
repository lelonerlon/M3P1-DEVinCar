using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DEVinCar.Domain.Models;


namespace Escola.Domain.Interfaces.Repositories
{
    public interface IUserRepositorie
    {
        IList<User> ObterTodos();
        User ObterPorId(Guid id);
        void Inserir(User aluno);
        void Excluir(User aluno);
        void Atualizar(User aluno);
        bool ExisteMatricula(int matricula);
    }
}
