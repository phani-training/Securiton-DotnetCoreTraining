
using SampleCoreWebApi;
using SampleCoreWebApi.Models;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Debug()
    .WriteTo.File("MyData.log")
    .CreateLogger();

builder.Logging.ClearProviders();   
builder.Logging.AddSerilog();

var policyName = "someName";
// Add services to the container.

//Enable Cors to the Service will make to avaialble to Users with all HTTP VERBS and All Headers..
builder.Services.AddCors(options =>
{
    options.AddPolicy(policyName, policy =>
    {
        policy.AllowAnyOrigin();
        policy.AllowAnyHeader();
        policy.AllowAnyMethod();
    });
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IBookRepository, BookRepository>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseLoggingMiddleware();
app.UseAuthorization();
app.UseCors(policyName);
app.MapControllers();

app.Run();
