using System;
using System.Collections.Generic;
using NSubstitute;
using Octokit;
using Octokit.Response;
using Octokit.Tests.Helpers;
using Xunit;

public class PullRequestsClientTests
{
    public class TheGetMethod
    {
        [Fact]
        public async void EnsuresNonNullArguments()
        {
            var client = new PullRequestsClient(Substitute.For<IApiConnection>());

            await AssertEx.Throws<ArgumentNullException>(async () => await client.Get(null, "name", 1));
            await AssertEx.Throws<ArgumentNullException>(async () => await client.Get("owner", null, 1));
            await AssertEx.Throws<ArgumentException>(async () => await client.Get("", "name", 1));
            await AssertEx.Throws<ArgumentException>(async () => await client.Get("owner", "", 1));
        }

        [Fact]
        public void RequestsCorrectUrl()
        {
            var connection = Substitute.For<IApiConnection>();
            var client = new PullRequestsClient(connection);

            client.Get("owner", "repo", 123);

            connection.Received().Get<PullRequest>(Arg.Is<Uri>(u => u.ToString() == "repos/owner/repo/pulls/123"), null);
        }
    }

    public class TheGetForRepositoryMethod
    {
        [Fact]
        public async void EnsuresNonNullArguments()
        {
            var client = new PullRequestsClient(Substitute.For<IApiConnection>());
            var requestParameters = new PullRequestRequestParameters();

            await AssertEx.Throws<ArgumentNullException>(async () => await client.GetForRepository(null, "name", requestParameters));
            await AssertEx.Throws<ArgumentNullException>(async () => await client.GetForRepository("owner", null, requestParameters));
            await AssertEx.Throws<ArgumentNullException>(async () => await client.GetForRepository("owner", "name", null));
            await AssertEx.Throws<ArgumentException>(async () => await client.GetForRepository("", "name", requestParameters));
            await AssertEx.Throws<ArgumentException>(async () => await client.GetForRepository("owner", "", requestParameters));
        }

        [Fact]
        public void RequestsCorrectUrl()
        {
            var connection = Substitute.For<IApiConnection>();
            var client = new PullRequestsClient(connection);

            client.GetForRepository("owner", "repo", new PullRequestRequestParameters { State = PullRequestState.Closed });

            connection.Received().GetAll<PullRequest>(Arg.Is<Uri>(u => u.ToString() == "repos/owner/repo/pulls"), Arg.Any<IDictionary<string, string>>());
        }
    }

    public class TheCtor
    {
        [Fact]
        public void EnsuresArgument()
        {
            Assert.Throws<ArgumentNullException>(() => new PullRequestsClient(null));
        }
    }
}
