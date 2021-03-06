using System.Collections.Generic;
using BookApiProject.Models;

namespace BookApiProject.Services
{
    public interface IAuthorRepository 
    {
        bool AuthorExists(int authorId);
        Author GetAuthor(int authorId);
        ICollection<Author> GetAuthors();
        ICollection<Author> GetAuthorsOfABook(int bookId);
        ICollection<Book> GetBooksByAuthor(int authorId);
        bool CreateAuthor(Author author);
        bool UpdateAuthor(Author author);
        bool DeleteAuthor(Author author);
        bool Save();
    }
}