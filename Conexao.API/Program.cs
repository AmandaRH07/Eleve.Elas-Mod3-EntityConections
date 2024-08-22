using Conexao.API.Middleware;
using Conexao.Data;
using Conexao.Data.Repository;
using Conexao.Domain.Repositorios;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
builder.Services.AddScoped<IAlunoRepository, AlunoRepository>();
builder.Services.AddScoped<IProfessorRepository, ProfessorRepository>();
builder.Services.AddScoped<ITurmaAlunoRepository, TurmaAlunoRepository>();

builder.Services.AddDbContext<Contexto>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("Conexao")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.Use(async (context, next) =>
{
	Console.WriteLine(context.Request.Path + "Entrando no mid1");

	await next.Invoke();

	Console.WriteLine(context.Request.Path + "Saindo no mid1");
});

app.UseAuthorization();

app.MapControllers();

app.UseMiddleware<RequestMiddleware>();

app.Run(async context =>
{
	Console.WriteLine(context.Request.Path + "Entrando no mid2");

	await context.Response.WriteAsync("Hello from delegate");

	Console.WriteLine(context.Request.Path + "Saindo no mid2");
});

app.Run();
