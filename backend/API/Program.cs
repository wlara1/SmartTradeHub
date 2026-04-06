using SmartTradeHub.Infrastructure;
using SmartTradeHubApplication.Orders.Create;
using SmartTradeHubApplication.Orders.Queries;
using SmartTradeHubApplication.Products.Create;
using SmartTradeHubApplication.Products.Queries;
;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register application services
builder.Services.AddInfrastructure(builder.Configuration);

// Ajout des services liés aux commandes
builder.Services.AddScoped<OrderService>();
builder.Services.AddScoped<GetOrderService>();

// Ajout des services liés aux produits
builder.Services.AddScoped<GetProductService>();
builder.Services.AddScoped<CreateProductService>();

// Configure CORS to allow requests from the Angular frontend
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular",
        policy =>
        {
            policy.WithOrigins("http://localhost:4200")
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
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

app.UseCors("AllowAngular");

app.Run();
