using System.Collections.Generic;
using System.Diagnostics;
using Octokit.Internal;

namespace Octokit
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
#if !NETFX_CORE
    [System.Serializable]
#endif
    public class SearchUsersResult : SearchResult<User>
    {
        public SearchUsersResult() { }

        public SearchUsersResult(int totalCount, bool incompleteResults, IReadOnlyList<User> items)
            : base(totalCount, incompleteResults, items)
        {
        }
    }
}