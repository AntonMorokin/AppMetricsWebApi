FROM grafana/grafana-oss AS base
EXPOSE 3000
COPY AppMetricsWebApi/Grafana/conf.yml /etc/grafana/provisioning/datasources/prometheus.yml
COPY AppMetricsWebApi/Grafana/dashboard-conf.yml /etc/grafana/provisioning/dashboards/conf-prometheus.yml
COPY AppMetricsWebApi/Grafana/*.json /etc/grafana/provisioning/dashboards/