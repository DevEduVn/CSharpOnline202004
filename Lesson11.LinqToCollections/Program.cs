using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11.LinqToCollections
{
    class Program
    {
        static void Show<T>(IEnumerable<T> list, string msg)
        {
            Console.WriteLine("\n " + msg);
            foreach (var item in list)
            {
                Console.WriteLine("\t"+item.ToString());
            }
        }
        static void Main(string[] args)
        {
            List<Category> ListCate = new List<Category>
            {
                new Category{ID=10, Name="Vo thuat"},
                new Category{ID=12, Name="Kiem hiep"},
                new Category{ID=15, Name="Da su"},
                new Category{ID=17, Name="Gi do"}

            };

            Show<Category>(ListCate, "Danh sach ban dau");

            var res = from a in ListCate
                      select a;
            Show<Category>(res, "Linq => Truy vấn lấy tất cả");

            res = from a in ListCate
                  where a.ID >= 12
                  select a;
            Show<Category>(res, "Linq => Truy vấn với điều kiện ID>=12");

            res = from b in ListCate
                  where b.Name.Equals("Gi do")
                  select b;

            Show<Category>(res, "Linq => Truy vấn voi dieu kien name");
            /*
            res = from c in ListCate
                  select new
                  {
                      Ma = c.ID,
                      Ten = c.Name
                  };
            */
            // Linq to entity

            res = ListCate.Where(x => x.ID >= 12);
            Show<Category>(res, "ID>=12");

            // Tạo 1 list film
            List<Category> Table1 = new List<Category>()
            {
                new Category{ID=1, Name="Kiem hiep"},
                new Category{ID=2, Name="Da sa"},
                new Category{ID=3, Name="Võ thuật"}
            };
            List<Film> Table2 = new List<Film>()
            {
                new Film{FilmId="F01",FilmName="Điệp viên 007",Price=120000,CateID=1},
                new Film{FilmId="F02",FilmName="Tam quốc diễn nghĩa",Price=130000,CateID=1},
                new Film{FilmId="F03",FilmName="Thiếu lâm truyền kỳ",Price=16000,CateID=2},
                new Film{FilmId="F04",FilmName="Người nhện 2",Price=100000,CateID=1},
                new Film{FilmId="F05",FilmName="Ngân hàng tình yêu",Price=340000,CateID=2},
                new Film{FilmId="F06",FilmName="Người đẹp và quái thú",Price=230000,CateID=1},
                new Film{FilmId="F07",FilmName="Biệt động Sài Gòn",Price=190000,CateID=2},
            };

            Show<Category>(Table1, "Bang loai");
            Show<Film>(Table2, "Bang film");

            var ViewRes = from t1 in Table1
                        join t2 in Table2 on t1.ID equals t2.CateID
                        select t1;
            Console.WriteLine("\n Ket qua phep join");
            foreach (var item in ViewRes)
            {
                Console.WriteLine(item.ID + ":" + item.Name);
            }

            var ViewRes1 =    from t1 in Table1
                              join t2 in Table2 on t1.ID equals t2.CateID
                              where t2.FilmName.Contains("Ng")
                              select new { 
                                    MaLoai = t1.ID,
                                    TenLoai=t1.Name,
                                    MaFilm = t2.FilmId,
                                    TenFilm = t2.FilmName,
                                    DonGia=t2.Price
                              };
            Console.WriteLine("\n Ket qua phep join ");
            foreach (var item in ViewRes1)
            {
                Console.WriteLine("{0,-5}{1,-15}{2,-5}{3,-20}{4,15}",
                        item.MaLoai, item.TenLoai, item.MaFilm,item.TenFilm, item.DonGia);
            }

            var lst = Table2.Count();
            Console.WriteLine(lst);

            var lst1 = Table2.TakeWhile(x => x.FilmName.StartsWith("N")).ToList();
            foreach (var item in lst1)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
    }

    class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return string.Format("{0,-10}{1,-30}", ID, Name);
        }
    }
    class Film
    {
        public string FilmId { get; set; }
        public string FilmName { get; set; }
        public int Price { get; set; }
        public int CateID { get; set; }
        public override string ToString()
        {
            return string.Format("{0,-5}{1,-5}{2,-25}{3,15}", 
                CateID, FilmId, FilmName, Price);
        }

    }
}
