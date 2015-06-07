using System.Diagnostics;

namespace Octokit
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    [System.Serializable]  public class IssueCommentPayload : ActivityPayload
    {
        // should always be "created" according to github api docs
        public string Action { get; protected set; }
        public Issue Issue { get; protected set; }
        public IssueComment Comment { get; protected set; }

    }
}
