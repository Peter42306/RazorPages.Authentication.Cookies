var builder = WebApplication.CreateBuilder(args); // �������� ���������� WebApplication � �������������� ����������� ����������

builder.Services.AddRazorPages(); // ����������� RazorPages � �������� ����������

var app = builder.Build(); // �������� ���������� ����������

app.MapRazorPages(); // ����������� ������������� ��� Razor Pages

app.Run(); // ������ ����������
