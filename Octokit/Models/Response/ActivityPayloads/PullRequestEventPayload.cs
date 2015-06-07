using System.Diagnostics;

namespace Octokit
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    [System.Serializable]  public class PullRequestEventPayload : ActivityPayload
    {
        public string Action { get; protected set; }
        public int Number { get; protected set; }

        public PullRequest PullRequest { get; protected set; }
    }
}
