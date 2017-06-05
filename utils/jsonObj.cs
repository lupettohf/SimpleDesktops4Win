using System.Collections.Generic;

namespace SimpleDesktops4Win
{
    public class Meta
    {
        public int limit { get; set; }
        public string next { get; set; }
        public int offset { get; set; }
        public object previous { get; set; }
        public int total_count { get; set; }
    }

    public class Creator
    {
        public string email { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Object
    {
        public Creator creator { get; set; }
        public string id { get; set; }
        public string iphone_thumb { get; set; }
        public string permalink { get; set; }
        public string title { get; set; }
        public string url { get; set; }
    }

    public class RootObject
    {
        public Meta meta { get; set; }
        public List<Object> objects { get; set; }
    }
}
