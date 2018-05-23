using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    public class Programmer : Nhanvien<thongtinnv>
    {
        public override List<thongtinnv> thongtinnhanvien(float? luongcb, int n)
        {
            List<thongtinnv> list = new List<thongtinnv>();
            for (int i = 0; i < n; i++)
            {

                thongtinnv tt = new thongtinnv();
                Console.Write("\nXin nhap ma nv "+i+": ");
                tt.maNV = int.Parse(Console.ReadLine());
                Console.Write("\nXin nhap ten nv: ");
                tt.tenNV = (string)(Console.ReadLine());
                Console.Write("\nXin nhap luong co ban: ");
                tt.luongcb = float.Parse(Console.ReadLine());
                Console.Write("\nXin nhap so loi mac phai: ");
                tt.soloi = int.Parse(Console.ReadLine());
                Console.WriteLine("+++++++++++++++++++++");
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
                    if (item.soloi < 20)
                    {
                        tt.luongthuclinh = (float)(item.luongcb * 1.1);
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
