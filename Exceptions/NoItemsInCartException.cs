namespace Cafe_management.Exceptions
{
    public class NoItemsInCartException : ApplicationException
    {
        public NoItemsInCartException(string msg) : base(msg)
        {
            
        }
        public NoItemsInCartException()
        {
            
        }
    }
}
