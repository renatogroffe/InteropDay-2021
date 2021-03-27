using MongoDB.Driver;
using WorkerMonitoramentoSites.Configuration;
using WorkerMonitoramentoSites.Documents;

namespace WorkerMonitoramentoSites.Data
{
    public class MonitoramentoRepository
    {
        private readonly ParametrosExecucao _parametrosExecucao;

        public MonitoramentoRepository(
            ParametrosExecucao parametrosExecucao)
        {
            _parametrosExecucao = parametrosExecucao;
        }

        public void Insert(ResultadoMonitoramentoDocument resultado)
        {
            var client = new MongoClient(
                _parametrosExecucao.ConnectionDBMonitoramento);
            var db = client.GetDatabase(
                _parametrosExecucao.DBMonitoramento);
            var collection = db.GetCollection<ResultadoMonitoramentoDocument>(
                _parametrosExecucao.CollectionMonitoramento);

            collection.InsertOne(resultado);
        }
    }
}