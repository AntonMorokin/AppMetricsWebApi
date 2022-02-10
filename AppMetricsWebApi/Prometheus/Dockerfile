FROM prom/prometheus AS base
EXPOSE 9090
COPY AppMetricsWebApi/Prometheus/conf.yml /etc/prometheus/prometheus.yml
COPY AppMetricsWebApi/Prometheus/*.rule.yml /etc/prometheus/