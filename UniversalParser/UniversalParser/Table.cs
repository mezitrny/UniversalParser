using System.Collections.Generic;

namespace UniversalParser
{
    public abstract class Table
    {
        protected Table(string header, string data)
        {
            
        }

        protected Table(Dictionary<string, string> data)
        {

        }

        protected void Process(Dictionary<string, string> data)
        {
            Validate(data);
            Analyze(data);
        }

        protected abstract Dictionary<string, string> Parse(string data);
        protected abstract void Analyze(Dictionary<string, string> data);
        protected abstract void Validate(Dictionary<string, string> data);
    }
}