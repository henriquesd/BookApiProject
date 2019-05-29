using System.Collections.Generic;
using BookApiProject.Models;

namespace BookApiProject.Services
{
    public interface IBookRepository
    {
         ICollection<Book> GetBooks();
         Book GetBook(int bookId);
         Book GetBook(string bookIsbn);
         decimal GetBookRating(int bookId);
         bool BookExists(int bookId);
         bool bookExists(string bookIsbn);
         bool IsDuplicateIsbn(int bookId, string bookIsbn);
    }
}