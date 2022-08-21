using Domain.Interfaces;
using Infrastructure.Commands;
using Infrastructure.Commands.AddSportTraining;
using Infrastructure.Interfaces;
using Infrastructure.Mapper;
using Infrastructure.Persistence.Repositories;
using Infrastructure.Queries.GetAllSportTraining;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Extensions
{
    public static class DependencyInjectionExtension
    {
        public static void AddAutomapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MainMapper));
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            var repositories = typeof(SportTrainingRepository).Assembly.GetTypes()
                .Where(x => x.Name.EndsWith("Repository") && !x.GetTypeInfo().IsAbstract).ToList();

            foreach (var repository in repositories)
            {
                foreach (var interfaceRepo in repository.GetInterfaces())
                {
                    services.AddScoped(interfaceRepo, repository);
                }
            }
            return services;
        }

        public static IServiceCollection AddCommandHandlers(this IServiceCollection services)
        {
            services.AddScoped<ICommandDispatcher, CommandDispatcher>();

            var handlerTypes = typeof(CommandDispatcher).Assembly.GetTypes()
                .Where(x => !x.IsInterface && 
                            !x.IsAbstract && 
                            x.GetInterfaces().Any(y => y.Name.Equals(typeof(IHandle<>).Name, StringComparison.InvariantCulture) 
                            || y.Name.Equals(typeof(IHandle<,>).Name, StringComparison.InvariantCulture)
                            || y.Name.Equals(typeof(IHandleAsync<>).Name, StringComparison.InvariantCulture))).ToList();

            foreach (var type in handlerTypes)
            {
                foreach (var myInterface in type.GetInterfaces())
                {
                    services.AddScoped(myInterface, type);
                }
            }
            return services;        
        }

        public static IServiceCollection AddQueries(this IServiceCollection services)
        {
            var queries = typeof(GetAllSportTrainingQuery).Assembly.GetTypes()
                .Where(x => !x.IsInterface &&
                            !x.IsAbstract &&
                            x.GetInterfaces().Any(y => y.Name.Equals(typeof(IQuery<>).Name, StringComparison.InvariantCulture)
                            || y.Name.Equals(typeof(IQuery<,>).Name, StringComparison.InvariantCulture)
                            || y.Name.Equals(typeof(IQueryAsync<>).Name, StringComparison.InvariantCulture)
                            || y.Name.Equals(typeof(IQueryAsync<,>).Name, StringComparison.InvariantCulture))).ToList();

            foreach (var query in queries)
            {
                foreach (var myInterface in query.GetInterfaces())
                {
                    services.AddScoped(myInterface, query);
                }
            }
            return services;
        }
    }
}
