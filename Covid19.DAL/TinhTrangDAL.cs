using Microsoft.EntityFrameworkCore;

namespace Covid19.DAL
{
    public class TinhTrangDAL
    {
        public List<TinhTrang> GetAll()
        {
            using var db = new Covid19Context();
            return db.TinhTrangs.AsNoTracking().OrderBy(t => t.MaTT).ToList();
        }
    }
}