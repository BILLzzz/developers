namespace PluginsMVC3Sample.Models.Trustpilot
{
    using System;
    using System.Collections.Generic;

    public class User
    {
        public string Name { get; set; }

        public string City { get; set; }

        public string Locale { get; set; }

        public int ReviewCount { get; set; }

        [Obsolete("It is replaced by Review.IsVerified")]
        public bool IsVerified { get; set; }

        public bool HasImage { get; set; }

        public Dictionary<string, string> ImageUrls { get; set; }
    }
}
