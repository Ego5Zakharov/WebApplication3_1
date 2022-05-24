using WebApplication3_1.Properties.Services;

////������� ����������� ������ �� ���������� �������� ���� ������� ������ � ����������� ������������ �����. 
////������� ��� ���������� ����������, ���� ���������� ������ �����, ������ ����� �������� ������.
////�������� ������ � IoC ���������

var builder = WebApplication.CreateBuilder();

builder.Services.AddTransient<ISalaryCalculator, SalaryCalculatorModified>();
//builder.Services.AddCaclulatorService();

var app = builder.Build();

app.Run(async context =>
{
    var salaryCalculator = app.Services.GetService<ISalaryCalculator>();
    await context.Response.WriteAsync($"Salary without tax: {salaryCalculator?.CalculateSallaryWithoutProcent(10,50)}\n");
    await context.Response.WriteAsync($"Salary with tax: {salaryCalculator?.CalculateSallary(10,50,50)}");
});

app.Run();



