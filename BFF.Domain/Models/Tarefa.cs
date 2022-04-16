using System;

namespace BFF.Domain.Models
{
    public class Tarefa
    {
        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public DateTime DataVencimento { get; set; }

        public DateTime DataCriacao { get; private set; }

        public Guid UsuarioId { get; set; }

        public Tarefa()
        {
            DataCriacao = DateTime.UtcNow;
        }
    }
}
