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

        public Task<IReadOnlyList<PullRequest>> GetForRepository(string owner, string name)
        {
            return GetForRepository(owner, name, new PullRequestRequestParameters());
        }

        public Task<IReadOnlyList<PullRequest>> GetForRepository(string owner, string name, PullRequestRequestParameters request)
        {
            Ensure.ArgumentNotNullOrEmptyString(owner, "owner");
            Ensure.ArgumentNotNullOrEmptyString(name, "name");
            Ensure.ArgumentNotNull(request, "request");

            return ApiConnection.GetAll<PullRequest>(ApiUrls.PullRequests(owner, name), request.ToParametersDictionary());
        }
    }
}