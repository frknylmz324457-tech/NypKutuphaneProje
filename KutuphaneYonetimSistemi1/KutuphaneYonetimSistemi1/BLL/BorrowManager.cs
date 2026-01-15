using System;
using System.Data;
using KutuphaneYonetimSistemi1.DAL;
using KutuphaneYonetimSistemi1.Entities;

namespace KutuphaneYonetimSistemi1.BLL
{
    public class BorrowManager
    {
        DbHelper db = new DbHelper();

        public DataTable GetAllBorrows()
        {
            string query = "SELECT br.id, " +
                           "CONCAT(m.first_name, ' ', m.last_name) as Uye, " + 
                           "b.title as Kitap, " +
                           "br.borrow_date, br.return_date, br.is_returned, " +
                           "br.book_id " +
                           "FROM borrows br " +
                           "JOIN members m ON br.member_id = m.id " +
                           "JOIN books b ON br.book_id = b.id " +
                           "ORDER BY br.borrow_date DESC";

            return db.GetDataTable(query);
        }

        public void LendBook(Borrow br)
        {   
            string tarih = br.BorrowDate.ToString("yyyy-MM-dd HH:mm:ss");
            string query = $"INSERT INTO borrows (member_id, book_id, borrow_date, is_returned) " +
                           $"VALUES ({br.MemberId}, {br.BookId}, '{tarih}', 0)";
            db.ExecuteQuery(query);

            string stockQuery = $"UPDATE books SET stock = stock - 1 WHERE id={br.BookId}";
            db.ExecuteQuery(stockQuery);
        }

        public void ReceiveBook(int borrowId, int bookId)
        {
            string bugun = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string query = $"UPDATE borrows SET is_returned=1, return_date='{bugun}' WHERE id={borrowId}";
            db.ExecuteQuery(query);
            string stockQuery = $"UPDATE books SET stock = stock + 1 WHERE id={bookId}";
            db.ExecuteQuery(stockQuery);
        }

        public DataTable GetDetailedReport()
        {
            string query = @"
        SELECT 
            CONCAT(m.first_name, ' ', m.last_name) AS 'Üye Adı', 
            b.title AS 'Kitap Adı', 
            br.borrow_date AS 'Alış Tarihi', 
            br.return_date AS 'İade Tarihi' 
        FROM borrows br 
        JOIN members m ON br.member_id = m.id 
        JOIN books b ON br.book_id = b.id";

            return db.GetDataTable(query);
        }
        public bool BorrowBook(int memberID, int bookId)
        {
            try
            {
                string borrowQuery = $"INSERT INTO borrows (member_id, book_id, borrow_date, is_returned) VALUES ({memberID}, {bookId}, '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}', 0)";
                db.ExecuteQuery(borrowQuery);

                string stockQuery = $"UPDATE books SET stock = stock - 1 WHERE id = {bookId}";
                db.ExecuteQuery(stockQuery);

                return true;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
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
    }
}