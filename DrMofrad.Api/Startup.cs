using DrMofrad.Api.GraphQl;
using DrMofrad.Api.GraphQl.Gallery;
using DrMofrad.Api.GraphQl.GalleryCategory;
using DrMofrad.Api.GraphQl.Lang;
using DrMofrad.Api.GraphQl.Member;
using DrMofrad.Api.Model;
using GraphQL.Server.Ui.Voyager;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DrMofrad.Api
{
    public class Startup
    {
        private readonly IConfiguration iConfiguration;

        public Startup(IConfiguration _iConfiguration)
        {
            iConfiguration = _iConfiguration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddPooledDbContextFactory<DrMofradDbContext>
                (opt => opt.UseSqlServer(iConfiguration.GetConnectionString("DrMofrad")));
            services
                .AddGraphQL()
                .AddGraphQLServer()
                .AddQueryType<Query>()
                .AddType<MemberType>()
                .AddType<GalleryCategoriesType>()
                .AddType<GalleryType>()
                .AddType<LangType>()
                .AddFiltering()
                .AddSorting();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

            app.UseWebSockets();

            app.UseRouting();

            app.UseEndpoints(endpoints => { endpoints.MapGraphQL(); });

            app.UseGraphQLVoyager(new VoyagerOptions
            {
                GraphQLEndPoint = "/graphql"
            });
        }
    }
}