using System.Collections.Generic;
using System.Threading.Tasks;
using Octokit.Response;

namespace Octokit
{
    public class PullRequestsClient : ApiClient, IPullRequestsClient
    {
        public PullRequestsClient(IApiConnection apiConnection) : base(apiConnection)
        {
        }

        public Task<IReadOnlyList<PullRequest>> GetAll(string owner, string name)
        {
            Ensure.ArgumentNotNullOrEmptyString(owner, "owner");
            Ensure.ArgumentNotNullOrEmptyString(name, "name");

            return ApiConnection.GetAll<PullRequest>(ApiUrls.PullRequests(owner, name));
        }
    }
}