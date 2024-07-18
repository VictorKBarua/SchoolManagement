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
app.UseSwagger();
if (app.Environment.IsDevelopment())
{
    app.UseSwaggerUI();
}

app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("../swagger/v1/swagger.json", "SchoolManagement API v1");
    c.RoutePrefix = string.Empty;// Set Swagger UI at apps root
});
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
