using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    public class Tester : Nhanvien<thongtinnvtest>
    {
        public override List<thongtinnvtest> thongtinnhanvien(float? luongcb,int n)
        {
            List<thongtinnvtest> list = new List<thongtinnvtest>();
            for (int i = 0; i < n; i++)
            {
                thongtinnvtest tt = new thongtinnvtest();
                Console.Write("\nXin nhap ma nv "+(i+1)+ " :");
                tt.maNV = int.Parse(Console.ReadLine());
                Console.Write("\nXin nhap ten nv: ");
                tt.tenNV = (string)(Console.ReadLine());
                Console.Write("\nXin nhap so gio OT: ");
                tt.gioOT = int.Parse(Console.ReadLine());
                tt.luongcb = (float)luongcb;
                Console.WriteLine("+++++++++++++++++++++");
                list.Add(tt);
            }
            return list;
        }
        public override List<thongtinnvtest> luonghangthang(List<thongtinnvtest> a)
        {
            List<thongtinnvtest> list = new List<Demo2.thongtinnvtest>();
            if(a != null)
            {
                foreach (var item in a)
                {
                    thongtinnvtest tt = new thongtinnvtest();
                    tt.maNV = item.maNV;
                    tt.tenNV = item.tenNV;
                    tt.gioOT = item.gioOT;
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
