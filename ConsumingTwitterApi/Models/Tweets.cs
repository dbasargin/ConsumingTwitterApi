using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace ConsumingTwitterApi.Models
{

    //    THIS REPRESENTS THE TWEET OBJECT Sent back from Twitters API
    //
    //    Call This method: with Twitter Json API response to create a list of RetweetedStatus objects.
    // 
    //    var data = GettingStarted.FromJson(jsonString);
    //
    
    public partial class RetweetedStatus
    {
        public const string Const_TwitterDateTemplate = "ddd MMM dd HH:mm:ss +ffff yyyy";

        [JsonProperty("geo")]
        public object Geo { get; set; }

        [JsonProperty("is_quote_status")]
        public bool IsQuoteStatus { get; set; }

        [JsonProperty("entities")]
        public Entities Entities { get; set; }

        [JsonProperty("coordinates")]
        public object Coordinates { get; set; }

        [JsonProperty("contributors")]
        public object Contributors { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("favorite_count")]
        public long FavoriteCount { get; set; }

        [JsonProperty("extended_entities")]
        public ExtendedEntities ExtendedEntities { get; set; }

        [JsonProperty("favorited")]
        public bool Favorited { get; set; }

        [JsonProperty("in_reply_to_status_id")]
        public object InReplyToStatusId { get; set; }

        [JsonProperty("id_str")]
        public string IdStr { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("in_reply_to_screen_name")]
        public object InReplyToScreenName { get; set; }

        [JsonProperty("in_reply_to_user_id")]
        public object InReplyToUserId { get; set; }

        [JsonProperty("in_reply_to_status_id_str")]
        public object InReplyToStatusIdStr { get; set; }

        [JsonProperty("in_reply_to_user_id_str")]
        public object InReplyToUserIdStr { get; set; }

        [JsonProperty("retweet_count")]
        public long RetweetCount { get; set; }

        [JsonProperty("place")]
        public object Place { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("possibly_sensitive")]
        public bool? PossiblySensitive { get; set; }

        [JsonProperty("retweeted_status")]
        public RetweetedStatus OtherRetweetedStatus { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("retweeted")]
        public bool Retweeted { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("truncated")]
        public bool Truncated { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        public string GetFormattedCreatedAt()
        {
            DateTime createdAt = DateTime.ParseExact(CreatedAt, Const_TwitterDateTemplate, new System.Globalization.CultureInfo("en-US"));
            return createdAt.ToShortDateString();
        }
    }

    public partial class Entities
    {
        [JsonProperty("media")]
        public List<Media> Media { get; set; }

        [JsonProperty("urls")]
        public List<Url> Urls { get; set; }

        [JsonProperty("hashtags")]
        public List<object> Hashtags { get; set; }

        [JsonProperty("symbols")]
        public List<object> Symbols { get; set; }

        [JsonProperty("user_mentions")]
        public List<UserMention> UserMentions { get; set; }
    }

    public partial class Media
    {
        [JsonProperty("id_str")]
        public string IdStr { get; set; }

        [JsonProperty("sizes")]
        public Sizes Sizes { get; set; }

        [JsonProperty("expanded_url")]
        public string ExpandedUrl { get; set; }

        [JsonProperty("display_url")]
        public string DisplayUrl { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("media_url")]
        public string MediaUrl { get; set; }

        [JsonProperty("indices")]
        public List<long> Indices { get; set; }

        [JsonProperty("media_url_https")]
        public string MediaUrlHttps { get; set; }

        [JsonProperty("source_status_id_str")]
        public string SourceStatusIdStr { get; set; }

        [JsonProperty("source_user_id_str")]
        public string SourceUserIdStr { get; set; }

        [JsonProperty("source_status_id")]
        public long? SourceStatusId { get; set; }

        [JsonProperty("source_user_id")]
        public long? SourceUserId { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public partial class Sizes
    {
        [JsonProperty("medium")]
        public Large Medium { get; set; }

        [JsonProperty("large")]
        public Large Large { get; set; }

        [JsonProperty("small")]
        public Large Small { get; set; }

        [JsonProperty("thumb")]
        public Large Thumb { get; set; }
    }

    public partial class Large
    {
        [JsonProperty("resize")]
        public string Resize { get; set; }

        [JsonProperty("h")]
        public long H { get; set; }

        [JsonProperty("w")]
        public long W { get; set; }
    }

    public partial class Url
    {
        [JsonProperty("expanded_url")]
        public string ExpandedUrl { get; set; }

        [JsonProperty("display_url")]
        public string DisplayUrl { get; set; }

        [JsonProperty("indices")]
        public List<long> Indices { get; set; }

        [JsonProperty("url")]
        public string OtherUrl { get; set; }
    }

    public partial class UserMention
    {
        [JsonProperty("id_str")]
        public string IdStr { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("indices")]
        public List<long> Indices { get; set; }

        [JsonProperty("screen_name")]
        public string ScreenName { get; set; }
    }

    public partial class ExtendedEntities
    {
        [JsonProperty("media")]
        public List<Media> Media { get; set; }
    }

    public partial class User
    {
        [JsonProperty("is_translation_enabled")]
        public bool IsTranslationEnabled { get; set; }

        [JsonProperty("follow_request_sent")]
        public object FollowRequestSent { get; set; }

        [JsonProperty("default_profile_image")]
        public bool DefaultProfileImage { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("contributors_enabled")]
        public bool ContributorsEnabled { get; set; }

        [JsonProperty("default_profile")]
        public bool DefaultProfile { get; set; }

        [JsonProperty("entities")]
        public OtherEntities Entities { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("favourites_count")]
        public long FavouritesCount { get; set; }

        [JsonProperty("geo_enabled")]
        public bool GeoEnabled { get; set; }

        [JsonProperty("following")]
        public object Following { get; set; }

        [JsonProperty("followers_count")]
        public long FollowersCount { get; set; }

        [JsonProperty("friends_count")]
        public long FriendsCount { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("has_extended_profile")]
        public bool HasExtendedProfile { get; set; }

        [JsonProperty("id_str")]
        public string IdStr { get; set; }

        [JsonProperty("profile_background_image_url")]
        public string ProfileBackgroundImageUrl { get; set; }

        [JsonProperty("profile_sidebar_fill_color")]
        public string ProfileSidebarFillColor { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("lang")]
        public string Lang { get; set; }

        [JsonProperty("is_translator")]
        public bool IsTranslator { get; set; }

        [JsonProperty("listed_count")]
        public long ListedCount { get; set; }

        [JsonProperty("notifications")]
        public object Notifications { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("profile_background_color")]
        public string ProfileBackgroundColor { get; set; }

        [JsonProperty("profile_image_url")]
        public string ProfileImageUrl { get; set; }

        [JsonProperty("profile_background_tile")]
        public bool ProfileBackgroundTile { get; set; }

        [JsonProperty("profile_background_image_url_https")]
        public string ProfileBackgroundImageUrlHttps { get; set; }

        [JsonProperty("profile_banner_url")]
        public string ProfileBannerUrl { get; set; }

        [JsonProperty("profile_link_color")]
        public string ProfileLinkColor { get; set; }

        [JsonProperty("profile_image_url_https")]
        public string ProfileImageUrlHttps { get; set; }

        [JsonProperty("profile_sidebar_border_color")]
        public string ProfileSidebarBorderColor { get; set; }

        [JsonProperty("screen_name")]
        public string ScreenName { get; set; }

        [JsonProperty("profile_use_background_image")]
        public bool ProfileUseBackgroundImage { get; set; }

        [JsonProperty("profile_text_color")]
        public string ProfileTextColor { get; set; }

        [JsonProperty("protected")]
        public bool Protected { get; set; }

        [JsonProperty("time_zone")]
        public string TimeZone { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("statuses_count")]
        public long StatusesCount { get; set; }

        [JsonProperty("translator_type")]
        public string TranslatorType { get; set; }

        [JsonProperty("utc_offset")]
        public double UtcOffset { get; set; }

        [JsonProperty("verified")]
        public bool Verified { get; set; }
    }

    public partial class OtherEntities
    {
        [JsonProperty("description")]
        public Description Description { get; set; }

        [JsonProperty("url")]
        public Description Url { get; set; }
    }

    public partial class Description
    {
        [JsonProperty("urls")]
        public List<Url> Urls { get; set; }
    }

    public partial class GettingStarted
    {
        public static List<RetweetedStatus> FromJson(string json) => JsonConvert.DeserializeObject<List<RetweetedStatus>>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this List<RetweetedStatus> self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    public class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };
    }
    
}