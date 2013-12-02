using System;

namespace Octokit.Response
{
    public class PullRequest : PullRequestDetails
    {
        public Uri IssueUri { get; set; }
        public Uri StatusesUri { get; set; }
        public int Number { get; set; }
        public PullRequestState State { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTimeOffset CreatedAt { get; set; }
        public DateTimeOffset UpdatedAt { get; set; }
        public DateTimeOffset? ClosedAt { get; set; }
        public DateTimeOffset? MergedAt { get; set; }
        public Branch Head { get; set; }
        public Branch Base { get; set; }
        public User User { get; set; }
        public string MergeCommitSha { get; set; }
        public bool Merged { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Mergeable")]
        public bool Mergeable { get; set; }
        public User MergedBy { get; set; }
        public int Comments { get; set; }
        public int Commits { get; set; }
        public int Additions { get; set; }
        public int Deletions { get; set; }
        public int ChangedFiles { get; set; }
    }
}