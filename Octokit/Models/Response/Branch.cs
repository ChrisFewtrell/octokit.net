namespace Octokit.Response
{
    public class Branch : GitReference
    {
        public string Label { get; set; }
        public string Ref { get; set; }
        public User User { get; set; }
        public Repository Repo { get; set; }
    }
}