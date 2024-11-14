using QLGV.Models;
using QLGV.Repositories;
using QLGV.Repositories.Creterias;
using QLGV.Repositories.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Services
{
    public class BoMonService
    {
        private readonly IBoMonRepository _repository;

        public BoMonService()
        {
            _repository = new BoMonRepository();
        }

        public IEnumerable<BoMonModel> GetAll()
        {
            return _repository.Find(BaseFindCreterias.Empty());
        }

    }
}
