using System.Data;
using KutuphaneYonetimSistemi1.DAL;
using KutuphaneYonetimSistemi1.Entities;

namespace KutuphaneYonetimSistemi1.BLL
{
    public class MemberManager
    {
        private MemberDal _memberDal = new MemberDal();

        public void AddMember(Member m)
        {
            if (string.IsNullOrWhiteSpace(m.FirstName))
                throw new System.Exception("Üye adı boş olamaz!");

            if (string.IsNullOrWhiteSpace(m.LastName))
                throw new System.Exception("Üye soyadı boş olamaz!");

            _memberDal.Add(m);
        }

        public void UpdateMember(Member m)
        {
            if (m.Id <= 0)
                throw new System.Exception("Geçersiz üye ID!");

            _memberDal.Update(m);
        }

        public void DeleteMember(int id)
        {
            if (id <= 0)
                throw new System.Exception("Geçersiz üye ID!");

            _memberDal.Delete(id);
        }

        public DataTable GetAllMembers()
        {
            return _memberDal.GetAll();
        }
    }
}
