using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using server.Core.IConfiguration;
using server.Models;

namespace server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public BlogController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IEnumerable<Blog>> GetBlogs()
        {
            var result = await _unitOfWork.Blog.All();
            return (result);
        }
    }
}
