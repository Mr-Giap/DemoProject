using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    public class Tester : Nhanvien<thongtinnv>
    {
        public override List<thongtinnv> thongtinnhanvien(float? luongcb,int n)
        {
            List<thongtinnv> list = new List<thongtinnv>();
            for (int i = 0; i < n; i++)
            {
                thongtinnv tt = new thongtinnv();
                Console.Write("\nXin nhap ma nv: ");
                tt.maNV = int.Parse(Console.ReadLine());
                Console.Write("\nXin nhap ten nv: ");
                tt.tenNV = (string)(Console.ReadLine());
                Console.Write("\nXin nhap so gio OT: ");
                tt.gioOT = int.Parse(Console.ReadLine());
                tt.luongcb = (float)luongcb;
                list.Add(tt);
            }
            return list;
        }
        public override List<thongtinnv> luonghangthang(List<thongtinnv> a)
        {
            List<thongtinnv> list = new List<Demo2.thongtinnv>();
            if(a != null)
            {
                foreach (var item in a)
                {
                    thongtinnv tt = new thongtinnv();
                    tt.maNV = item.maNV;
                    tt.tenNV = item.tenNV;
                    if (item.gioOT > 0)
                    {
                        tt.luongthuclinh = (float)(item.luongcb+(item.gioOT * 200000));
                    }
                    else
                    {
                        tt.luongthuclinh = item.luongcb;
                    }
                    list.Add(tt);
                }
            }
            return list;
        }
    }
}
