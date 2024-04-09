using Crud_Win_Forms_Pessoa.Repositories;
using Crud_Win_Forms_Pessoa.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using WindowsForms_Crud;
using WindowsForms_Crud.Repositories;

namespace Crud_Win_Forms_Pessoa
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //            ServiceCollection services = new ServiceCollection();
            //            services.AddSingleton<IPersonService, PersonService>();
            //            services.AddSingleton<IPersonRepository, PersonRepository>();
            //            using ServiceProvider provider = services.BuildServiceProvider();

            var service = new PersonService(new PersonRepository());

            Application.Run(new Frm_Crud_Pessoa(service));
        }
    }
}