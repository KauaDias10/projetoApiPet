using Microsoft.EntityFrameworkCore;
using PetApi.Data;
using PetApi.Models;


var builder = WebApplication.CreateBuilder(args);

// Adiciona o contexto do banco de dados
builder.Services.AddDbContext<PetContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
    new MySqlServerVersion(new Version(8, 0, 38))));

// Adiciona serviços ao contêiner
builder.Services.AddControllers();

var app = builder.Build();

// Configura o pipeline de solicitação
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
