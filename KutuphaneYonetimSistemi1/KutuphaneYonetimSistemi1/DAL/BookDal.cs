using System.Data;
using KutuphaneYonetimSistemi1.Entities;

namespace KutuphaneYonetimSistemi1.DAL
{
    public class BookDal
    {
        private DbHelper db = new DbHelper();

        public void Add(Book b)
        {
            string query = $@"
                INSERT INTO books (isbn, title, author, publisher, page_count, year, stock, is_available)
                VALUES ('{b.ISBN}', '{b.Title}', '{b.Author}', '{b.Publisher}', {b.PageCount}, {b.Year}, {b.Stock}, 1)
            ";

            db.ExecuteQuery(query);
        }

        public void Update(Book b)
        {
            string query = $@"
                UPDATE books SET
                    isbn = '{b.ISBN}',
                    title = '{b.Title}',
                    author = '{b.Author}',
                    publisher = '{b.Publisher}',
                    page_count = {b.PageCount},
                    year = {b.Year},
                    stock = {b.Stock}
                WHERE id = {b.Id}
            ";

            db.ExecuteQuery(query);
        }

        public void Delete(int id)
        {
            string query = $"DELETE FROM books WHERE id = {id}";
            db.ExecuteQuery(query);
        }

        public DataTable GetAll()
        {
            string query = "SELECT * FROM books";
            return db.GetDataTable(query);
        }

        public DataTable GetBooksForBorrowing()
        {
            string query = @"
                SELECT 
                    id, isbn, title, author, publisher, year, page_count, stock 
                FROM books 
                WHERE stock > 0 AND is_available = 1
            ";

            return db.GetDataTable(query);
        }
        public DataTable SearchBooksForBorrowing(string keyword)
        {
            string query = $@"
SELECT id, title, author, stock 
FROM books 
WHERE stock > 0 AND title LIKE '%{keyword}%'";

            return db.GetDataTable(query); 
        }


    }
}
