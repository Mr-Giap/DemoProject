using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    public class Programmer : Nhanvien<thongtinnvpro>
    {
        public override List<thongtinnvpro> thongtinnhanvien(float? luongcb, int n)
        {
            List<thongtinnvpro> list = new List<thongtinnvpro>();
            for (int i = 0; i < n; i++)
            {
                String
                thongtinnvpro tt = new thongtinnvpro();
                Console.Write("\nXin nhap ma nv "+(i + 1)+ ": ");
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
        
        public override List<thongtinnvpro> luonghangthang(List<thongtinnvpro> a)
        {
            List<thongtinnvpro> list = new List<thongtinnvpro>();
            if(a != null)
            {
                foreach (var item in a)
                {
                    thongtinnvpro tt = new thongtinnvpro();
                    tt.maNV = item.maNV;
                    tt.tenNV = item.tenNV;
                    tt.soloi = item.soloi;
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
