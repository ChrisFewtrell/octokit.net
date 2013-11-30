using System;

namespace Octokit
{
    /// <summary>
    /// Describes the pull request related to a particular <see cref="Issue"/>. 
    /// </summary>
    public class PullRequestDetails
    {
        public Uri HtmlUrl { get; set; }
        public Uri DiffUrl { get; set; }
        public Uri PatchUrl { get; set; }
    }
}