namespace Cafe_management.Exceptions
{
    public class CartNotFoundException : ApplicationException
    {
        public CartNotFoundException(string msg) : base(msg) { }
        public CartNotFoundException()
        {
            
        }
    }
}
