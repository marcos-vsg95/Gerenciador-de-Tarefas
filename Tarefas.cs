using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Trabalho_BD.Context;

namespace Trabalho_BD.Models
{
    public class Tarefas
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id {  get; set; }
        public string? Descricao { get; set; }
        public string? Responsavel {  get; set; }
        public string? Status {  get; set; }
        public string? Prioridade { get; set; }
        public string? DataVencimento { get; set; }
        
        private TarefasContext _tarefaContext = new TarefasContext();


        public List<Tarefas> ObterTarefas()
        {
            return _tarefaContext.ObterTarefas(); 
        }

		public List<Tarefas> ObterTarefas(string texto)
		{
			return _tarefaContext.ObterTarefas(texto);
		}

		public bool Inserir(Tarefas tarefas)
        {
            return _tarefaContext.Inserir(tarefas);
        }

        public Tarefas ObterTarefa(string id)
        {
            return _tarefaContext.ObterTarefa(id);
        }

		public bool Atualizar(Tarefas tarefas)
		{
			return _tarefaContext.Atualizar(tarefas);
		}

		public Tarefas Visualizar(string id)
		{
			return _tarefaContext.ObterTarefa(id);
		}

		public bool Excluir(Tarefas tarefas)
		{
			return _tarefaContext.Excluir(tarefas);
		}




		public List<BsonDocument> TarefasConcluidasPorUsuario()
		{
			return _tarefaContext.TarefasConcluidasPorUsuario();
		}

		public List<BsonDocument> PercentualConclusaoPorUsuario()
		{
			return _tarefaContext.PercentualConclusaoPorUsuario();
		}

		public List<BsonDocument> TarefasPendentesPorPrioridade()
		{
			return _tarefaContext.TarefasPendentesPorPrioridade();
		}
	}
}
