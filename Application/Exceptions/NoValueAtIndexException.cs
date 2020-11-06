

namespace Application
{
    // Custom exception class
    public class NoValueAtIndexException : CustomException
    {
        public NoValueAtIndexException() { }

        public override string ErrorMessage()
        {
            var error = " Det finns inget angivet värde att hämta";
            return error;
        }

    }
}
