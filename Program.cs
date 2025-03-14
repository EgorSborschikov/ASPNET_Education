using Microsoft.EntityFrameworkCore;
using WebApiTestSolution.Data;

//Инициализация строителя 
var builder = WebApplication.CreateBuilder(args);

// Добавление сервиса контекста базы данных в контейнер
builder.Services.AddDbContext<AppDatabaseContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddEndpointsApiExplorer(); //Добавление концевых точек в поисковик
builder.Services.AddSwaggerGen(); // Добавление автогенерации документации к API через службу Swagger

// Настройеп использование службы Swagger
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();