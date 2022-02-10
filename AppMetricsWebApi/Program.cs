using App.Metrics;
using App.Metrics.Extensions.Configuration;
using App.Metrics.Formatters.Prometheus;

namespace AppMetricsWebApi
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var metrics = new MetricsBuilder()
                .Configuration.ReadFrom(builder.Configuration)
                .OutputMetrics.AsPrometheusPlainText()
                .Build();

            // Not good but fast
            builder.WebHost
                .ConfigureMetrics(metrics)
                .UsePrometheusMetrics(metrics);

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.MapControllers();

            app.Run();
        }
    }
}