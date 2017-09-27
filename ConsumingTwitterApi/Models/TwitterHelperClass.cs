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

            string credentials = "ZGVZSTBKTVBQSThjZmMzdFdPWUVaRm1JMjplb0loV1BRVlhFRUZNNm5HUTBKT2xFakFvNWNqSDd5NmVYU0pVNlU1VklNdzB5aGNTaQ==";

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

        public static List<String> getTweet(string access_token) { 
            var gettimeline = WebRequest.Create("https://api.twitter.com/1.1/statuses/user_timeline.json?count=3&screen_name=DennisBasargin") as HttpWebRequest;
            gettimeline.Method = "GET";
            gettimeline.Headers[HttpRequestHeader.Authorization] = "Bearer " + access_token;

            List<String> dataIn = new List<String>();

            try
            {
                string respbody = null;
                using (var resp = gettimeline.GetResponse().GetResponseStream())//there request sends
                {
                    var respR = new StreamReader(resp);

                    respbody = respR.ReadToEnd();
                    
                }

                //TODO use a library to parse json

                //first Tweet pulling object data Dynamically: THIS IS WORKING
                dynamic dynTweet = JsonConvert.DeserializeObject(respbody);
                dataIn.Add(dynTweet[0].text.ToString());

                //To Do: CONVERT TO TWITTER OBJECT
                //List<Tweet> r = JsonConvert.DeserializeObject<List<Tweet>>(respbody);
                //foreach(var twit in r)
                //{
                //    dataIn.Add(twit.ToString());
                //}
            }
            catch //401 (access token invalid or expired)
            {
                    //TODO
            }

            return dataIn;
        }

    }
}