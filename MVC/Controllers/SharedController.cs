using System;
using System.Threading;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class SharedController : Controller
    {
        public ActionResult SetLanguage(int id)
        {
            Helper.Helper.CurrentCulture = id;
            if (!(Request.UrlReferrer is null))
            {
                return Redirect(Request.UrlReferrer.ToString());
            }

            return RedirectToRoute("/");
        }

        protected override IAsyncResult BeginExecute(System.Web.Routing.RequestContext requestContext, AsyncCallback callback, object state)
        {
            //to modify thread culture
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture = Helper.Helper.Culture ?? Helper.Helper.LangCultureInfo;


            //default action
            return base.BeginExecute(requestContext, callback, state);
        }

    }
}