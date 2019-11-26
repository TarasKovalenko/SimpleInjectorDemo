using System.Collections.Generic;
using SimpleInjectorDemo.Models;

namespace SimpleInjectorDemo.Interfaces
{
    public interface ISqlService
    {
        IEnumerable<int> Get(SqlQueryModel query);
    }
}
