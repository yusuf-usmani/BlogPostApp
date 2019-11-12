using BOL;
using DAL;
using System.Collections.Generic;

namespace BLL
{
    class BlogBS
    {
        private BlogsDb blogDb;

        public BlogBS()
        {
            blogDb = new BlogsDb();
        }

        public IEnumerable<Blog> GetALL()
        {
            return blogDb.GetALL();
        }
        public Blog GetByID(int Id)
        {
            return blogDb.GetByID(Id);
        }
        public void Insert(Blog blog)
        {
            blogDb.Insert(blog);
        }
        public void Delete(int Id)
        {
            blogDb.Delete(Id);
        }
        public void Update(Blog blog)
        {
            blogDb.Update(blog);
        }
    }
}
