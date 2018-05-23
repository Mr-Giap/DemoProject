using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    public class Program
    {

        static void Main(string[] args)
        {
            // khai báo biến số lượng nhân có lỗi lớn hơn 5.
            int loiit = 0;
            // khai báo nhân viên có số giờ over time lớn nhất
            thongtinnv maxtime = new thongtinnv();
            maxtime.gioOT = 0;
            // nhập n số nhân viên và gán vào biến
            // programer
            Console.Write("\nXin nhap vao so nv programer: ");
            int nvpro = int.Parse(Console.ReadLine());
            //tester
            Console.Write("\nXin nhap vao so nv tester: ");
            int nvtest = int.Parse(Console.ReadLine());
            // kiểm tra số lượng nhâp vào
            if (nvpro > 0)
            {
                // thong tin cb
                Console.WriteLine("====================================");
                Console.WriteLine("Nhap thong tin co ban cua cac programer");
                List<thongtinnv> prolist = new Programmer().thongtinnhanvien(null, nvpro);
                var luongpro = new Programmer().luonghangthang(prolist);
                // tinh tien luong
                Console.WriteLine("====================================");
                Console.WriteLine("Day la thong tin luong cua cac programer");
                // in tiền lương ra.
                foreach (var item in luongpro)
                {
                    if (item.soloi < 5)
                    {
                        loiit++;
                    }
                    Console.Write("\nMa nv: " + item.maNV);
                    Console.Write("          Ten nv: " + item.tenNV);
                    Console.Write("          Luong thuc linh: " + item.luongthuclinh+"\n");
                    Console.ReadKey();
                }
                Console.WriteLine("====================================");
                Console.WriteLine("Day la so luong nv co loi duoi 5: " + loiit);
                Console.ReadKey();
            }
            if(nvtest > 0)
            {
                //so luong cb
                Console.Write("\nXin nhap vao luong co ban cua tester: ");
                float luongcbtest = float.Parse(Console.ReadLine());
                //thong tin co ban
                Console.WriteLine("====================================");
                Console.WriteLine("Nhap thong tin co ban cua cac tester");
                List<thongtinnv> testlist = new Tester().thongtinnhanvien(luongcbtest, nvtest);
                var luongtest = new Tester().luonghangthang(testlist);
                // tinh tien luong
                Console.WriteLine("====================================");
                Console.WriteLine("Day la thong tin luong cua cac tester");
                // in tiền lương ra
                foreach (var item in luongtest)
                {
                    if (item.gioOT > maxtime.gioOT)
                    {
                        maxtime.maNV = item.maNV;
                        maxtime.tenNV = item.tenNV;
                        maxtime.luongcb = item.luongcb;
                        maxtime.luongthuclinh = item.luongthuclinh;
                        maxtime.gioOT = item.gioOT;
                    }
                    Console.Write("\nMa nv: " + item.maNV);
                    Console.Write("          Ten nv: " + item.tenNV);
                    Console.Write("          Luong thuc linh: " + item.luongthuclinh+"\n");
                    Console.ReadKey();
                }
                Console.WriteLine("====================================");
                Console.WriteLine("Day la thong tin nv co gio OT lon nhat: ");
                Console.Write("\nMa nv: " + maxtime.maNV);
                Console.Write("     Ten nv: " + maxtime.tenNV);
                Console.Write("     So gio OT: " + maxtime.gioOT);
                Console.Write("     Luong thuc linh: " + maxtime.luongthuclinh);
                Console.ReadKey();
            }
            //Console.WriteLine("====================================");
            //Console.WriteLine("Day la so luong nv co loi duoi 5: "+loiit);
            //Console.WriteLine("====================================");
            //Console.WriteLine("Day la thong tin nv co gio OT lon nhat: ");
            //Console.Write("\nMa nv: " + maxtime.maNV);
            //Console.Write("          Ten nv: " + maxtime.tenNV);
            //Console.Write("          Luong thuc linh: " + maxtime.luongthuclinh);
            //Console.ReadKey();


        }
    }
}
