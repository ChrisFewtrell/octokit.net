namespace Octokit
{
    public class PullRequestRequest : RequestParameters
    {
        public PullRequestState State { get; set; }
        
        /// <summary>
        /// Filter pulls by head user and branch name in the format of user:ref-name. Example: github:new-script-format
        /// </summary>
        public string Head { get; set; }

        /// <summary>
        /// Filter pulls by base branch name.
        /// </summary>
        public string Base { get; set; }
    }

    public enum PullRequestState
    {
        Open,
        Closed
    }
}