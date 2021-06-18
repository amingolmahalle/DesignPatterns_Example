namespace Builder
{
    public sealed class QueryBuilderCreator
    {
        public IQueryBuilder Construct(IQueryBuilder queryBuilderBuilder)
        {
            return queryBuilderBuilder;
        }
    }
}