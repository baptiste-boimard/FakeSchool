using System.Reflection;
using Microsoft.EntityFrameworkCore;
using SchoolRepository;
using SchoolRepository.Data;
using SchoolRepository.Interfaces;
using SchoolRepository.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddScoped<IStudentsRepository, StudentsRepository>();
builder.Services.AddScoped<IGroupsRepository, GroupsRepository>();
builder.Services.AddScoped<ICoursesRepository, CoursesRepository>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
  {
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
  }    
);


builder.Services.AddDbContext<FakeschoolContext>(options =>
  options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
      new MySqlServerVersion(new Version(8, 0, 36)))
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
  app.UseSwagger();
  app.UseSwaggerUI(options =>
  {
    options.SwaggerEndpoint("/swagger/v1/swagger.json","v1 ");
    options.RoutePrefix = string.Empty;
  });}

// app.UseHttpsRedirection();
app.MapControllers();
app.UseAuthorization();

app.Run();