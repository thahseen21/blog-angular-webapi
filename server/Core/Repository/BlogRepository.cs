using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using server.Core.IRepository;
using server.Data;
using server.Models;

namespace server.Core.Repository
{
    public class BlogRepository : GenericRepository<Blog>, IBlogRepository
    {

        public BlogRepository(ApplicationDbContext dbContext, IMapper mapper) :
            base(dbContext, mapper)
        {
        }

        public override async Task<Blog> Update(Blog entity)
        {
            try
            {
                Blog existingBlog = await dbSet.Where(blog => blog.Id == entity.Id).FirstOrDefaultAsync();

                if (existingBlog == null)
                {
                    return entity;
                }

                // existingBlog = _mapper.Map<Blog>(entity);
                existingBlog.Title = entity.Title;
                existingBlog.Content = entity.Content;
                return existingBlog;

            }
            catch (Exception ex)
            {
                // TODO
            }
            return entity;
        }
    }
}
