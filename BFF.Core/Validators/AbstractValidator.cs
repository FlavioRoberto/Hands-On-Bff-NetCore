using BFF.Core.Extensions;
using System;

namespace BFF.Core.Validators
{
    public abstract class AbstractValidator
    {
        private ValidationResult _validationResult;

        protected AbstractValidator()
        {
            _validationResult = new ValidationResult();
        }

        public AbstractValidator ValidarSeVazio(string value, string message)
        {
            if (value.IsEmpty())
                _validationResult.AdicionarErro(message);

            return this;
        }

        public AbstractValidator ValidarSeVazio(DateTime value, string message)
        {
            if (value.IsEmpty())
                _validationResult.AdicionarErro(message);

            return this;
        }

        public AbstractValidator ValidarSeVazio(Guid value, string message)
        {
            if (value.IsEmpty())
                _validationResult.AdicionarErro(message);

            return this;
        }

        public AbstractValidator MaiorQue(DateTime data, DateTime dataComparar, string message)
        {
            if (data <= dataComparar)
                _validationResult.AdicionarErro(message);

            return this;
        }

        public ValidationResult Result()
        {
            return _validationResult;
        }
    }
}
