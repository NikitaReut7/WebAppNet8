using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Npgsql;
using System.Reflection;
using WebApp.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
NpgsqlDataSourceBuilder npgsqlData = new(builder.Configuration.GetConnectionString("DefaultConnection"));
npgsqlData.UseNodaTime();
npgsqlData.EnableDynamicJson();

var dataSourse = npgsqlData.Build();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(dataSourse, x =>
    {
        x.UseNodaTime();
        x.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
    }));

builder.Services.AddScoped<IDataContext>(s=>s.GetRequiredService<ApplicationDbContext>());  
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
