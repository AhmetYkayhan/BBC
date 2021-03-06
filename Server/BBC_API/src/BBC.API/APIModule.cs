﻿using Autofac;
using BBC.API.Registery;
using BBC.Core;
using BBC.Core.Domain.Identity;
using BBC.Core.Module;
using BBC.Infrastructure;
using BBC.Infrastructure.Data;
using BBC.Infrastructure.Identity.Providers;
using BBC.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBC.API
{
    public class APIModule : ModuleBase
    {
        protected override void Load(ContainerBuilder builder)
        {

        }

        public override void PreInit(IServiceCollection services, IConfiguration Configuration)
        {
            
            services.UseIdentity<BBCContext, User, Role>();
            services.SetIdentityOptions(Configuration);
            services.UseAuthentication(Configuration);
            services.UseCors(Configuration);
            //TODO : CORS PROBLEM
            services.AddControllers();
            services.AddScoped<IHttpContextAccessor, HttpContextAccessor>();
            services.AddHttpContextAccessor();
            services.UseSwagger();



        }

        public override void PostInit(IApplicationBuilder app)
        {
            app.SwaggerBuilder();
            app.CorsBuilder();
            app.AuthorizeBuilder();
        }

    }
}
