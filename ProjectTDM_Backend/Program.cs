using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using TDM.Service.Services.RoleServices;
using TDM.Service.Services.TaskServices;
namespace ProjectTDM_Backend
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Register AutoMapper
            builder.Services.AddAutoMapper(typeof(MappingProfile)); // Register AutoMapper using Program type

            // Register your services
            builder.Services.AddTransient<RoleManager>();    // Register RoleService
            builder.Services.AddTransient<TaskManager>(); // Register UserTaskService

            // Add services to the container.

            builder.Services.AddControllers();
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
        }
    }
}
