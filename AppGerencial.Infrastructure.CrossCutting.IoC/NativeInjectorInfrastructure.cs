using AppGerencial.Application.Interface;
using AppGerencial.Application.Service;
using AppGerencial.Domain.Interfaces;
using AppGerencial.Infrastructure.Data.Context;
using AppGerencial.Infrastructure.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AppGerencial.Infrastructure.CrossCutting.IoC
{
    public class NativeInjectorInfrastructure
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Domain Bus (Mediator)
           // services.AddScoped<IMediatorHandler, InMemoryBus>();

            // ASP.NET Authorization Polices
           // services.AddSingleton<IAuthorizationHandler, ClaimsRequirementHandler>();

            // Application
            services.AddScoped<ITipoAppService, TipoAppService>();

            // Domain - Events
            //services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();
            //services.AddScoped<INotificationHandler<CustomerRegisteredEvent>, CustomerEventHandler>();
            //services.AddScoped<INotificationHandler<CustomerUpdatedEvent>, CustomerEventHandler>();
            //services.AddScoped<INotificationHandler<CustomerRemovedEvent>, CustomerEventHandler>();

            // Domain - Commands
            //services.AddScoped<IRequestHandler<RegisterNewCustomerCommand, bool>, CustomerCommandHandler>();
            //services.AddScoped<IRequestHandler<UpdateCustomerCommand, bool>, CustomerCommandHandler>();
            //services.AddScoped<IRequestHandler<RemoveCustomerCommand, bool>, CustomerCommandHandler>();

            // Infra - Data
            services.AddScoped<ITipoRepository, TipoRepository>();
            // services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<AjusteProcessoContext>();

            // Infra - Data EventSourcing
            //services.AddScoped<IEventStoreRepository, EventStoreSqlRepository>();
            //services.AddScoped<IEventStore, SqlEventStore>();
            //services.AddScoped<EventStoreSqlContext>();

            //// Infra - Identity
            //services.AddScoped<IUser, AspNetUser>();


        }
    }
}
