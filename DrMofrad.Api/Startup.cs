using DrMofrad.Api.GraphQl;
using DrMofrad.Api.GraphQl.Appointment;
using DrMofrad.Api.GraphQl.Article;
using DrMofrad.Api.GraphQl.ArticleCategory;
using DrMofrad.Api.GraphQl.Cilinic;
using DrMofrad.Api.GraphQl.ContactUs;
using DrMofrad.Api.GraphQl.Faq;
using DrMofrad.Api.GraphQl.File;
using DrMofrad.Api.GraphQl.Gallery;
using DrMofrad.Api.GraphQl.GalleryCategory;
using DrMofrad.Api.GraphQl.HoursAttend;
using DrMofrad.Api.GraphQl.Opinion;
using DrMofrad.Api.GraphQl.Page;
using DrMofrad.Api.GraphQl.SeoSetting;
using DrMofrad.Api.GraphQl.SlideShow;
using DrMofrad.Api.GraphQl.TelegramChannel;
using DrMofrad.Api.GraphQl.TelegramMessage;
using DrMofrad.Api.GraphQl.TelegramUser;
using DrMofrad.Api.Model;
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
                .AddType<AppointmentType>()
                .AddType<ArticleCategoryType>()
                .AddType<ArticleType>()
                .AddType<CilinicType>()
                .AddType<GalleryType>()
                .AddType<GalleryCategoriesType>()
                .AddType<ContactUsType>()
                .AddType<FaqType>()
                .AddType<FileType>()
                .AddType<HoursAttendType>()
                .AddType<OpinionType>()
                .AddType<PageType>()
                .AddType<SeoSettingType>()
                .AddType<SlideShowType>()
                .AddType<TelegramChannelType>()
                .AddType<TelegramMessageType>()
                .AddType<TelegramUserType>()
                .AddFiltering()
                .AddSorting();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

            app.UseWebSockets();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL();
                endpoints.MapGraphQLVoyager();
            });

            app.UseGraphQLVoyager();
        }
    }
}