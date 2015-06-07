using System.Diagnostics;

namespace Octokit
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    [System.Serializable]  public class IssueEventPayload : ActivityPayload
    {
        public string Action { get; protected set; }
        public Issue Issue { get; protected set; }
        public User Assignee { get; protected set; }
        public Label Label { get; protected set; }
    }
}
