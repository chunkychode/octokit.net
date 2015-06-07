using System.Diagnostics;

namespace Octokit
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    [System.Serializable]  public class ForkEventPayload : ActivityPayload
    {
        public Repository Forkee { get; protected set; }
    }
}
