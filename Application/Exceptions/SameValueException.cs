

namespace Application.Exceptions
{
    public class SameValueException : CustomException
    {
        public SameValueException() { }

        public override string ErrorMessage()
        {
            var error = " Namnet är upptaget!";
            return error;
        }

    }
}
