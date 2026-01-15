using System;
using System.Data;
using KutuphaneYonetimSistemi1.DAL;
using KutuphaneYonetimSistemi1.Entities;

namespace KutuphaneYonetimSistemi1.BLL
{
    public class BookManager
    {
        DbHelper db = new DbHelper();
        public void AddBook(Book b)
        {
            string query = $"INSERT INTO books (isbn, title, author, publisher, page_count, year, stock, is_available) " +
                           $"VALUES ('{b.ISBN}', '{b.Title}', '{b.Author}', '{b.Publisher}', {b.PageCount}, {b.Year}, {b.Stock}, 1)";

            db.ExecuteQuery(query);
        }
        public DataTable GetAllBooks()
        {
            return db.GetDataTable("SELECT * FROM books");
        }
        public void UpdateBook(Book b)
        {
            string query = $"UPDATE books SET " +
                           $"isbn='{b.ISBN}', " +
                           $"title='{b.Title}', " +
                           $"author='{b.Author}', " +
                           $"publisher='{b.Publisher}', " +
                           $"page_count={b.PageCount}, " +
                           $"year={b.Year}, " +
                           $"stock={b.Stock} " +
                           $"WHERE id={b.Id}";

            db.ExecuteQuery(query);
        }

        public void DeleteBook(int id)
        {
            string query = $"DELETE FROM books WHERE id={id}";
            db.ExecuteQuery(query);
        }
        public DataTable GetBooksForBorrowing()
        {
            string query = @"
        SELECT 
            id, 
            isbn, 
            title, 
            author, 
            publisher, 
            year, 
            page_count, 
            stock 
        FROM books 
        WHERE stock > 0 AND is_available = 1";

            return db.GetDataTable(query);
        }
    }
}