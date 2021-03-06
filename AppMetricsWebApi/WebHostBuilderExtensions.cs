using App.Metrics;
using App.Metrics.AspNetCore;
using App.Metrics.Formatters.Prometheus;

namespace AppMetricsWebApi
{
    public static class WebHostBuilderExtensions
    {
        public static IWebHostBuilder UsePrometheusMetrics(this IWebHostBuilder webHostBuilder, IMetricsRoot metrics)
        {
            return webHostBuilder.UseMetrics(o =>
            {
                o.EndpointOptions = eo =>
                {
                    eo.MetricsEndpointOutputFormatter = metrics.OutputMetricsFormatters
                        .OfType<MetricsPrometheusTextOutputFormatter>()
                        .First();
                };
            });
        }
    }
}
