using System.Diagnostics;

namespace Octokit
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    [System.Serializable]  public class PullRequestCommentPayload : ActivityPayload
    {
        public string Action { get; protected set; }
        public PullRequest PullRequest { get; protected set; }
        public PullRequestReviewComment Comment { get; protected set; }
    }
}
