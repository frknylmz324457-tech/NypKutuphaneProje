using System;
using System.Data;
using KutuphaneYonetimSistemi1.Entities;

namespace KutuphaneYonetimSistemi1.DAL
{
    public class BorrowDal
    {
        private DbHelper db = new DbHelper();

        public DataTable GetAll()
        {
            string query = @"
                SELECT br.id, 
                       CONCAT(m.first_name, ' ', m.last_name) as Uye, 
                       b.title as Kitap, 
                       br.borrow_date, br.return_date, br.is_returned, 
                       br.book_id
                FROM borrows br
                JOIN members m ON br.member_id = m.id
                JOIN books b ON br.book_id = b.id
                ORDER BY br.borrow_date DESC";

            return db.GetDataTable(query);
        }

        public void Add(Borrow br)
        {
            string tarih = br.BorrowDate.ToString("yyyy-MM-dd HH:mm:ss");

            string query = $@"
                INSERT INTO borrows (member_id, book_id, borrow_date, is_returned)
                VALUES ({br.MemberId}, {br.BookId}, '{tarih}', 0)
            ";

            db.ExecuteQuery(query);
        }

        public void MarkAsReturned(int borrowId, DateTime returnDate)
        {
            string tarih = returnDate.ToString("yyyy-MM-dd HH:mm:ss");

            string query = $@"
                UPDATE borrows 
                SET is_returned = 1, return_date = '{tarih}' 
                WHERE id = {borrowId}
            ";

            db.ExecuteQuery(query);
        }

        public void DecreaseBookStock(int bookId)
        {
            string query = $"UPDATE books SET stock = stock - 1 WHERE id = {bookId}";
            db.ExecuteQuery(query);
        }

        public void IncreaseBookStock(int bookId)
        {
            string query = $"UPDATE books SET stock = stock + 1 WHERE id = {bookId}";
            db.ExecuteQuery(query);
        }

        public DataTable GetActiveBorrows()
        {
            string query = @"
                SELECT 
                    br.id, 
                    br.book_id,
                    CONCAT(m.first_name, ' ', m.last_name) AS 'Üye', 
                    b.title AS 'Kitap', 
                    br.borrow_date AS 'Tarih',
                    br.is_returned
                FROM borrows br 
                JOIN members m ON br.member_id = m.id 
                JOIN books b ON br.book_id = b.id
                WHERE br.is_returned = 0";

            return db.GetDataTable(query);
        }

        public DataTable GetMemberBorrows(int memberId)
        {
            string query = $@"
                SELECT 
                    br.id,
                    br.book_id,
                    b.title AS 'Kitap',
                    br.borrow_date AS 'Alış Tarihi',
                    br.is_returned
                FROM borrows br
                JOIN books b ON br.book_id = b.id
                WHERE br.is_returned = 0 AND br.member_id = {memberId}";

            return db.GetDataTable(query);
        }
        public DataTable GetPendingReturns()
        {
            string query = @"
        SELECT 
            br.id,
            br.book_id,
            CONCAT(m.first_name, ' ', m.last_name) AS Uye,
            b.title AS Kitap,
            br.borrow_date AS AlisTarihi
        FROM borrows br
        JOIN members m ON br.member_id = m.id
        JOIN books b ON br.book_id = b.id
        WHERE br.is_returned = 0
        ORDER BY br.borrow_date ASC
    ";

            return db.GetDataTable(query);
        }




    }
}
