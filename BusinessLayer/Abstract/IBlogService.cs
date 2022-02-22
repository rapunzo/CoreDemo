using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    internal interface IBlogService
    {
        void BlogAdd(Blog Blog);
        void BlogRemove(Blog Blog);
        void BlogUpdate(Blog Blog);
        List<Blog> GetAllBlogs();
        Blog GetBlog(int id);
        List<Blog> GetBlogListWithCategory();
    }
}
