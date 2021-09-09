using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using server.Core.IConfiguration;
using server.DTO;
using server.Models;

namespace server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CommentController(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        [HttpPost]
        public async Task<IActionResult> GetComment([FromBody] GetComment entity)
        {
            if (entity.Id != null)
            {
                var result = await _unitOfWork.Comment.GetAllById((int)entity.Id);
                return Ok(result);
            }
            return BadRequest("Something went wrong!!!");
        }

        [HttpPost("addcomment")]
        public async Task<IActionResult> AddComment([FromBody] Comment entity)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _unitOfWork.Comment.Add(entity);
                    await _unitOfWork.CompleteAsync();
                    return Ok(entity);
                }
                catch (Exception ex)
                {
                    return new StatusCodeResult(StatusCodes.Status500InternalServerError);
                }
            }
            return BadRequest("Something went wrong!!!");
        }
    }
}