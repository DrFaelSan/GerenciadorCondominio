using GerenciadorCondominios.DAL.Interfaces;
using GerenciadorCondominios.DAL.Repositorios;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace GerenciadorCondominios.DAL
{
    public static class ConfiguracaoRepositoriosExtension
    {
        public  static void ConfigurarRepositorios(this IServiceCollection services)
        {

            //Injeção de Indepêndencia.
            services.AddTransient<IUsuarioRepositorio, UsuarioRepositorio>();
            services.AddTransient<IFuncaoRepositorio, FuncaoRepositorio>();
        }


    }
}
