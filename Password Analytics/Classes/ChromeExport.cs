namespace Password_Analytics.Classes
{
    public class ChromeExport
    {
        /// <summary>
        /// URL field in Chrome Export
        /// </summary>
        public string uri { get; set; }

        /// <summary>
        /// Service field in Chrome Export
        /// </summary>
        public string service { get; set; }

        /// <summary>
        /// Username field in Chrome Export
        /// </summary>
        public string user { get; set; }
       
        /// <summary>
        /// Password field in Chrome Export
        /// </summary>
        private string Pass;
        public string pass
        {
            get
            {
                if (string.IsNullOrEmpty(Pass))
                {
                    return Pass = "No Password Set";
                }
                else
                {
                    return Pass;
                }
            }
            set { Pass = value; }
        }

        /// <summary>
        /// Tag field in Chrome Export
        /// </summary>
        public string tags { get; set; }
    }
}
