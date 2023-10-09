using Blog.DataAccess.Abstract;
using Blog.DataAccess.Concrete;
using Blog.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Blog.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<BlogProjesiDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("BlogProjesiDbConnectionString")));

            builder.Services.AddScoped<IBlogPostRepository,BlogPostRepository>();
            builder.Services.AddScoped<IBlogPostLikeRepository,BlogPostLikeRepository>();
            builder.Services.AddScoped<ITagRepository,TagRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}