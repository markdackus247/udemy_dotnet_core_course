using Microsoft.EntityFrameworkCore;
using Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(opt =>
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

// Create a scope to obtain services
using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;

try
{
    // Get the DataContext service
    var context = services.GetRequiredService<DataContext>();
    
    // Apply any pending migrations
    await context.Database.MigrateAsync();

    // Seed the database
    await Seed.SeedData(context);
}
catch (Exception ex)
{
    // Get the logger service
    var logger = services.GetRequiredService<ILogger<Program>>();
    
    // Log any errors that occur during migration
    logger.LogError(ex, "An error occurred during migration");
}


app.Run();
