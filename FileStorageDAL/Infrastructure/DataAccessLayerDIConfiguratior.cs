using System;
using System.Collections.Generic;
using System.Text;
using FileStorageDAL.Data;
using FileStorageDAL.Interfaces;
using FileStorageDAL.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace FileStorageDAL.Infrastructure
{
    public class DataAccessLayerDIConfiguratior
    {
        public static void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<FileStorageDbContext>();
            serviceCollection.AddTransient<IFileRepository, FileRepository>();
            serviceCollection.AddTransient<IFolderRepository, FolderRepository>();
            serviceCollection.AddTransient<IUserRepository, UserRepository>();
            serviceCollection.AddTransient<IUserRoleRepository, UserRoleRepository>();
            serviceCollection.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
