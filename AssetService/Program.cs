using EmpAssetService.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var localConnectionString = "Data Source=LENOVOG2MCI-012;Initial Catalog=EmpAsset;User ID=admin;Password=admin;TrustServerCertificate=True;";

builder.Services.AddDbContext<AppDbContext>((opt) => opt.UseSqlServer(localConnectionString));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
{
    builder.WithOrigins("https://localhost:44462")
           .AllowAnyMethod()
           .AllowAnyHeader();
}));

builder.Services.AddScoped<IEmpAssetRepository, EmpAssetRepository>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("MyPolicy");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
