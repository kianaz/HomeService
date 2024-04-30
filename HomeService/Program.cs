
using HomeService.Infra.DBcontaxt.EF.SQL.DBcontextSet;
using Microsoft.EntityFrameworkCore;

namespace HomeService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<HomeServiceDbcontaxt>(options
              => options.UseSqlServer(
                  "Data Source=DESKTOP-LMIEPJ0;Initial Catalog=HomeServiceDB;Integrated Security=True;Trust Server Certificate=True"));


            var app = builder.Build();
            //AppContext.SetSwitch("System.Globalization.Invariant", true);

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
        }
    }
}
