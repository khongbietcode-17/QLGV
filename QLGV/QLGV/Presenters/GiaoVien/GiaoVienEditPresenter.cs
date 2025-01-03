﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLGV.Dtos.GiaoVien;
using QLGV.Models;
using QLGV.Services;
using QLGV.Views.GiaoVien;

namespace QLGV.Presenters.GiaoVien
{
    public class GiaoVienEditPresenter
    {
        private readonly IGiaoVienEdit _view;
        public readonly GiaoVienService _service;
        public readonly BoMonService _bomonService;
        public readonly ChucVuService _chucvuService;
        public GiaoVienEditPresenter(GiaoVienEdit view) 
        {
            _view = view;
            _service = new GiaoVienService();
            _chucvuService = new ChucVuService();   
            _bomonService = new BoMonService();
            int id = _view.InitId;           
            _view.SetDataSourceChucVu(GetChucVu());
            _view.InitData(_service.GetOne(id), _bomonService.GetAll());
            _view.OnUpdate += UpdateGiaoVien;
        }

        public void UpdateGiaoVien(object sender, EventArgs e)
        {
            GiaoVienUpdateDto giaoVienDto = GiaoVienUpdateDto.FromView(_view);
            _service.UpdateOne(giaoVienDto);
        }

        public IEnumerable<ChucVuModel> GetChucVu()
        {
            return _chucvuService.GetAll();
        }
    }
}
