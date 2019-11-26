using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SimpleInjectorDemo.Interfaces;
using SimpleInjectorDemo.Models;

namespace SimpleInjectorDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SimpleInjectorController : ControllerBase
    {
        private readonly ISqlService _sqlService;

        public SimpleInjectorController(ISqlService sqlService)
        {
            _sqlService = sqlService;
        }


        [HttpGet]
        public IEnumerable<int> Get()
        {
            return _sqlService.Get(new SqlQueryModel
            {
                Id = 1002,
                Repo = "Test",
                DlpQuery = new DlpQuery
                {
                    Id = 5
                },
                WorkspaceQuery = new WorkspaceQuery
                {
                    Id = 10
                }
            });
        }

        [HttpGet("validation")]
        public IEnumerable<int> GetWithInvalidData()
        {
            return _sqlService.Get(new SqlQueryModel
            {
                Id = 10,
                Repo = "",
                DlpQuery = new DlpQuery
                {
                    Id = 5
                },
                WorkspaceQuery = new WorkspaceQuery
                {
                    Id = 10
                }
            });
        }
    }
}
