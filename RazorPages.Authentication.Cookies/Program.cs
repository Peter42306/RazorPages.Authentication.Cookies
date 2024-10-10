using Microsoft.EntityFrameworkCore;
using RazorPages.Authentication.Cookies.Model;

var builder = WebApplication.CreateBuilder(args); // Создание приложения WebApplication с использованием стандартных аргументов

// Получение строки подключения из конфигурации
string? connection = builder.Configuration.GetConnectionString("DefaultConnection");

// Регистрация контекста базы данных и конфигурация для использования SQL Server
builder.Services.AddDbContext<ApplicationContext>(options =>
    options.UseSqlServer(connection));

builder.Services.AddRazorPages(); // Регистрация RazorPages в сервисах контейнера

var app = builder.Build(); // Создание экземпляра приложения

// Подключение статических файлов
app.UseStaticFiles();

app.MapRazorPages(); // Подключение маршрутизации для Razor Pages

app.Run(); // Запуск приложения
