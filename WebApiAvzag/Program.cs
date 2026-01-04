
namespace WebApiAvzag
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.WebHost.UseKestrel();


            builder.Logging.ClearProviders();
            builder.Logging.AddConsole();  // Добавляем вывод в консоль
            builder.Logging.AddDebug();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("DevCorsPolicy", policy =>
                {
                    // ЯВНО перечисляем ВСЕ разрешенные адреса
                    policy.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                });
            });


            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }


            app.UseCors("DevCorsPolicy");
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
