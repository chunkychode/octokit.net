using System.Diagnostics;

namespace Octokit
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    [System.Serializable]  public class CommitCommentPayload : ActivityPayload
    {
        public CommitComment Comment { get; protected set; }
    }
}
