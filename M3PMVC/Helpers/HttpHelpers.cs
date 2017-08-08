using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace M3PMVC.Helpers
{
    public static class myhtmlHelpers
    {
        //
        // HtmlHelper for conditional format

        public static MvcHtmlString ccss(this HtmlHelper htmlHelper,
                                           bool isset, string CssClass)
        {
            var Css = String.Empty;
            if (isset)
                Css = string.Format("class=\"{0}\"", CssClass);

            return MvcHtmlString.Create(Css);
        }
    }
    
}