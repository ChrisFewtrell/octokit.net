using System.Collections.Generic;
using System.Threading.Tasks;
using Octokit.Response;

namespace Octokit
{
    public interface IPullRequestsClient
    {
        /// <summary>
        /// Gets all pull requests for the given repository
        /// </summary>
        /// <remarks>
        /// http://developer.github.com/v3/pulls/#list-pull-requests
        /// </remarks>
        /// <param name="owner">The owner of the repository</param>
        /// <param name="name">The name of the repository</param>
        /// <returns></returns>
        Task<IReadOnlyList<PullRequest>> GetAll(string owner, string name);
    }
}