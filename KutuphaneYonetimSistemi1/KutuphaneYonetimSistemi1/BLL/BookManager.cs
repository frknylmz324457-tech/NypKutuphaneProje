using System.Data;
using KutuphaneYonetimSistemi1.DAL;
using KutuphaneYonetimSistemi1.Entities;

namespace KutuphaneYonetimSistemi1.BLL
{
    public class BookManager
    {
        private BookDal _bookDal = new BookDal();

        public void AddBook(Book b)
        {
           
            if (b.Stock < 0)
                throw new System.Exception("Stok 0'dan küçük olamaz!");

            if (string.IsNullOrWhiteSpace(b.Title))
                throw new System.Exception("Kitap adı boş olamaz!");

          
            _bookDal.Add(b);
        }

        public void UpdateBook(Book b)
        {
            if (b.Id <= 0)
                throw new System.Exception("Geçersiz kitap ID!");

            _bookDal.Update(b);
        }

        public void DeleteBook(int id)
        {
            if (id <= 0)
                throw new System.Exception("Geçersiz kitap ID!");

            _bookDal.Delete(id);
        }

        public DataTable GetAllBooks()
        {
            return _bookDal.GetAll();
        }

        public DataTable GetBooksForBorrowing()
        {
            return _bookDal.GetBooksForBorrowing();
        }

        public DataTable SearchBooksForBorrowing(string keyword)
        {
            return _bookDal.SearchBooksForBorrowing(keyword);
        }


    }
}
