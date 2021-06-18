using System;
using System.Collections.Generic;
using System.Text;

namespace Builder.ConcreteBuilders
{
    public class MySqlQueryBuilder : IQueryBuilder
    {
        private string _tableName;

        private string _columns = "*";

        private string _key;

        private string _value;

        private int _limit;

        public IQueryBuilder Table(string tableName)
        {
            _tableName = tableName;

            return this;
        }

        public IQueryBuilder Select(IEnumerable<string> columns)
        {
            StringBuilder stringBuilder = new StringBuilder();
            
            foreach (var column in columns)
            {
                stringBuilder.Append(column.Trim()).Append(',');
            }

            _columns = stringBuilder.ToString().Remove(stringBuilder.Length - 1);

            return this;
        }

        public IQueryBuilder Where(string key, string value)
        {
            _key = key;
            _value = value;

            return this;
        }

        public IQueryBuilder Limit(int limit)
        {
            _limit = limit;

            return this;
        }

        public void Build()
        {
            StringBuilder query = new StringBuilder();

            query.Append("SELECT").Append(' ');

            if (!string.IsNullOrEmpty(_columns))
            {
                query.Append(_columns).Append(' ');
            }

            query.Append("FROM").Append(' ').Append(_tableName).Append(' ');

            if (!string.IsNullOrEmpty(_key) && !string.IsNullOrEmpty(_value))
            {
                query.Append($"WHERE {_key} = {_value}").Append(' ');
            }

            if (_limit > 0)
            {
                query.Append($"LIMIT {_limit}");
            }

            Console.WriteLine(query.ToString());
        }
    }
}