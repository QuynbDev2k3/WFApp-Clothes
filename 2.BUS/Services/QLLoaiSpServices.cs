﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1.DAL.DomainClass;
using _1.DAL.IRepositories;
using _1.DAL.Repositories;
using _2.BUS.IServices;

namespace _2.BUS.Services
{
    public class QLLoaiSpServices : IQLLoaiSpServices
    {
        private IClassCRUDRepo<LoaiSp> _iLoaiSpRepository;
        public QLLoaiSpServices()
        {
            _iLoaiSpRepository = new LoaiSpRepository();
        }
        public string Add(LoaiSp obj)
        {
            if (obj == null) return "Thêm thất bại";
            var tempobj = obj;
            if (_iLoaiSpRepository.Add(tempobj)) return "Thêm thành công";
            return "Thêm thất bại";
        }

        public string Delete(LoaiSp obj)
        {
            if (obj == null) return "Xóa thất bại";
            var tempobj = obj;
            if (_iLoaiSpRepository.Delete(tempobj)) return "Xóa thành công";
            return "Xóa thất bại";
        }

        public List<LoaiSp> GetAll()
        {
            return _iLoaiSpRepository.GetAll();
        }

        public LoaiSp GetByID(Guid id)
        {
            throw new NotImplementedException();
        }

        public string Update(LoaiSp obj)
        {
            if (obj == null) return "Sửa thất bại";
            var tempobj = obj;
            if (_iLoaiSpRepository.Update(tempobj)) return "Sửa thành công";
            return "Sửa thất bại";
        }
    }
}
