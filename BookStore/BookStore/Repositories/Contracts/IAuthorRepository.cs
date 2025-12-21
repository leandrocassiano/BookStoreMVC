using BookStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Repositories.Contracts
{
    public interface IAuthorRepository : IDisposable
    {
        List<Author> Get();
        Author Get(int id);
        List<Author> GetByName(string name);
        bool Create(Author author);
        bool Update(Author author);
        void Delete(int id);
    }
}