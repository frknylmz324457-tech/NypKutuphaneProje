using KutuphaneYonetimSistemi1.DAL;

namespace KutuphaneYonetimSistemi1.BLL
{
    public class ReportManager
    {
        private ReportDal _reportDal = new ReportDal();

        public int GetTotalBookCount()
        {
            return _reportDal.GetTotalBookCount();
        }

        public int GetPendingReturnCount()
        {
            return _reportDal.GetPendingReturnCount();
        }

        public int GetTotalMemberCount()
        {
            return _reportDal.GetTotalMemberCount();
        }
    }
}
