using System;


namespace Application
{
    // Custom exception class which all the other custom made exception classes inheriate from
    public abstract class CustomException : Exception
    {
        public CustomException() : base("Illegal operation for " + "An error has occured"){}

        public virtual string ErrorMessage()
        {
           var error = "Ett fel har uppstått: ";
           return error;
        }
    }
}
