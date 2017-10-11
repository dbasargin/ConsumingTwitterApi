using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConsumingTwitterApi.Models
{
    public static class SessonHelper
    {
        public static void CreateSession(Controller c)
        {
            c.Session["TwitterToken"] = TwitterHelperClass.getTwitterAccessToken();
        }

        public static bool SessionActive(Controller c)
        {
            if (c.Session["TwitterToken"] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static string GetSessionToken(Controller c)
        {
            return c.Session["TwitterToken"].ToString();
        }

    }
}