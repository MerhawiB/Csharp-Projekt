

namespace Application.Exceptions
{
    public class NoIndexException : CustomException
    {
        public NoIndexException(){}

        public override string ErrorMessage()
        {
            var error = "Detta index kunde ej hittas";
            return error;
        }

    }
}
