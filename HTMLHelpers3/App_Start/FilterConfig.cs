﻿using System.Web;
using System.Web.Mvc;

namespace HTMLHelpers3
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
