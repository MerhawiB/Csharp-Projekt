
namespace Application.Exceptions
{
    public class SameUrlValueException : CustomException
    {
        public SameUrlValueException(){}

        public override string ErrorMessage()
        {
            var error = " Finns redan en pod med detta URL!";
            return error;
        }

    }
}
