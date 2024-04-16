using Microsoft.AspNetCore.Mvc.Filters;

namespace Cafe_management.Aspects
{
    public class ExceptionHandlerAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            base.OnException(context);
        }
    }
}
