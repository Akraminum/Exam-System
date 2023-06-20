using EExamSystem.Core;
using EExamSystem.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

#region Services

builder.Services.AddControllers();
builder.Services.ConfigureDbContext(configuration);

builder.Services.InjectRepositories();
builder.Services.InjectManagers();

//builder.Services.ConfigureAutomapper();
builder.Services.AddAutoMapper(typeof(Program));

#endregion

#region Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
#endregion

//...


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
