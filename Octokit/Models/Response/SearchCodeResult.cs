using System.Collections.Generic;
using System.Diagnostics;
using Octokit.Internal;

namespace Octokit
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
#if !NETFX_CORE
    [System.Serializable]
#endif
    public class SearchCodeResult : SearchResult<SearchCode>
    {
        public SearchCodeResult() { }

        public SearchCodeResult(int totalCount, bool incompleteResults, IReadOnlyList<SearchCode> items)
            : base(totalCount, incompleteResults, items)
        {
        }
    }
}