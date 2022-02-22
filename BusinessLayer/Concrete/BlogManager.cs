using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{

    public class BlogManager : IBlogService
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void BlogAdd(Blog Blog)
        {
            throw new NotImplementedException();
        }

        public void BlogRemove(Blog Blog)
        {
            throw new NotImplementedException();
        }

        public void BlogUpdate(Blog Blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetAllBlogs()
        {
            return _blogDal.GetAll();
        }

        public Blog GetBlog(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }
    }
}
