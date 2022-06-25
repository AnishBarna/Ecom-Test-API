using Ecom.Data;
using Ecom.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSqlite<EcomContext>("Data Source=Ecom.db");



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<CustomerService>();
builder.Services.AddScoped<TransactionService>();
builder.Services.AddScoped<ProductService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.CreateDbIfNotExists();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
