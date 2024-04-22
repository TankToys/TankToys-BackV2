using Microsoft.EntityFrameworkCore;

using TankToys.Database;
using TankToys.Services;

var MyAllowSpecificOrigins = "AllowLocalhost";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins, policy =>
    {
        policy.WithOrigins("http://localhost:4200")
        .AllowAnyMethod()
        .AllowAnyOrigin()
        .AllowAnyHeader();
    });
    options.AddDefaultPolicy(builder =>
    {
        builder.SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost");
    });
});



var configuration = new ConfigurationBuilder()
           .AddJsonFile("appsettings.json")
           .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true)
           .Build();

// Add services to the container.
builder.Services.AddScoped<DatabaseService, DatabaseService>();
builder.Services.AddScoped<DatabaseService, DatabaseService>();
builder.Services.AddScoped<MapService, MapService>();
builder.Services.AddScoped<MultiplayerService, MultiplayerService>();
builder.Services.AddScoped<RoomService, RoomService>();
builder.Services.AddScoped<TankService, TankService>();
builder.Services.AddScoped<UserService, UserService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseNpgsql(configuration.GetConnectionString("PgDbConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors(MyAllowSpecificOrigins);

app.Run();
