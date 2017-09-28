using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsumingTwitterApi.Models
{
    public class TwitterUser
    {
        [JsonProperty("id")]
        public Int64 id { get; set; }

        [JsonProperty("id_str")]
        public string id_str { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("screen_name")]
        public string screen_name { get; set; }

        [JsonProperty("location")]
        public string location { get; set; }

        [JsonProperty("url")]
        public string url { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }

        [JsonProperty("verified")]
        public bool verified { get; set; }

        [JsonProperty("followers_count")]
        public int followers_count { get; set; }

        [JsonProperty("friends_count")]
        public int friends_count { get; set; }

        [JsonProperty("listed_count")]
        public int listed_count { get; set; }

        [JsonProperty("favourites_count")]
        public int favourites_count { get; set; }

        [JsonProperty("statuses_count")]
        public int statuses_count { get; set; }

        [JsonProperty("created_at")]
        public string created_at { get; set; }

        [JsonProperty("utc_offset")]
        public int utc_offset { get; set; }

        [JsonProperty("time_zone")]
        public string time_zone { get; set; }

        [JsonProperty("geo_enabled")]
        public bool geo_enabled { get; set; }

        [JsonProperty("lang")]
        public string lang { get; set; }

        [JsonProperty("profile_image_url_https ")]
        public string profile_image_url_https { get; set; }


        public override string ToString()
        {
            return name + ", " + screen_name + ", " + location + ", "+ description;
        }
    }

    public class Tweet
    {
        [JsonProperty("created_at")]
        public string created_at { get; set; }

        [JsonProperty("id")]
        public Int64 id { get; set; }

        [JsonProperty("id_str")]
        public string id_str { get; set; }

        [JsonProperty("text")]
        public string text { get; set; }

        [JsonProperty("source")]
        public string source { get; set; }

        [JsonProperty("truncated")]
        public bool truncated { get; set; }

        [JsonProperty("in_reply_to_status_id")]
        public string in_reply_to_status_id { get; set; }

        [JsonProperty("in_reply_to_user_id")]
        public Int64 in_reply_to_user_id { get; set; }

        [JsonProperty("in_reply_to_user_id_str")]
        public string in_reply_to_user_id_str { get; set; }

        [JsonProperty("in_reply_to_screen_name")]
        public string in_reply_to_screen_name { get; set; }

        [JsonProperty("user")]
        public TwitterUser user { get; set; }

        public override string ToString()
        {
            return created_at + ", " + id_str + ", " + text;
        }
    }
    
}