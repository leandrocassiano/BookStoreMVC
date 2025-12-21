using BookStore.Context;
using BookStore.Domain;
using BookStore.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private BookStoreDataContext _db = new BookStoreDataContext();
        public bool Create(Author author)
        {
            try
            {
                _db.Authors.Add(author);
                _db.SaveChanges();
                return true;
            }
            catch
            {
               return false;
            }
        }

        public void Delete(int id)
        {
                var author = _db.Authors.Find(id);
                _db.Authors.Remove(author);
                _db.SaveChanges();             
        }
        public List<Author> Get()
        {
            return _db.Authors.ToList();
        }

        public Author Get(int id)
        {
            return _db.Authors.Find(id);
        }

        public List<Author> GetByName(string name)
        {
           return _db.Authors.Where(a => a.Title.Contains(name)).ToList();
        }

        public bool Update(Author author)
        {
            try
            {
                _db.Entry<Author>(author).State = System.Data.Entity.EntityState.Modified;
                _db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}