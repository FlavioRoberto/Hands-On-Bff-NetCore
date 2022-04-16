using BFF.Core.Validators;
using System;
using System.Text.Json.Serialization;

namespace BFF.Core.Messages
{
    public abstract class Command<T> : IRequest<T>
    {
        [JsonIgnore]
        public ValidationResult ValidationResult { get; set; }

        public virtual bool EhValido()
        {
            throw new NotImplementedException();
        }
    }
}
