

namespace Application
{
    public class CancelOrEmtpyException : CustomException
    {
        public override string ErrorMessage()
        {
            var error = base.ErrorMessage();
            error += "Du avbröt sparningen eller angav oglitigt namn";
            return error;
        }
    }
}
