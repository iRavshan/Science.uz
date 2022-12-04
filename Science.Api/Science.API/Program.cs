using Microsoft.EntityFrameworkCore;
using Science.Data.DataContexts;
using Science.Data.IRepositories;
using Science.Data.Repositories;
using Science.Service.IServices;
using Science.Service.Services;
using Science.Utility.MappingProfiles.Student;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

var logger = new LoggerConfiguration()
    .WriteTo.File("Logs\\log-.txt", rollingInterval: RollingInterval.Day)
    .WriteTo.Console()
    .CreateLogger();

builder.Logging.AddSerilog(logger);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string? connection = builder.Configuration.GetConnectionString("DatabaseConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseSqlServer(connection));

builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<IAdvisorRepository, AdvisorRepository>();
builder.Services.AddScoped<IWorkRepository, WorkRepository>();

builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<IAdvisorService, AdvisorService>(); 
builder.Services.AddScoped<IWorkService, WorkService>();

builder.Services.AddAutoMapper(options =>
{
    options.AddProfile<StudentProfile>();
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
