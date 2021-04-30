using System.Reflection;
using Autofac;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using WebAPI.Application.DTO.Requests.Register.Validators;
using WebAPI.Application.Tasks.Commands.Register;
using WebAPI.Infrastructure.CrossCutting.IOC;
using WebAPI.Infrastructure.Data;
using WebAPI.Presentation.Middlewares;

namespace WebAPI.Presentation
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DataContext>(opt =>
            {
                opt.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebAPI.Presentation", Version = "v1" });
            });

            services.AddGlobalExceptionHandlerMiddleware();
            var assembly = typeof(CreateLegalPersonCommand).GetTypeInfo().Assembly;
            services.AddMediatR(assembly);
            services.AddAutoMapper(assembly);
            
            services.AddMvc()
           .AddFluentValidation(fv =>
           {
               fv.RegisterValidatorsFromAssemblyContaining<CreatePhysicalPersonRequestValidator>();
               //opt.RegisterValidatorsFromAssembly(typeof(CreatePhysicalPersonCommand).GetTypeInfo().Assembly);

           })
           .AddJsonOptions(opt =>
           {
               opt.JsonSerializerOptions.IgnoreNullValues = true;
           });
            services.AddCors(opt =>
            {
                opt.AddPolicy("CorsPolicy", policy =>
                {
                    policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
                });
            });
        }
        public void ConfigureContainer(ContainerBuilder builder)
        {
            #region Module IOC
            builder.RegisterModule(new ModuleIOC());
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAPI.Presentation v1"));
            }

            //app.UseHttpsRedirection();

            app.UseRouting();
            
            app.UseAuthorization();
            app.UseCors("CorsPolicy");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
