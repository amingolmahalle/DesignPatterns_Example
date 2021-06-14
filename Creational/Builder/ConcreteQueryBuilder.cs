namespace Builder
{
    public sealed class ConcreteQueryBuilder
    {
        public IQueryBuilder Construct(IQueryBuilder queryBuilderBuilder)
        {
            return queryBuilderBuilder;
        }
    }
}