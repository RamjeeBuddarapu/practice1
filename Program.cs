using BookServiceWEBAPI.Controllers;
using BookServiceWEBAPI.Service;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

builder.Services.AddCors(c =>
{
    c.AddPolicy("AllowOrigin", options =>
options.AllowAnyOrigin() //allows any client url
    .AllowAnyMethod() //allows all http methods like(get,post,put and delete)
    .AllowAnyHeader() //all any header like request,response and so on
    );
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
