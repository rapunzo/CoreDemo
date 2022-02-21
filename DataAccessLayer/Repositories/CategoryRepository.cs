using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        Context c = new Context();

        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void AddCategory(Category category)
        {
            c.Add(category);
            c.SaveChanges();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(Category category)
        {
            c.Remove(category);
            c.SaveChanges();
        }

        public Category Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetCategory(int id)
        {
            return c.Categories.Find(id);
        }

        public List<Category> ListAllCategories()
        {
            return c.Categories.ToList();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }

        public void UpdateCategory(Category category)
        {
            c.Update(category);
            c.SaveChanges();

        }
    }
}
