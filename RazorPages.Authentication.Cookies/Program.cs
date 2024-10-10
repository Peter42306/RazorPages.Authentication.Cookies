using Microsoft.EntityFrameworkCore;
using RazorPages.Authentication.Cookies.Model;

var builder = WebApplication.CreateBuilder(args); // �������� ���������� WebApplication � �������������� ����������� ����������

// ��������� ������ ����������� �� ������������
string? connection = builder.Configuration.GetConnectionString("DefaultConnection");

// ����������� ��������� ���� ������ � ������������ ��� ������������� SQL Server
builder.Services.AddDbContext<ApplicationContext>(options =>
    options.UseSqlServer(connection));

builder.Services.AddRazorPages(); // ����������� RazorPages � �������� ����������

var app = builder.Build(); // �������� ���������� ����������

// ����������� ����������� ������
app.UseStaticFiles();

app.MapRazorPages(); // ����������� ������������� ��� Razor Pages

app.Run(); // ������ ����������
