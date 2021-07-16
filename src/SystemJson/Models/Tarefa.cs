namespace SystemJson.Models
{
    public class Tarefa
    {
        public string Servico { get; set; }
        public bool Habilitado { get; set; }
        public Parametro Parametros { get; set; }
    }
}