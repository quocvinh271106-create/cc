using Covid19.DAL;

namespace Covid19.BLL
{
    public class TinhTrangBLL
    {
        private readonly TinhTrangDAL dal = new TinhTrangDAL();

        public List<TinhTrang> GetAll() => dal.GetAll();
    }
}