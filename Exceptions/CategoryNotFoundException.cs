namespace Cafe_management.Exceptions
{
    public class CategoryNotFoundException : ApplicationException
    {
        public CategoryNotFoundException(string msg) :base(msg) { }
        public CategoryNotFoundException()
        {
            
        }
    }
}
