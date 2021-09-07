using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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

        [HttpPost]
        public async Task<IActionResult> AddBlog([FromBody] Blog blog)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _unitOfWork.Blog.Add(blog);
                    await _unitOfWork.CompleteAsync();
                    return Ok("Add Successfully");
                }
                catch (Exception ex)
                {
                    return new StatusCodeResult(StatusCodes.Status500InternalServerError);
                }
            }
            return BadRequest("Something went wrong!!!");
        }

        [HttpPut]
        public async Task<IActionResult> EditBlog([FromBody] Blog blog)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _unitOfWork.Blog.Update(blog);
                    await _unitOfWork.CompleteAsync();
                    return Ok("Edited successfully");
                }
                catch (Exception ex)
                {
                    return new StatusCodeResult(StatusCodes.Status500InternalServerError);
                }
            }
            return BadRequest("Something Went wrong!!!");
        }
    }
}
