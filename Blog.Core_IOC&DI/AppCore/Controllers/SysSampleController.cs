using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IServices;
using Model;

namespace AppCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SysSampleController : ControllerBase
    {
        private readonly ISysSampleServices _sysSampleServices ;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="sysSampleServices">实例化</param>
        public SysSampleController(ISysSampleServices sysSampleServices)
        {
            this._sysSampleServices = sysSampleServices;
        }

        /// <summary>
        ///  获取列表
        /// </summary>
        /// <param name="id">根据id获取</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<List<SysSample>> Get(string id)
        {
            return await this._sysSampleServices.Query(d => d.id == id);
        }
    }
}