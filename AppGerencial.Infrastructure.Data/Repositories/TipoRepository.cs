using AppGerencial.Domain.Entities;
using AppGerencial.Domain.Interfaces;
using AppGerencial.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppGerencial.Infrastructure.Data.Repositories
{    
    public class TipoRepository : BaseRepository<EntityTipo>, ITipoRepository
    {
        public TipoRepository(AjusteProcessoContext context)
            : base(context)
        {

        }

        public EntityTipo GetByName(string nome)
        {
            return DbSet.AsNoTracking().FirstOrDefault(c => c.Tipo == nome);
        }

        public EntityTipo VerifyExist(int id)
        {
            return DbSet.AsNoTracking().FirstOrDefault(c => c.Id == id);
        }
    }
}
