using BookServiceWEBAPI.Entities;

namespace BookServiceWEBAPI.Service
{
    public interface IBookService
    {
        void AddBook(Book book);
        List<Book> GetAllBooks();      
        List<Book> GetBookById(int Id);
        void EditBook(Book book);
        void DeleteBook(int bookId);
       
    }
}
