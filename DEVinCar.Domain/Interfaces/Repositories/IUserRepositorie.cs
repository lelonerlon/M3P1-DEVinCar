﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DEVinCar.Domain.Models;


namespace DEVinCar.Domain.Interfaces.Repositories
{
    public interface IUserRepositorie
    {
        IList<User> ObterTodos();
        User GetById(int id);
        void Inserir(User user);
        void Excluir(User user);
        void Atualizar(User user);

    }
}
