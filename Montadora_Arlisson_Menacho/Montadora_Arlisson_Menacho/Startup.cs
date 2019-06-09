using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Montadora_Arlisson_Menacho.Repositories;
using Montadora_Arlisson_Menacho.Services;
using Microsoft.EntityFrameworkCore;

namespace Montadora_Arlisson_Menacho
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration
        {
            get;
        }

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


            ///isso serve para localizar o BD como BDLocal independente de onde for.
            var caminhoDoBanco = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory());
            //// Conexão com BD
            var conexaoString = String.Format(@"Server=(localbd)/MSSQLLocalBD;Initial Catalog=Montadora;Integrated Security = SSPI;AttachDBFilename={0}\Banco_Lab.mdf", caminhoDoBanco);

            services.AddDbContext<Montadora_Arlisson_Menacho.Contexto.MontadoraContexto>(options => options.UseSqlServer(conexaoString));

            services.AddTransient<MontadorRepository, MontadorRepository>();
            services.AddTransient<CidadeRepository, CidadeRepository>();
            services.AddTransient<MontadorRepository, MontadorRepository>();
            services.AddTransient<PecaRepository, PecaRepository>();
            services.AddTransient<PecaDoVeiculoRepository,PecaDoVeiculoRepository>();
            services.AddTransient<PessoaRepository,PessoaRepository>();
            services.AddTransient<ClienteRespository, ClienteRespository>();
            services.AddTransient<FornecedorRepository, FornecedorRepository>();
            services.AddTransient<UsuarioRepository,UsuarioRepository>();
            services.AddTransient<VeiculoRepository,VeiculoRepository>();         

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
