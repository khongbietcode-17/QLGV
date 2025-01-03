﻿using QLGV.Models;
using QLGV.Repositories.Creterias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Repositories
{
    public interface IBangLuongRepository
    {
        IEnumerable<BangLuongModel> Find(BaseFindCreterias creterias);
        IEnumerable<BangLuongModel> IncludeGiaoVien(IEnumerable<BangLuongModel>  bangLuongs);
        BangLuongModel IncludeGiaoVien(BangLuongModel bangLuongs);
        BangLuongModel AddEmpty(int id);
        int Add(BangLuongModel model);
        int Delete(int[] ids);
        BangLuongModel FindById(int id);
        int Update(BangLuongModel model);
    }
}

