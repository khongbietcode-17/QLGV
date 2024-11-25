using QLGV.Models;
using QLGV.Repositories;
using QLGV.Repositories.SqlServer;

namespace QLGV.Services
{
    public class LuongCoSoService
    {
        private readonly ILuongCoSoRepository _repository;
        public LuongCoSoService() 
        {
            _repository = new LuongCoSoRepository();
        }

        public int GetLuongCoSo() 
        {
            LuongCoSoModel model = _repository.FindById(1);
            int luongCoSo = model.LuongCoSo;
            return luongCoSo;
        }
    }
}
