using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;


namespace API.Identity
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, Inherited = false)]
    public class ManagerRole : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.HttpContext.User.Identity.IsAuthenticated && context.HttpContext.User.HasClaim(c => c.Value == "Manager"))
                base.OnActionExecuting(context);
            else
                context.Result = new EmptyResult();
        }
    }
}
