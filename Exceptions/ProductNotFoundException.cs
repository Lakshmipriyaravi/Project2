using Microsoft.AspNetCore.Mvc.Diagnostics;

namespace Cafe_management.Exceptions
{
    public class ProductNotFoundException : ApplicationException
    {
        public ProductNotFoundException(string msg) : base(msg)
        {
            
        }
        public ProductNotFoundException()
        {
            
        }
    }
}
