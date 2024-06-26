using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Primitives;
using System.Net;

namespace ActionFilter_API_Demo.Filters
{
    public class GlobalSampleActionFilter : IActionFilter
    {
        private readonly IGlobalSampleActionFilterService _globalSampleActionFilterService;

        public GlobalSampleActionFilter(IGlobalSampleActionFilterService globalSampleActionFilterService)
        {
            _globalSampleActionFilterService = globalSampleActionFilterService;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var actionExecuting = $"{nameof(OnActionExecuting)}.{context.ActionDescriptor.DisplayName}";
            Console.WriteLine(actionExecuting);

            context.Result = new JsonResult(new { Error = _globalSampleActionFilterService.GetName(actionExecuting) }) { StatusCode = 415 };
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {
            var actionExecuted = $"{nameof(OnActionExecuted)}.{context.ActionDescriptor.DisplayName}";
            Console.WriteLine(_globalSampleActionFilterService.GetName(actionExecuted));
        }
    }
}
