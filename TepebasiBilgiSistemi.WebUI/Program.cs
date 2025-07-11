using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using TepebasiBilgiSistemi.Business.Abstract;
using TepebasiBilgiSistemi.Business.Concrete;
using TepebasiBilgiSistemi.DataAccess.Abstract;
using TepebasiBilgiSistemi.DataAccess.Concrete.EntityFramework;
using TepebasiBilgiSistemi.Entities.Concrete;

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
var builder = WebApplication.CreateBuilder(args);
// Add builder.Services to the container.
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

builder.Services.AddSingleton<IFileProvider>(
               new PhysicalFileProvider(
                   Path.Combine(Directory.GetCurrentDirectory(), "wwwroot")));

builder.Services.AddScoped<IBaskanService, BaskanManager>();
builder.Services.AddScoped<IBaskanDal, EfBaskanDal>();
builder.Services.AddScoped<IBaskanMudurlukService, BaskanMudurlukManager>();
builder.Services.AddScoped<IBaskanMudurlukDal, EfBaskanMudurlukDal>();
builder.Services.AddScoped<IBelgeService, BelgeManager>();
builder.Services.AddScoped<IBelgeDal, EfBelgeDal>();
builder.Services.AddScoped<IBelgeMudurlukService, BelgeMudurlukManager>();
builder.Services.AddScoped<IBelgeMudurlukDal, EfBelgeMudurlukDal>();
builder.Services.AddScoped<IButceMudurlukService, ButceMudurlukManager>();
builder.Services.AddScoped<IButceMudurlukDal, EfButceMudurlukDal>();
builder.Services.AddScoped<ICalisanService, CalisanManager>();
builder.Services.AddScoped<ICalisanDal, EfCalisanDal>();
builder.Services.AddScoped<IEgitimService, EgitimManager>();
builder.Services.AddScoped<IEgitimDal, EfEgitimDal>();

builder.Services.AddScoped<IBelgeService, BelgeManager>();
builder.Services.AddScoped<IBelgeDal, EfBelgeDal>();

builder.Services.AddScoped<IBelgeService, BelgeManager>();
builder.Services.AddScoped<IBelgeDal, EfBelgeDal>();


builder.Services.AddScoped<IMudurlukService, MudurlukManager>();
builder.Services.AddScoped<IMudurlukDal, EfMudurlukDal>();



builder.Services.AddDbContext<CustomIdentityDbContext>
              (options => options.UseNpgsql("Host=172.16.24.37;Database=tpbsbilsis25;Username=postgres;Password=Tpb1372ALY!",
                o => o.UseNetTopologySuite()));
builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<CustomIdentityDbContext>()
    .AddDefaultTokenProviders();

builder.Services.AddMvc();
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

builder.Services.Configure<IdentityOptions>(options =>
{
    // Default Lockout settings.
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1440);
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = true;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
});

var app = builder.Build();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles();
app.UseFileServer();
app.UseAuthentication();
app.UseRouting();
app.UseAuthorization();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapRazorPages();
    endpoints.MapControllerRoute("Default", "{controller=Home}/{action=Index}/{id?}");
});
app.Run();