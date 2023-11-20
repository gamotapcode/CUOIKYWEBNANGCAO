using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CUOIKYLTWEBNANGCAO.Repository;

namespace CUOIKYLTWEBNANGCAO.ViewComponents
{
    public class DanhMucViewComponent: ViewComponent
    {
        private readonly IDanhMucRepository _danhmuc;

        public DanhMucViewComponent(IDanhMucRepository danhMucRepository)
        {
            _danhmuc = danhMucRepository;
        }
        public IViewComponentResult Invoke()
        {
            var danhmuc = _danhmuc.GetAllDanhmuc().OrderBy(x => x.Tendanhmuc);
            return View(danhmuc);
        }
    }
}
