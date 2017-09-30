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
        public static string getTwitterAccess()
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
            catch //if credentials are not valid (403 error)
            {
                //TODO
            }
            return access_token;
        }

        //This accepts a Twitter Access token, 
        // retrieves 3 last Tweets from the POTUS Twitter Account Via Twitter API, 
        // Formats these Tweets and returns them in a List<String>.
        public static List<Tweet> getTweet(string access_token) {

            //Create webrequest for Twitter API
            var gettimeline = WebRequest.Create("https://api.twitter.com/1.1/statuses/user_timeline.json?count=3&screen_name=dennisbasargin") as HttpWebRequest;
            gettimeline.Method = "GET";
            gettimeline.Headers[HttpRequestHeader.Authorization] = "Bearer " + access_token;

            //List<String> listOfTweetStrings = new List<String>(); //To do: make this Tweet objects, let view handle formatting
            List<Tweet> listOfTweets = new List<Tweet>();

            //send request
            try
            {
                string respbody = null;
                using (var resp = gettimeline.GetResponse().GetResponseStream())//there request sends
                {
                    var respR = new StreamReader(resp);

                    respbody = respR.ReadToEnd();
                    
                }

                //parse json
                dynamic dynTweet = JsonConvert.DeserializeObject(respbody);

                foreach (dynamic twit in dynTweet)
                {
                    Tweet newTweetObj = new Tweet(twit);
                    //listOfTweetStrings.Add(newTweetObj.user.ToString() + ": " + newTweetObj.ToString());
                    listOfTweets.Add(newTweetObj);
                }

            }
            catch //401 (access token invalid or expired)
            {
                //listOfTweetStrings.Add("Error getting requested Tweet");
            }

            //return listOfTweetStrings;
            return listOfTweets;
        }

    }
}