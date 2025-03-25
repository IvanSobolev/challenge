using ComputerClub.Manager.Implementation;
using ComputerClub.Manager.Interfaces;
using ComputerClub.Model;
using ComputerClub.Repository.Implementation;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IPlayerRepository, EfCorePlayerRepository>();
builder.Services.AddScoped<ISessionRepository, EfCoreSessionRepository>();
builder.Services.AddScoped<ISubscriptionRepository, EfCoreSubscriptionRepository>();

builder.Services.AddScoped<IPlayerManager, PlayerManager>();
builder.Services.AddScoped<ISessionManager, SessionManager>();
builder.Services.AddScoped<ISubscriptionManager, SubscriptionManager>();

builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("SQLiteData"));
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();
app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<DataContext>();
    dbContext.Database.EnsureCreated();
}

app.Run();
