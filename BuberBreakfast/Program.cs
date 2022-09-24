using System.Net;
using BuberBreakfast.Services.Breakfast;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddScoped<IBreakfastService,BreakfastService>();

var app = builder.Build();


// app.UseHttpsRedirection();
app.Map("/",() => "Hello");
app.MapControllers();
app.Run();



