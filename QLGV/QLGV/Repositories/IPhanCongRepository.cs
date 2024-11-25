﻿using QLGV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Repositories
{
    internal interface IPhanCongRepository
    {
        int Delete(int[] ids);
        int Delete(int[] ids, string byColumn);
        int Add(PhanCongModel model);
    }
}