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


app.UseSwagger();
app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        c.RoutePrefix = string.Empty; // Swagger доступен из корневого каталога
    });


app.UseHttpsRedirection();

app.Run();

void Configure(IApplicationBuilder app, IWebHostEnvironment env)
{
    app.UseRouting();
    
    app.UseEndpoints(endpoints => endpoints.MapControllers());
}