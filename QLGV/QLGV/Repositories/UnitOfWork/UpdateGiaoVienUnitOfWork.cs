using QLGV.Models;
using QLGV.Repositories.SqlServer;
using QLGV.Repositories.Creterias;
using System.Collections.Generic;
using System.Linq;

namespace QLGV.Repositories.UnitOfWork
{
    public class UpdateGiaoVienUnitOfWork
    {
        private readonly IGiaoVienRepository _giaoVienRepository;
        private readonly IPhanCongRepository _phanCongRepository;

        public UpdateGiaoVienUnitOfWork()
        {
            _giaoVienRepository = new GiaoVienRepository();
            _phanCongRepository = new PhanCongRepository();
        }

        public bool Update(GiaoVienModel model)
        {
            GiaoVienModel modelInDB = _giaoVienRepository.FindById(model.GiaoVienId);
            _giaoVienRepository.IncludeChucVu(modelInDB);
            List<ChucVuModel> chucVuInDB = modelInDB.ChucVu;
            List<ChucVuModel> chucVuInModel = model.ChucVu;

            //New PhanCong
            List<ChucVuModel> listDiffNew = new List<ChucVuModel>();
            if (chucVuInDB != null)
            {
                listDiffNew = chucVuInModel.Except(chucVuInDB).ToList();
            } else
            {
                listDiffNew = chucVuInModel;
            }
            if (listDiffNew.Count > 0)
            {
                foreach (ChucVuModel chucVu in listDiffNew)
                {
                    _phanCongRepository.Add(new PhanCongModel()
                    {
                        GiaoVienId = model.GiaoVienId,
                        ChucVuId = chucVu.ChucVuId,
                    });
                }
            }
            //Delete
            if (chucVuInDB != null)
            {
                List<ChucVuModel> listDiffDelete = chucVuInDB.Except(chucVuInModel).ToList();

                if (listDiffDelete.Count > 0)
                {
                    foreach(var chucVu in listDiffDelete)
                    {
                    _phanCongRepository.Delete(new BaseFindCreterias()
                    {
                        Column = new List<(string, string)>()
                        {
                            ("GiaoVienId", model.GiaoVienId.ToString()),
                            ("ChucVuId", chucVu.ChucVuId.ToString())
                        }
                    });
                    }
                }
            }
            return true;
        }
    }
}
