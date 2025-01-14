namespace WebApi.Entities
{
    public class LoadRequest
    {
        public string? filter { get; set; }
        public string? group { get; set; }

        public bool requireTotalCount { get; set; }

        public string? searchExpr { get; set; }

        public string? searchOperation { get; set; }
        public dynamic? searchValue { get; set; }
        public int skip { get; set; }
        public string? sort { get; set; }
        public int take { get; set; }
    }
}
