namespace Cafe_management.Exceptions
{
    public class UserNotFoundException : ApplicationException
    {
        public UserNotFoundException(string msg) : base(msg)
        {
            
        }
        public UserNotFoundException()
        {
            
        }
    }
}
