using Microsoft.EntityFrameworkCore;
using Questionario.Data;
using Questionario.Repositorios;
using Questionario.Repositorios.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Configure Swagger/OpenAPI
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure DbContext to use MySQL
builder.Services.AddDbContext<QuestionarioDBContext>(options =>
    options.UseMySQL(builder.Configuration.GetConnectionString("DataBase")));

builder.Services.AddScoped<IVisitanteRepositorio, VisitanteRepositorio>();

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

app.Run();