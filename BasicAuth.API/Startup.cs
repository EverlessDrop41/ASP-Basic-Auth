using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using BasicAuth.Repositories;
using BasicAuth.API.Requests;
using BasicAuth.API.Requests.Handler.User;
using BasicAuth.API.Requests.Handler.AccountLevel;
using BasicAuth.API.Requests.Query.User;
using BasicAuth.API.Requests.Query.AccountLevel;
using BasicAuth.DTO;
using BasicAuth.DTO.ViewModels.Users;
using BasicAuth.DTO.ViewModels.AccountLevels;

namespace BasicAuth.API
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.
            services.AddMvc();

            services.AddSingleton<AccountLevelRepository>();
            services.AddSingleton<UserRepository>();

            services.AddTransient<IQueryHandler<GetUserQuery, SingleUserDTO>, GetUserQueryHandler>();
            services.AddTransient<IQueryHandler<GetUsersQuery, UserListDTO>, GetUsersQueryHandler>();
            services.AddTransient<IQueryHandler<GetAccountLevelQuery, SingleAccountLevelDTO>, GetAccountLevelQueryHandler>();
            services.AddTransient<IQueryHandler<GetAccountLevelsQuery, AccountLevelListDTO>, GetAccountLevelsQueryHandler>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMvc();
        }
    }
}
