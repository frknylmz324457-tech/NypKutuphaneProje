using System;
using System.Data;
using KutuphaneYonetimSistemi1.DAL;
using KutuphaneYonetimSistemi1.Entities;

namespace KutuphaneYonetimSistemi1.BLL
{
    public class BorrowManager
    {
        private BorrowDal _borrowDal = new BorrowDal();
        private BookDal _bookDal = new BookDal(); 

        public DataTable GetAllBorrows()
        {
            return _borrowDal.GetAll();
        }

        public void LendBook(Borrow br)
        {
           
            if (br.MemberId <= 0)
                throw new Exception("Geçersiz üye!");

            if (br.BookId <= 0)
                throw new Exception("Geçersiz kitap!");


            br.BorrowDate = DateTime.Now;

           
            _borrowDal.Add(br);
            _borrowDal.DecreaseBookStock(br.BookId);
        }

        public void ReceiveBook(int borrowId, int bookId)
        {
            if (borrowId <= 0)
                throw new Exception("Geçersiz ödünç ID!");

            if (bookId <= 0)
                throw new Exception("Geçersiz kitap ID!");

            _borrowDal.MarkAsReturned(borrowId, DateTime.Now);
            _borrowDal.IncreaseBookStock(bookId);
        }

        public DataTable GetActiveBorrows()
        {
            return _borrowDal.GetActiveBorrows();
        }

        public DataTable GetMemberBorrows(int memberId)
        {
            if (memberId <= 0)
                throw new Exception("Geçersiz üye ID!");

            return _borrowDal.GetMemberBorrows(memberId);
        }
        public DataTable GetPendingReturns()
        {
            return _borrowDal.GetPendingReturns();
        }


    }
}
