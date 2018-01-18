using System;
using System.Web.Mvc;

namespace TestWebApplication.Attribute
{
    public class LogAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            // 紀錄 action 執行完成的 Log
            base.OnActionExecuted(filterContext);
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // 紀錄 action 執行的 Log
            base.OnActionExecuting(filterContext);
        }
    }
}