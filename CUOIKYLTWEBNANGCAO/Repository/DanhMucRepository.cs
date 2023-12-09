using CUOIKYLTWEBNANGCAO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CUOIKYLTWEBNANGCAO.Repository
{
    public class DanhMucRepository : IDanhMucRepository
    {
        private readonly dbQUANLYBANHANGContext _context;

        public DanhMucRepository(dbQUANLYBANHANGContext context)
        {
            this._context = context;
        }

        public TbDanhmuc Add(TbDanhmuc loaidm)
        {
            _context.TbDanhmucs.Add(loaidm);
            _context.SaveChanges();
            return loaidm;
        }

        public TbDanhmuc Delete(TbDanhmuc loaidm)
        {
            _context.TbDanhmucs.Remove(loaidm);
            _context.SaveChanges();
            return loaidm;
        }

        public IEnumerable<TbDanhmuc> GetAllDanhmuc()
        {
            return _context.TbDanhmucs;
        }

        public TbDanhmuc GetDanhMuc(TbDanhmuc loaidm)
        {
            return _context.TbDanhmucs.Find(loaidm);
        }

        public TbDanhmuc Update(TbDanhmuc loaidm)
        {
            _context.Update(loaidm);
            _context.SaveChanges();
            return loaidm;
        }
    }
}
