using System;

namespace Octokit
{
    /// <summary>
    /// Represents the data and name parsed from the Ssh key.
    /// </summary>
#if !NETFX_CORE
    [System.Serializable]
#endif
    public class SshKeyInfo
    {
        public SshKeyInfo(string data, string name)
        {
            Ensure.ArgumentNotNull(data, "data");
            Ensure.ArgumentNotNull(name, "name");

            Data = data;
            Name = name;
        }

        public string Data { get; private set; }
        public string Name { get; private set; }
    }
}