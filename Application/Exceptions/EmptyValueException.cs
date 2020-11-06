

namespace Application
{
  
    public class EmptyValueException : CustomException
    {
        public EmptyValueException() {}

        public override string ErrorMessage()
        {
            var error = " Du måste fylla i alla textrutor";
            return error;
        }

    }
    
}
