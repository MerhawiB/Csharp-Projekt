
namespace Application
{
    public class NotAValidURLException : CustomException
    {
        public NotAValidURLException() { }
        
            public override string ErrorMessage()
        {
            var error = " Url:en du angivit är ogiltig";
            return error;
        }
    }
    
}
