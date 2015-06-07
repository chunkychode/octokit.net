﻿using System;
using System.Diagnostics;
using System.Globalization;

namespace Octokit
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    [System.Serializable]  public class BlobReference
    {
        public BlobReference() { }

        public BlobReference(string sha)
        {
            Sha = sha;
        }

        /// <summary>
        /// The SHA of the blob.
        /// </summary>
        public string Sha { get; protected set; }

        internal string DebuggerDisplay
        {
            get
            {
                return String.Format(CultureInfo.InvariantCulture, "Sha: {0}", Sha);
            }
        }
    }
}