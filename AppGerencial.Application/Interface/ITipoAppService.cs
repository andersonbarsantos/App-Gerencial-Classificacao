using AppGerencial.Application.ViewModels;
using AppGerencial.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppGerencial.Application.Interface
{
    public interface ITipoAppService : IDisposable
    {
        void Add(TipoViewModel tipoViewModel);
        void Update(TipoViewModel tipoViewModel);
        void Delete(int id);
        IQueryable<TipoViewModel> SelectAll();
        TipoViewModel SelectById(int id);
    }
}
