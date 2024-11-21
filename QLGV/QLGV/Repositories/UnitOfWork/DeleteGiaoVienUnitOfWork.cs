using QLGV.Repositories.SqlServer;


namespace QLGV.Repositories.UnitOfWork
{
    public class DeleteGiaoVienUnitOfWork
    {
        private readonly IBangLuongRepository _bangLuongRepository;
        private readonly IPhanCongRepository _phanCongRepository;
        private readonly IGiaoVienRepository _giaoVienRepository;
        public DeleteGiaoVienUnitOfWork() 
        {
            _bangLuongRepository = new BangLuongRepository();
            _phanCongRepository = new PhanCongRepository();
            _giaoVienRepository = new GiaoVienRepository();
        }

        public int Delete(int[] ids)
        {
            _bangLuongRepository.Delete(ids);
            _phanCongRepository.Delete(ids);
            return _giaoVienRepository.Delete(ids);
        }
    }
}
