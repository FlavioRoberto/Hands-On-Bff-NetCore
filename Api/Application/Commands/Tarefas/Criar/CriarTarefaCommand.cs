using BFF.Core.Messages;
using BFF.Core.Validators;
using System;
using System.Text.Json.Serialization;

namespace BFF.Api.Application.Commands.Tarefas.Criar
{
    public class CriarTarefaCommand : Command
    {
        [JsonPropertyName("titulo")]
        public string Titulo { get; set; }

        [JsonPropertyName("descricao")]
        public string Descricao { get; set; }

        [JsonPropertyName("data_vencimento")]
        public DateTime DataVencimento { get; set; }

        [JsonPropertyName("usuario_id")]
        public Guid UsuarioId { get; set; }

        public override bool EhValido()
        {
            ValidationResult = new CriarTarefaCommandValidator().Validate(this);
            return ValidationResult.IsValid;
        }
    }

    public class CriarTarefaCommandValidator : AbstractValidator
    {
        public ValidationResult Validate(CriarTarefaCommand criarTarefaCommand)
        {
            return ValidarSeVazio(criarTarefaCommand.Titulo, "Título não pode estar vazio!")
                  .ValidarSeVazio(criarTarefaCommand.Descricao, "Descrição não pode estar vazio!")
                  .ValidarSeVazio(criarTarefaCommand.UsuarioId, "O campo id do usuário deve ser informado!")
                  .ValidarSeVazio(criarTarefaCommand.DataVencimento, "O campo Data de vencimento deve ser informado!")
                  .MaiorQue(criarTarefaCommand.DataVencimento, DateTime.Now, "Data de vencimento deve ser maior que a data atual!")
                  .Result();
        }
    }
}
