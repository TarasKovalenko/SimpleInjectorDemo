using System.Collections.Generic;

namespace SimpleInjectorDemo.Interfaces
{
    public interface ISqlWorkspaceService
    {
        IEnumerable<int> Get(int index);
    }
}
