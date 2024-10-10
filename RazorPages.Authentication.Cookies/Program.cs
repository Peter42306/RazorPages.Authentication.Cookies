var builder = WebApplication.CreateBuilder(args); // Создание приложения WebApplication с использованием стандартных аргументов

builder.Services.AddRazorPages(); // Регистрация RazorPages в сервисах контейнера

var app = builder.Build(); // Создание экземпляра приложения

app.MapRazorPages(); // Подключение маршрутизации для Razor Pages

app.Run(); // Запуск приложения
