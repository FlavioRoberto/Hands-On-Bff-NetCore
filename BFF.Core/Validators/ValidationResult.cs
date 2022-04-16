using System.Collections.Generic;
using System.Linq;

namespace BFF.Core.Validators
{
    public class ValidationResult
    {
        public bool IsValid { get { return !Errors.Any(); } }
        public IList<string> Errors { get; private set; }

        public ValidationResult()
        {
            Errors = new List<string>();
        }

        public void AdicionarErro(string erro)
        {
            Errors.Add(erro);
        }
    }
}
