using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using LaboratorioArlissonMenacho.Contexto;
using LaboratorioArlissonMenacho.Repositories;

namespace LaboratorioArlissonMenacho
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            var conexaoString = @"Server=LAB04-18;Integrated Security=true;Initial Catalog=bd_laboratorio;";
            services.AddDbContext<LaboratorioContexto>(options=>options.UseSqlServer(conexaoString));

            ////isso serve para localizar o BD como BDLocal independente de onde for.
            //var caminhoDoBanco = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory());
            //// Conexão com BD
            //var conexaoString = String.Format(@"Server=(localbd)/MSSQLLocalBD;Initial Catalog=LaboratorioBD;Integrated Security = SSPI;AttachDBFilename={0}\Banco_Lab.mdf",caminhoDoBanco);

            ////Adicionando o contexto do banco 
          // services.AddDbContext<LaboratorioArlissonMenacho.Contexto.LaboratorioContexto>(options => options.UseSqlServer(conexaoString));

            // Injeção de dependencia de Paciente
            services.AddTransient<Repositories.PacienteRepository,Repositories.PacienteRepository>();
            services.AddTransient<LaboratorioArlissonMenacho.Services.PacienteServices, LaboratorioArlissonMenacho.Services.PacienteServices>();
            // Injeção de Plano de Saude
            services.AddTransient<PlanoDeSaudeRepository, PlanoDeSaudeRepository>();
            services.AddTransient<ExameRepository, ExameRepository>();

                        services.AddTransient<Services.PlanoSaudeServices,Services.PlanoSaudeServices>();
            services.AddTransient<Services.ExameServices, Services.ExameServices>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
