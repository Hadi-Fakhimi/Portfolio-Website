using Microsoft.AspNetCore.Mvc.Filters;

namespace Resume_V2.Presenation.ActionFilters
{
    public class RedirectHomeIfLogedInActionFilters:ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);

            if (context.HttpContext.User.Identity.IsAuthenticated)
            {
                context.HttpContext.Response.Redirect("/");
            }
        }
    }
}
