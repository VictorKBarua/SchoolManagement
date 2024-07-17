using SchoolManagement.Service.StudentService;
using SchoolManagement.Repository.DataRepositories;
using Microsoft.EntityFrameworkCore;
using SchoolManagement.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SchoolContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("SchoolDbConnection"), providerOptions => providerOptions.EnableRetryOnFailure()));
builder.Services.AddTransient<IStudentService, StudentService>();
builder.Services.AddScoped(typeof(ISchoolRepo<>), typeof(SchoolRepo<>));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
