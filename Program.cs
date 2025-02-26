using Microsoft.EntityFrameworkCore;
using Courses.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
var connectionString = builder.Configuration.GetConnectionString("AZURE_SQL_CONNECTIONSTRING");
builder.Services.AddDbContext<CourseContext>(opt =>
    opt.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
