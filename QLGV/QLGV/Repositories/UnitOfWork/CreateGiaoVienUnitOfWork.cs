using QLGV.Models;
using QLGV.Repositories.SqlServer;
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

        public CreateGiaoVienUnitOfWork()
        {
            _bangLuongRepository = new BangLuongRepository();
            _giaoVienRepository = new GiaoVienRepository();
            _phanCongRepository = new PhanCongRepository();
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

            _bangLuongRepository.AddEmpty(id);
            return model;
        }

    }
}
