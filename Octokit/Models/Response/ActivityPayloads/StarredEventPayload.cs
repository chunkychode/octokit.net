using System.Diagnostics;

namespace Octokit
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    [System.Serializable]  public class StarredEventPayload : ActivityPayload
    {
        public string Action { get; protected set; }
    }
}
