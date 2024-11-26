using QLGV.Models;
using QLGV.Repositories.SqlServer;
using QLGV.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Repositories.UnitOfWork
{
    public class CreateGiaoVienUnitOfWork
    {
        private readonly IBangLuongRepository _bangLuongRepository;
        private readonly IGiaoVienRepository _giaoVienRepository;
        private readonly IPhanCongRepository _phanCongRepository;
        private readonly BangLuongService _luongService;

        public CreateGiaoVienUnitOfWork()
        {
            _bangLuongRepository = new BangLuongRepository();
            _giaoVienRepository = new GiaoVienRepository();
            _phanCongRepository = new PhanCongRepository();
            _luongService = new BangLuongService();
        }

        public GiaoVienModel Create(GiaoVienModel model)
        {
            var id = _giaoVienRepository.Add(model);

            List<ChucVuModel> phanCong = model.ChucVu;

            foreach(var chucVu in phanCong)
            {
                PhanCongModel phanCongModel = new PhanCongModel()
                {
                    GiaoVienId = id,
                    ChucVuId = chucVu.ChucVuId
                };
                _phanCongRepository.Add(phanCongModel);
            };
            _luongService.AddOne(new BangLuongModel()
            {
                GiaoVienId = id,
                HeSoLuong = model.BangLuong.HeSoLuong,
                HeSoPhuCap = model.BangLuong.HeSoPhuCap
            });
           
            return model;
        }

    }
}
