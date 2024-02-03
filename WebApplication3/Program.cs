using FluentValidation.AspNetCore;
using Auth.BuisnessLayer.Extensions;
using FluentValidation;

namespace WebApplication3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.


            builder.Services.AddValidatorsConfiguration();
            builder.Services.AddFluentValidationAutoValidation();
            
            builder.Services.AddControllers();
            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
