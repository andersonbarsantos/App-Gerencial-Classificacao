using AppGerencial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppGerencial.Domain.Interfaces
{
    public interface ITipoRepository : IRepository<EntityTipo>
    {
        EntityTipo GetByName(string nome);
        EntityTipo VerifyExist(int id);
    }
}
