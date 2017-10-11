using ConsumingTwitterApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConsumingTwitterApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string token;

            if (Session["TwitterToken"] == null)
            {
                try
                {
                    // create session
                    Session["TwitterToken"] = TwitterHelperClass.getTwitterAccessToken();
                    token = Session["TwitterToken"].ToString();
                }
                catch(Exception ex)
                {
                    return View("Error Getting Twitter Token: Of type:" + ex.GetType());
                }
            }
            else
            {
                token = Session["TwitterToken"].ToString();
            }

            List<RetweetedStatus> tweetsList = TwitterHelperClass.getTweet(token, "POTUS");

            return View(tweetsList);
        }

        public ActionResult SearchByScreenName(string twitterScreenName)
        {
            string token;

            if (Session["TwitterToken"] == null)
            {
                // create session
                Session["TwitterToken"] = TwitterHelperClass.getTwitterAccessToken();
            }

            token = Session["TwitterToken"].ToString();

            List<RetweetedStatus> tweetsList = TwitterHelperClass.getTweet(token, twitterScreenName);

            return View("Index", tweetsList);
        }
    }
}