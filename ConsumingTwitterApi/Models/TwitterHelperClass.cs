using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace ConsumingTwitterApi.Models
{
    public class TwitterHelperClass
    {
        public static string getTwitterAccessToken()
        {
            string access_token = "";

            string credentials = Creds.getCredentials();

            var post = WebRequest.Create("https://api.twitter.com/oauth2/token") as HttpWebRequest;

            post.Method = "POST";

            post.ContentType = "application/x-www-form-urlencoded";

            post.Headers[HttpRequestHeader.Authorization] = "Basic " + credentials;

            var reqbody = Encoding.UTF8.GetBytes("grant_type=client_credentials");
            post.ContentLength = reqbody.Length;

            using (var req = post.GetRequestStream())
            {
                req.Write(reqbody, 0, reqbody.Length);
            }
            try
            {
                string respbody = null;
                using (var resp = post.GetResponse().GetResponseStream())//there request sends
                {
                    var respR = new StreamReader(resp);
                    respbody = respR.ReadToEnd();
                }
                //TODO use a library to parse json
                access_token = respbody.Substring(respbody.IndexOf("access_token\":\"") + "access_token\":\"".Length, respbody.IndexOf("\"}") - (respbody.IndexOf("access_token\":\"") + "access_token\":\"".Length));
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return access_token;
        }

        //This accepts a Twitter Access token, 
        // retrieves 3 last Tweets from the screenName Twitter Account Via Twitter API, 
        // Formats these Tweets and returns them in a List<String>.
        public static List<RetweetedStatus> getTweet(string access_token, string screenName) {
        

            //Create webrequest for Twitter API
            var gettimeline = WebRequest.Create("https://api.twitter.com/1.1/statuses/user_timeline.json?count=3&screen_name=" + screenName) as HttpWebRequest;
                gettimeline.Method = "GET";
                gettimeline.Headers[HttpRequestHeader.Authorization] = "Bearer " + access_token;
            
            List<RetweetedStatus> listOfTweets = new List<RetweetedStatus>();

            //send request
            try
            {
                string respbody = null;
                using (var resp = gettimeline.GetResponse().GetResponseStream())//there request sends
                {
                    var respR = new StreamReader(resp);

                    respbody = respR.ReadToEnd();
                    
                }
                listOfTweets = GettingStarted.FromJson(respbody);

            }
            catch //401 (access token invalid or expired)
            {
                //To Do: handle- error getting Tweets
            }

            //return listOfTweetStrings;
            return listOfTweets;
        }

        public static bool IsTwitterTokenAvailable()
        {
            if (HttpContext.Current.Session["TwitterToken"] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static void AbandonSession()
        {
            HttpContext.Current.Session.Remove("TwitterToken");
        }

    }
}