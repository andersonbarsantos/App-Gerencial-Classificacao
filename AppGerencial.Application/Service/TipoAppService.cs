using AppGerencial.Application.Interface;
using AppGerencial.Application.ViewModels;
using AppGerencial.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using AppGerencial.Domain.Entities;

namespace AppGerencial.Application.Service
{
    public class TipoAppService : ITipoAppService
    {
        private readonly IMapper _mapper;
        private readonly ITipoRepository _tipoRepository;
        //private readonly IEventStoreRepository _eventStoreRepository;
        //private readonly IMediatorHandler Bus;

        public TipoAppService(    IMapper mapper,
                                  ITipoRepository tipoRepository
                                  //,IMediatorHandler bus
                                  //,IEventStoreRepository eventStoreRepository
            )
        {
            _mapper = mapper;
            _tipoRepository = tipoRepository;
            //Bus = bus;
            //_eventStoreRepository = eventStoreRepository;
        }

        public IQueryable<TipoViewModel> SelectAll()
        {
            return _tipoRepository.SelectAll().ProjectTo<TipoViewModel>(_mapper.ConfigurationProvider);
        }

        public TipoViewModel SelectById(int id)
        {
            return _mapper.Map<TipoViewModel>(_tipoRepository.SelectById(id));
        }

        public void Add(TipoViewModel tipoViewModel)
        {
            var AddCommand = _mapper.Map<EntityTipo>(tipoViewModel);
            // Bus.SendCommand(AddCommand);
            //if (ModelState.IsValid)
            //{
                _tipoRepository.Add(AddCommand);
                _tipoRepository.SaveChanges();
              
           // }
           


        }

        public void Update(TipoViewModel tipoViewModel)
        {
            var updateCommand =  _mapper.Map<EntityTipo>(tipoViewModel);
            _tipoRepository.Update(updateCommand);
            _tipoRepository.SaveChanges();
            //Bus.SendCommand(updateCommand);

        }

        public void Delete(int id)
        {
          //  var deleteCommand = new EntityTipo(id);
            _tipoRepository.Delete(id);
            _tipoRepository.SaveChanges();
            //Bus.SendCommand(deleteCommand);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
