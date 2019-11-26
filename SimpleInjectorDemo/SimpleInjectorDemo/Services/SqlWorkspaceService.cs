using System.Collections.Generic;
using System.Linq;
using SimpleInjectorDemo.Interfaces;

namespace SimpleInjectorDemo.Services
{
    public class SqlWorkspaceService : ISqlWorkspaceService
    {
        public IEnumerable<int> Get(int index)
        {
            return Enumerable.Range(1, index);
        }
    }
}
