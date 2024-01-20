using TarefasApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//registrando as injeções de dependência
DependencyInjection.Configure(builder.Services);

//configuração da política de CORS do projeto
builder.Services.AddCors(cfg => cfg.AddPolicy("defaultPolicy", builder =>
{
    builder.WithOrigins("http://localhost:4200") //servidor que poderá acessar a API
           .AllowAnyMethod() //permissão para acessar os métodos POST, PUT, DELETE e GET
           .AllowAnyHeader(); //permissão para enviar parametros no cabeçalho
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

//registrando a política de CORS
app.UseCors("defaultPolicy");

app.Run();


