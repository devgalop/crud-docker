using API.Data;
using dotenv.net;
using dotenv.net.Utilities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
DotEnv.Load();
builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(options =>
{
    string host = EnvReader.GetStringValue("POST_HOST");
    string user = EnvReader.GetStringValue("POST_USER");
    string pass = EnvReader.GetStringValue("POST_PASSWORD");
    string dbName = EnvReader.GetStringValue("POST_DB");
    options.UseNpgsql($"Host={host};Database={dbName};Username={user};Password={pass}");
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
