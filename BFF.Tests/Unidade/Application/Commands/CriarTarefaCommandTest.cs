using BFF.Api.Application.Commands.Tarefas.Criar;
using System;
using System.Collections.Generic;
using Xunit;

namespace BFF.Tests.Unidade.Application.Commands
{
    public class CriarTarefaCommandTest
    {
        [Fact(DisplayName = "Deve retornar true ao validar comando")]
        [Trait("Unitários", "CriarTarefaCommand")]
        public void CriarTarefaCommand_DeveRetornarTrueAoValidarComando()
        {
            //arrange
            var command = new CriarTarefaCommand
            {
                Titulo = "Tarefa teste",
                Descricao = "Deve criar uma tarefa válida",
                DataVencimento = DateTime.Now.AddDays(1),
                UsuarioId = Guid.NewGuid()
            };

            //act
            var resultado = command.EhValido();

            //assert
            Assert.True(resultado);

        }

        [Fact(DisplayName = "Deve retornar false ao validar comando")]
        [Trait("Unitários", "CriarTarefaCommand")]
        public void CriarTarefaCommand_DeveRetornarFalseAoValidarComando()
        {
            //arrange
            var command = new CriarTarefaCommand();
            var errosEsperados = new List<string> {
                "Título não pode estar vazio!", 
                "Descrição não pode estar vazio!", 
                "O campo id do usuário deve ser informado!", 
                "O campo Data de vencimento deve ser informado!", 
                "Data de vencimento deve ser maior que a data atual!"
            };

            //act
            var resultado = command.EhValido();

            //assert
            Assert.False(resultado);
            Assert.Equal(errosEsperados, command.ValidationResult.Errors);

        }
    }
}
