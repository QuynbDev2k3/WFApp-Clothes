﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.BUS.ViewModels
{
    public class ViewQLPhuongThucThanhToan
    {
        public Guid Id { get; set; }
        public string Ten { get; set; }
        public int? TrangThai { get; set; }
    }
}
