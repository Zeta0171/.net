using Business_layer.BLs;
using Business_layer.IBLs;
using DAL;
using DAL.DALs;
using DAL.IDALs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddTransient<IDAL_Personas, DAL_Personas_EF>();
builder.Services.AddTransient<IDAL_Vehiculos, DAL_Vehiculos_EF>();
builder.Services.AddTransient<IBL_Personas, BL_Personas>();
builder.Services.AddTransient<IBL_Vehiculo, BL_Vehiculo>();

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

DBContext.UpdateDatabase();

app.Run();
