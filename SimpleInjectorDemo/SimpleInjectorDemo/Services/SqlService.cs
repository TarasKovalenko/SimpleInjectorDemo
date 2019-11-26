using System.Collections.Generic;
using System.Linq;
using SimpleInjectorDemo.Interfaces;
using SimpleInjectorDemo.Models;

namespace SimpleInjectorDemo.Services
{
    public class SqlService : ISqlService
    {
        private readonly ISqlDLPService _sqlDlpService;
        private readonly ISqlWorkspaceService _sqlWorkspaceService;

        public SqlService(ISqlDLPService sqlDlpService, ISqlWorkspaceService sqlWorkspaceService)
        {
            _sqlDlpService = sqlDlpService;
            _sqlWorkspaceService = sqlWorkspaceService;
        }

        public IEnumerable<int> Get(SqlQueryModel query)
        {
            IEnumerable<int> dataFromDlp = new List<int>();
            if (query.DlpQuery != null)
            {
                dataFromDlp = _sqlDlpService.Get(query.DlpQuery.Id);
            }

            IEnumerable<int> dataFromWorkspace = new List<int>();
            if (query.WorkspaceQuery != null)
            {
                dataFromDlp = _sqlWorkspaceService.Get(query.WorkspaceQuery.Id);
            }

            return _sqlDlpService.Get(query.Id).Concat(dataFromDlp).Concat(dataFromWorkspace);
        }
    }
}
