using Microsoft.AspNetCore.Mvc.Filters;

namespace Resume.Presentation.ActionFilters
{
    public class RedirectHomeIfLoggedInActionFilters:ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);

            if(context.HttpContext.User.Identity.IsAuthenticated)
            {
                context.HttpContext.Response.Redirect("/");
            }
        }
    }
}
