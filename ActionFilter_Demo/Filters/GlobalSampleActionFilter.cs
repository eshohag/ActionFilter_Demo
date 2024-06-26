using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace ActionFilter_Demo.Filters
{
    public class GlobalSampleActionFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var actionExecuting = $"{nameof(OnActionExecuting)}.{context.ActionDescriptor.DisplayName}";
            Console.WriteLine(actionExecuting);
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            var actionExecuted = $"{nameof(OnActionExecuted)}.{context.ActionDescriptor.DisplayName}";
            Console.WriteLine(actionExecuted);
        }
    }
}
