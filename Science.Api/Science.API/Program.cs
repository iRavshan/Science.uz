using Microsoft.EntityFrameworkCore;
using Science.Data.DataContexts;
using Science.Data.IRepositories;
using Science.Data.Repositories;
using Science.Service.IServices;
using Science.Service.Services;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

//Log.Logger = new LoggerConfiguration()
//    .WriteTo.File("Logs\\log-.txt", rollingInterval: RollingInterval.Day)
//    .WriteTo.Console()
//    .CreateLogger();


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connection = builder.Configuration.GetConnectionString("DatabaseConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseSqlServer(connection));

builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<IAdvisorRepository, AdvisorRepository>();
builder.Services.AddScoped<IWorkRepository, WorkRepository>();

builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<IAdvisorService, AdvisorService>(); 
builder.Services.AddScoped<IWorkService, WorkService>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseSerilogRequestLogging();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
