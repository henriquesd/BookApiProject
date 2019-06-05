using System.Collections.Generic;
using BookApiProject.Models;

namespace BookApiProject.Services
{
    public interface IBookRepository
    {
        bool BookExists(int bookId);
        bool BookExists(string Isbn);
        Book GetBook(int bookId);
        Book GetBook(string Isbn);
        decimal GetBookRating(int bookId);
        ICollection<Book> GetBooks();
        bool IsDuplicateIsbn(int bookId, string bookIsbn);
        bool CreateBook(List<int> authorsId, List<int> categoriesId, Book book);
        bool UpdateBook(List<int> authorsId, List<int> categoriesId, Book book);
        bool DeleteBook(Book book);
        bool Save();
    }
}