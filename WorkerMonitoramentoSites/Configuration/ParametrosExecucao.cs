namespace WorkerMonitoramentoSites.Configuration
{
    public class ParametrosExecucao
    {
        public string ConnectionDBMonitoramento { get; set; }
        public string DBMonitoramento { get; set; }
        public string CollectionMonitoramento { get; set; }
        public string Hosts { get; set; }
        public int Intervalo { get; set; }
    }
}