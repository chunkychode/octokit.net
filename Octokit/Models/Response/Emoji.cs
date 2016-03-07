using System;
using System.Diagnostics;
using System.Globalization;

namespace Octokit
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
#if !NETFX_CORE
    [System.Serializable]
#endif
    public class Emoji
    {
        public Emoji() { }

        public Emoji(string name, Uri url)
        {
            Ensure.ArgumentNotNullOrEmptyString(name, "name");
            Ensure.ArgumentNotNull(url, "url");

            Name = name;
            Url = url;
        }

        public string Name { get; private set; }
        public Uri Url { get; private set; }

        internal string DebuggerDisplay
        {
            get
            {
                return string.Format(CultureInfo.InvariantCulture, "Name {0} ", Name);
            }
        }
    }
}
