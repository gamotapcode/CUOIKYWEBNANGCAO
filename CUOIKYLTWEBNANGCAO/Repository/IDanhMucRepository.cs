using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CUOIKYLTWEBNANGCAO.Models;

namespace CUOIKYLTWEBNANGCAO.Repository
{
    public interface IDanhMucRepository
    {
        TbDanhmuc Add(TbDanhmuc loaidm);
        TbDanhmuc Update(TbDanhmuc loaidm);
        TbDanhmuc Delete(TbDanhmuc loaidm);
        IEnumerable<TbDanhmuc> GetAllDanhmuc();
        TbDanhmuc GetDanhMuc(TbDanhmuc loaidm);
    }
}
