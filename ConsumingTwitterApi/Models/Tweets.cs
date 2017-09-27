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
        public string id { get; set; }
        public string id_str { get; set; }
        public string name { get; set; }
        public string screen_name { get; set; }
        public string location { get; set; }
        public string url { get; set; }
        public string description { get; set; }
        public string verified { get; set; }
        public string followers_count { get; set; }
        public string friends_count { get; set; }
        public string listed_count { get; set; }
        public string favourites_count { get; set; }
        public string statuses_count { get; set; }
        public string created_at { get; set; }
        public string utc_offset { get; set; }
        public string time_zone { get; set; }
        public string geo_enabled { get; set; }
        public string lang { get; set; }
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
        
        //public TwitterUser user { get; set; }

        public override string ToString()
        {
            return created_at + ", " + id_str + ", " + text;
        }
    }
    
}