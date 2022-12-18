using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Science.API.Helpers.IServices;
using Science.API.Helpers.Services;
using Science.Data.DataContexts;
using Science.Data.IRepositories;
using Science.Data.Repositories;
using Science.Service.IServices;
using Science.Service.Services;
using Science.Utility.MappingProfiles.Student;
using Serilog;
using Swashbuckle.AspNetCore.Filters;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

var logger = new LoggerConfiguration()
    .WriteTo.File("Logs\\log-.txt", rollingInterval: RollingInterval.Day)
    .CreateLogger();

builder.Logging.AddSerilog(logger);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddHttpContextAccessor();
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        Description = "Standard Authorization header using the Bearer scheme (\"bearer {token}\")",
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });

    options.OperationFilter<SecurityRequirementsOperationFilter>();
});

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8
                            .GetBytes(builder.Configuration.GetSection("Jwt:SecretKey").Value)),
                        ValidateIssuer = false,
                        ValidateAudience = false
                    };
                });

string? connection = builder.Configuration.GetConnectionString("DatabaseConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
        options.UseSqlServer(connection));

builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<IAdvisorRepository, AdvisorRepository>();
builder.Services.AddScoped<IWorkRepository, WorkRepository>();

builder.Services.AddScoped<IStudentService, StudentService>();
builder.Services.AddScoped<IAdvisorService, AdvisorService>(); 
builder.Services.AddScoped<IWorkService, WorkService>();

builder.Services.AddScoped<IPasswordManager, PasswordManager>();
builder.Services.AddScoped<IJwtManager, JwtManager>();

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
