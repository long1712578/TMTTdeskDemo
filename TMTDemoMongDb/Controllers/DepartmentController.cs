using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using TMTDemoMongDb.Models;

namespace TMTDemoMongDb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public DepartmentController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpGet]
        public JsonResult Get()
        {
            MongoClient dbClient = new MongoClient(_configuration.GetConnectionString("TdeskAppConn"));
            var listDepartment = dbClient.GetDatabase("DemoTdeskDb").GetCollection<Department>("Department").AsQueryable();
            return new JsonResult(listDepartment);
        }
    }
}
