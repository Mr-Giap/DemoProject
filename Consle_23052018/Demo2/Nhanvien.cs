﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    public abstract class Nhanvien<T>
    {
        public abstract class aaa(){}
        public virtual List<T> thongtinnhanvien(float? luongcb,int n) { return null; }
        public virtual List<T> luonghangthang(List<T> a) { return null; }
    }
}
