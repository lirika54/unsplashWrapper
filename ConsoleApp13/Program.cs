public class Image
{
    public string Id {get; set;}
    public string created_at {get; set;}
    public string updated_at {get; set;}
    public int width { get; set;}
    public int height { get; set;}
    public string color { get; set; } 
    public string blur_hash { get; set;}
    public int downloads { get; set;}
    public int likes { get; set;}
    public bool liked_by_user { get; set;}
    public string description { get; set;}

    public class Exif
    {
        public string make { get; set; }
        public string model { get; set; } //??
        public string exposure_time { get; set; }
        public string aperture { get; set; }
        public string focal_length { get; set; }
        public int iso { get; set; }
    }
    public class Location
    {
        public string name { get; set; }
        public string city { get; set; }
        public string country { get; set; }

        public class Position
        {
            public double latitude { get; set; }
            public double longitude { get; set; }
        }
    }

    public class current_user_collections
    {
        public int id { get; set; }
        public string title { get; set; }
        public string published_at { get; set; }
        public string last_collected_at { get; set; }
        public int? cover_photo { get; set; } //??
        public int? user { get; set; }
    }
    public class urls { 
    
        public string raw { get; set; }
        public string full {  get; set; }
        public string regular { get; set; }
        public string small { get; set; }
        public string thumb { get; set; }

    }

    public class links
    {
        public string self { get; set; }
        public string html { get; set; }
        public string downoload { get; set; }
        public string downoload_location { get; set; }
    }
    public class user
    {
        public string id { get; set; }
        public string updated_at { get; set; }
        public string username { get; set; }
        public string name { get; set; }
        public string portfolio_url { get; set; }
        public string bio { get; set; }
        public string location { get; set; }
        public int total_likes { get; set; }
        public int total_photo { get; set; }
        public int total_collections { get; set; }
        public string instagram_username { get; set; }
        public string twitter_username { get; set; }
        public class links
        {
            public string self { get; set; }
            public string html { get; set; }
            public string photos { get; set; }
            public string likes { get; set; }
            public string portfolio { get; set; }
        }
    }
}

