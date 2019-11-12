using BOL;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DAL
{
    public class BlogsDb
    {
        private BlogPostEntities db;

        public BlogsDb()
        {
            db = new BlogPostEntities();
        }

        public IEnumerable<Blog> GetALL()
        {
            return db.Blogs.ToList();
        }
        public Blog GetByID(int Id)
        {
            return db.Blogs.Find(Id);
        }
        public void Insert(Blog blog)
        {
            db.Blogs.Add(blog);
            Save();
        }
        public void Delete(int Id)
        {
            Blog url = db.Blogs.Find(Id);
            db.Blogs.Remove(url);
            Save();
        }
        public void Update(Blog blog)
        {
            db.Entry(blog).State = EntityState.Modified;
            db.Configuration.ValidateOnSaveEnabled = false;
            Save();
            db.Configuration.ValidateOnSaveEnabled = true;
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
