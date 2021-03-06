using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExampleWebSite.Models;
using ExampleWebSite.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using ExampleWebSite.Data.Interfaces;
using ExampleWebSite.Data.Repositories;
using System.Globalization;
using Microsoft.AspNetCore.Localization;
using ExampleWebSite.ResourcesModels;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Authorization;
using ExampleWebSite.Hubs;
using ExampleWebSite.Data.ConfigurationModels;
using ExampleWebSite.Components.Midleware;

namespace ExampleWebSite
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<AdminAccountDataModel>(Configuration);
            services.Configure<AppConfigDataModel>(Configuration);

            services.AddMemoryCache();

            services.AddMvc();
            //services.AddAuthorization(options => {
            //    options.AddPolicy("IsBanedPolicy", policy => policy.RequireClaim("IsBaned", false.ToString()));
            //});
            // services.AddAuthorization(options => {
            //     options.AddPolicy("IsBanedRole", policy => policy.RequireRole());
            //});

            services.AddLocalization(options=>options.ResourcesPath = "Resources");
            services.AddSignalR();

            services.AddTransient<ILikeRepository, LikeRepository>();
            services.AddTransient<ITagRepository, TagRepository>();
            services.AddTransient<IItemTagsrelationshipRepository, ItemTagsrelationshipRepository>();
            services.AddTransient<ICommentRepository, CommentRepository>();
            services.AddTransient<IItemRepository, ItemRepository>();
            services.AddTransient<ICollectionRepository, CollectionRepository>();
            services.AddTransient<IpropertiesElementsRepository, PropertiesElementRepository>();
            services.AddTransient<IpropertiesModelRepository, PropertiesModelRepository>();
            services.AddTransient<IThemeRepository, ThemaRepository>();
            services.AddTransient<IUserRepository, UserRepository>();

            services.AddControllersWithViews()
                .AddDataAnnotationsLocalization(options =>
                {
                    options.DataAnnotationLocalizerProvider = (type, factory) =>
                        factory.Create(typeof(ModelRes));
                })
                .AddViewLocalization();

            services.AddDbContext<ExamWebSiteDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<ExamWebSiteDBContext>()
                .AddDefaultTokenProviders();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            var suportedCulture = new[]
           {
                new CultureInfo("ru"),
                new CultureInfo("en")
            };

            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                DefaultRequestCulture =new RequestCulture("en"),
                SupportedCultures = suportedCulture,
                SupportedUICultures =suportedCulture
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles(new StaticFileOptions()
            {
                OnPrepareResponse=stf=>stf.Context.Response.Headers.Add("Cache-Control", "public,max-age=600")
            });
     
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseMiddleware<CheckUserMidleware>();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Collection}/{action=Index}/{id?}");
                endpoints.MapHub<CommentHub>("/chat");
            });
        }
    }
}
