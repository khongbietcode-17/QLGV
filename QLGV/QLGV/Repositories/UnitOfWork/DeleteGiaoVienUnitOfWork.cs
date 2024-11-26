using QLGV.Repositories.SqlServer;


namespace QLGV.Repositories.UnitOfWork
{
    public class DeleteGiaoVienUnitOfWork
    {
        private readonly IBangLuongRepository _bangLuongRepository;
        private readonly IPhanCongRepository _phanCongRepository;
        private readonly IGiaoVienRepository _giaoVienRepository;
        private readonly IChuNhiemRepository _chuNhiemRepository;
        public DeleteGiaoVienUnitOfWork() 
        {
            _bangLuongRepository = new BangLuongRepository();
            _phanCongRepository = new PhanCongRepository();
            _giaoVienRepository = new GiaoVienRepository();
            _chuNhiemRepository = new ChuNhiemRepository();
        }


        public int Delete(int[] ids)
        {
            _chuNhiemRepository.Delete(ids, "GiaoVienId");
            _bangLuongRepository.Delete(ids);
            _phanCongRepository.Delete(ids);
            return _giaoVienRepository.Delete(ids);
        }
    }
}
