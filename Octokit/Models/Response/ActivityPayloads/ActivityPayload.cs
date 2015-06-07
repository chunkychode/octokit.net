﻿using System.Diagnostics;

namespace Octokit
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    [System.Serializable]  public class ActivityPayload
    {
        public Repository Repository { get; protected set; }
        public User Sender { get; protected set; }

        internal string DebuggerDisplay
        {
            get { return this.Repository.FullName; }
        }
    }
}
