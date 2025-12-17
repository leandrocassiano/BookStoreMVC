using System.Collections.Generic;

namespace BookStore.Domain
{
    public class Author
    {
        public Author() 
        {
            Books = new List<Book>();
        }
             
        public int Id { get; set; }
                
        public string Title { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}