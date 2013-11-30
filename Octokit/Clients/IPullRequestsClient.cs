using System.Collections.Generic;
using System.Threading.Tasks;
using Octokit.Response;

namespace Octokit
{
    public interface IPullRequestsClient
    {
        /// <summary>
        /// Gets a single pull request.
        /// </summary>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="number">The pull request number</param>
        /// <returns></returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1716:IdentifiersShouldNotMatchKeywords", MessageId = "Get")]
        Task<PullRequest> Get(string owner, string name, int number);

        /// <summary>
        /// Gets all pull requests for the given repository
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/pulls/#list-pull-requests
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <returns></returns>
        Task<IReadOnlyList<PullRequest>> GetForRepository(string owner, string name);

        /// <summary>
        /// Gets all pull requests for the given repository
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/pulls/#list-pull-requests
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <param name="request">Used to filter the pull requests returned.</param>
        /// <returns></returns>
        Task<IReadOnlyList<PullRequest>> GetForRepository(string owner, string name, PullRequestRequestParameters request);
    }
}