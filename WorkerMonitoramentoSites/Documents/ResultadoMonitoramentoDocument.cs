using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WorkerMonitoramentoSites.Documents
{
    public class ResultadoMonitoramentoDocument
    {
        public ObjectId _id { get; set; }
        public string VersaoWorker { get; set; }
        public string Local { get; set; }
        public string Status { get; set; }
        public string Horario { get; set; }
        public string Host { get; set; }
        [BsonIgnoreIfNull]
        public string Erro { get; set; }
    }
}