using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IServices;
using Model;
using Services;

namespace AppCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SysSampleController : ControllerBase
    {

        /// <summary>
        ///  获取列表
        /// </summary>
        /// <param name="id">根据id获取</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<List<SysSample>> Get(string id)
        {
            ISysSampleServices sysSampleServices = new SysSampleServices();
            return await sysSampleServices.Query(d => d.id == id);
        }
    }
}