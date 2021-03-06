using System.Collections.Generic;

namespace Builder.Sample1
{
    public interface IQueryBuilder
    {
        IQueryBuilder Table(string tableName);
        
        IQueryBuilder Select(IEnumerable<string> columns);
        
        IQueryBuilder Where(string key,string value);
        
        IQueryBuilder Limit(int limit);
        
        void Build();
    }
}