namespace SIIR
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            //Controladores de Home
            app.MapControllerRoute(
                name: "createUser",
                pattern: "createUser",
                defaults: new { controller = "Home",  action = "CreateUser" });

            app.MapControllerRoute(
                name: "restorePassword",
                pattern: "restorePassword",
                defaults: new { controller = "Home", action = "RestorePassword" });

            app.MapControllerRoute(
                name: "login",
                pattern: "login",
                defaults: new { controller = "Home", action = "Login" });

            //Controladores de user
            app.MapControllerRoute(
                name: "userDashboard",
                pattern: "user/{userType}/dashboard",
                defaults: new { controller = "User", action = "Dashboard" });

            app.MapControllerRoute(
                name: "information",
                pattern: "information",
                defaults: new { controller = "User", action = "Information" });

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Login}/{id?}");

            app.Run();
        }
    }
}
