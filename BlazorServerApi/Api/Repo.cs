namespace BlazorServerApi.Api
{
    public static class Repo
    {
        public static IList<string> Strings { get; } = new List<string> { "one", "two", "three", "four", "five" };
    }
}
