using System.Collections.Generic;

namespace SimpleInjectorDemo.Interfaces
{
    public interface ISqlDLPService
    {
        IEnumerable<int> Get(int index);
    }
}
