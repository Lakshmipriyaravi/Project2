namespace Cafe_management.Exceptions
{
    public class UserAlreadyExistsException : ApplicationException
    {
        public UserAlreadyExistsException(string msg) : base(msg) { }
        public UserAlreadyExistsException()
        {
            
        }
    }
}
