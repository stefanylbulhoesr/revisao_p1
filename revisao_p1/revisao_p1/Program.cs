using Microsoft.EntityFrameworkCore;
using revisão_p1.Repositories;
using revisao_p1.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IAlunoRepositories,AlunoRepositories>();
builder.Services.AddScoped<IAlunoServices, AlunoServices>();

builder.Services.AddDbContext<AppDbContext>(options => {
    options.UseInMemoryDatabase("AlunosDb");
});

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
