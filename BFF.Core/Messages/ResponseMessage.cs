
using BFF.Core.Validators;

namespace BFF.Core.Messages
{
    public class ResponseMessage<T>
    {
        public ValidationResult ValidationResult { get; private set; }
        public T Data { get; set; }

        public ResponseMessage(ValidationResult validationResult)
        {
            ValidationResult = validationResult;
        }

        public ResponseMessage(T data)
        {
            ValidationResult = new ValidationResult();
            Data = data;
        }

    }

    public static class ResponseMessageFactory
    {
        public static ResponseMessage<T> GerarErrorResponse<T>(ValidationResult validationResult)
        {
            return new ResponseMessage<T>(validationResult);
        }

        public static ResponseMessage<T> GerarResponse<T>(T data)
        {
            return new ResponseMessage<T>(data);
        }
    }
}
