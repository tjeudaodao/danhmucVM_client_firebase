using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Firebase.Storage;
using System.Net;

namespace danhmucVM_client
{
    class xulyFirebase
    {
        public static string duongdanchuaanh = Application.StartupPath + @"\luuanh\";
        public static System.Media.SoundPlayer danhmucmoi = new System.Media.SoundPlayer(Properties.Resources.danhmucmoi);
        public static string tencuahang;
        public static string setTenCuaHang
        {
            get { return tencuahang; }
            set { tencuahang = value; }
        }
        public static IFirebaseClient clientFirebase;
        public static IFirebaseConfig configFirebase = new FirebaseConfig
        {
            AuthSecret = "w2evy6pLiTOlWdsl3ZJ40eJ1qvCkCrFGUecs2kou",
            BasePath = "https://danhmucvm-cnf.firebaseio.com/"
        };
        //cac class ketqua
        class taikhoandangnhap
        {
            public string ten { get; set; }
            public string pass { get; set; }
        }
        class ngaymoinhat
        {
            public string tenngay { get; set; }
        }
        class filemoi
        {
            public string tenfile { get; set; }
        }
        class id
        {
            public int name { get; set; }
        }
        class masp
        {
            public string tenma { get; set; }
            public string trangthai { get; set; }
        }
        class ngaychon
        {
            public string tenngay { get; set; }
        }
        class update
        {
            public id id { get; set; }
            public masp masp { get; set; }
            public ngaychon ngaychon { get; set; }
        }
        // cac ham xu ly
        public static async Task<bool> kiemtraTK(string ten, string pass)
        {
            bool k = false;
            clientFirebase = new FireSharp.FirebaseClient(configFirebase);
            try
            {
                FirebaseResponse laytaikhoan = await clientFirebase.GetAsync("dangnhap/taikhoan/" + ten);
                taikhoandangnhap kq = laytaikhoan.ResultAs<taikhoandangnhap>();
                string tenF = kq.ten;
                string passF = kq.pass;
                if (ten == tenF && pass == passF)
                {
                    k = true;
                }
                else k = false;
            }
            catch (Exception)
            {
                k = false;
                
            }
            return k;
        }
        public static async Task<string> layngayGannhat()
        {
            clientFirebase = new FireSharp.FirebaseClient(configFirebase);
            FirebaseResponse layngay = await clientFirebase.GetAsync("thongso/ngaymoinhat");
            ngaymoinhat kq = layngay.ResultAs<ngaymoinhat>();
            return kq.tenngay;
        }
        public static async void updateSqlite(DataGridView dtv)
        {
            clientFirebase = new FireSharp.FirebaseClient(configFirebase);
            FirebaseResponse layngay = await clientFirebase.GetAsync("ngayduocban");
            Dictionary<string, Dictionary<string, dulieu>> kq = layngay.ResultAs<Dictionary<string, Dictionary<string, dulieu>>>();
            var con = ketnoisqlite_data.khoitao();
            string ngaysqlite = null;
            foreach (KeyValuePair<string, Dictionary<string, dulieu>> ngay in kq)
            {
                ngaysqlite = con.Kiemtra("ngaydangso", "hangduocban", ngay.Key);
                if (ngaysqlite == null)
                {
                    foreach (KeyValuePair<string, dulieu> ma in ngay.Value)
                    {
                        con.Chenvaobanghangduocban(ma.Key, ma.Value.ngayduocban, ma.Value.ghichu, ngay.Key, ma.Value.mota, ma.Value.chude);
                    }
                    dtv.Invoke(new MethodInvoker(delegate ()
                   {
                       dtv.DataSource = con.laythongtinkhichonngay(ngay.Key);
                   }));
                }
            }
        }
        public static async void taobang(string ngaychon, DataGridView dtv)
        {
            clientFirebase = new FireSharp.FirebaseClient(configFirebase);
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã tổng");
            dt.Columns.Add("Mô tả");
            dt.Columns.Add("Chủ đề");
            dt.Columns.Add("Ghi chú");
            dt.Columns.Add("Ngày được bán");
            dt.Columns.Add("Tình trạng trưng");
            dt.AcceptChanges();
            try
            {
                FirebaseResponse laytheongay = await clientFirebase.GetAsync("ngayduocban/" + ngaychon);
                Dictionary<string, dulieu> kq = laytheongay.ResultAs<Dictionary<string, dulieu>>();
                foreach (KeyValuePair<string, dulieu> item in kq)
                {
                    DataRow row = dt.NewRow();
                    row[0] = item.Key;
                    row[1] = item.Value.mota;
                    row[2] = item.Value.chude;
                    row[3] = item.Value.ghichu;
                    row[4] = item.Value.ngayduocban;
                    row[5] = item.Value.taikhoancnf.layten(tencuahang).trangthaitrung;
                    dt.Rows.Add(row);
                }
            }
            catch (Exception)
            {
                dtv.DataSource = null;
                return;
            }
            dtv.DataSource = dt;
        }
        public static async Task<bool> updateTrunghangkhichonngay(string ngaychondangdo, DataGridView dtv, Label lbtongma)
        {
            bool k = false;
            clientFirebase = new FireSharp.FirebaseClient(configFirebase);
            try
            {
                FirebaseResponse re = await clientFirebase.GetAsync("ngayduocban/" + ngaychondangdo);
                Dictionary<string, dulieu> kq = re.ResultAs<Dictionary<string, dulieu>>();
                var con = ketnoisqlite_data.khoitao();
                foreach (KeyValuePair<string, dulieu> item in kq)
                {
                    con.updatetrunghang(item.Key, item.Value.taikhoancnf.layten(tencuahang).trangthaitrung);
                }
                dtv.Invoke(new MethodInvoker(delegate ()
                {
                    dtv.DataSource = con.laythongtinkhichonngay(ngaychondangdo);
                    lbtongma.Invoke(new MethodInvoker(delegate ()
                    {
                        lbtongma.Text = dtv.Rows.Count.ToString();
                    }));
                }));
                k = true;
            }
            catch (Exception)
            {
                dtv.Invoke(new MethodInvoker(delegate ()
                {
                    dtv.DataSource = null;
                    lbtongma.Invoke(new MethodInvoker(delegate ()
                    {
                        lbtongma.Text = "0";
                    }));
                }));
                k = false;
            }
            return k;
        }
        public static async Task<string> layFilemoi()
        {
            clientFirebase = new FireSharp.FirebaseClient(configFirebase);
            FirebaseResponse lay = await clientFirebase.GetAsync("thongso/filemoi");
            filemoi kq = lay.ResultAs<filemoi>();
            return kq.tenfile;
        }
        public static async void updateTrunghangFB(string ngaydangso, string matong, string tentrangthai)
        {
            clientFirebase = new FireSharp.FirebaseClient(configFirebase);
            FirebaseResponse chen = await clientFirebase.UpdateAsync("ngayduocban/" + ngaydangso + "/" + matong + "/taikhoancnf/" + tencuahang, new { trangthaitrung = tentrangthai });
        }
        public static async void updateTrunghangTongFB(string ngaydangso, string matong, string tentrangthai,int id)
        {
            var data = new update
            {
                id = new id
                {
                    name = id
                },
                masp = new masp
                {
                    tenma = matong,
                    trangthai = tentrangthai
                },
                ngaychon = new ngaychon { tenngay = ngaydangso }
            };
            clientFirebase = new FireSharp.FirebaseClient(configFirebase);
            FirebaseResponse chen = await clientFirebase.UpdateAsync("updatetrunghang/" + tencuahang, data);

            Console.WriteLine(matong);
        }
        public static async void taifileanh(string tenanh, PictureBox pbanhsanpham)
        {
            var task = new FirebaseStorage("danhmucvm-cnf.appspot.com")
                    .Child("anhsanpham_cnf")
                    .Child(tenanh + ".png")
                    .GetDownloadUrlAsync();
            string link = await task;

            using (var client = new WebClient())
            {
                try
                {
                    if (link == null)
                    {
                        pbanhsanpham.Invoke(new MethodInvoker(delegate ()
                        {
                            pbanhsanpham.Image = Properties.Resources.bombs;
                        }));
                    }
                    else
                    {
                        client.DownloadFile(link, duongdanchuaanh + tenanh + ".png");
                        pbanhsanpham.Invoke(new MethodInvoker(delegate ()
                        {
                            pbanhsanpham.ImageLocation = duongdanchuaanh + tenanh + ".png";
                        }));
                    }
                }
                catch (Exception)
                {
                    pbanhsanpham.Invoke(new MethodInvoker(delegate ()
                    {
                        pbanhsanpham.Image = Properties.Resources.bombs;
                    }));
                    return;
                }

            }
        }
        // ham listener
        public static async void langngheLoadbang(DataGridView dtv, Form ff, Label lbtongma)
        {
            clientFirebase = new FireSharp.FirebaseClient(configFirebase);
            EventStreamResponse response = await clientFirebase.OnAsync("thongso/ngaymoinhat",
                changed:
                (sender, args, context) => {
                    chenBangsqlite(args.Data, dtv, lbtongma, ff);
                });
        }
        public static async void chenBangsqlite(string ngaydangso, DataGridView dtv, Label lbtongma , Form ff) //chen vao bang sqlite theo tham so ngaydangso
        {
            try
            {
                var con = ketnoisqlite_data.khoitao();
                if (con.Kiemtra("ngaydangso", "hangduocban", ngaydangso) == null)
                {
                    clientFirebase = new FireSharp.FirebaseClient(configFirebase);
                    FirebaseResponse laydulieu = await clientFirebase.GetAsync("ngayduocban/" + ngaydangso);
                    Dictionary<string, dulieu> kq = laydulieu.ResultAs<Dictionary<string, dulieu>>();

                    foreach (KeyValuePair<string, dulieu> item in kq)
                    {
                        con.Chenvaobanghangduocban(item.Key, item.Value.ngayduocban, item.Value.ghichu, ngaydangso, item.Value.mota, item.Value.chude);
                    }
                    dtv.Invoke(new MethodInvoker(delegate ()
                    {
                        dtv.DataSource = con.laythongtinkhichonngay(ngaydangso);
                        lbtongma.Invoke(new MethodInvoker(delegate ()
                        {
                            lbtongma.Text = dtv.Rows.Count.ToString();
                        }));
                    }));
                    ff.Invoke(new MethodInvoker(delegate ()
                    {
                        hamtao.thongbaoGocmanhinh("Có danh mục cập nhật mới nhất.\nNgày: " + ngaydangso);
                    }));

                    danhmucmoi.Play();
                }
            }
            catch (Exception)
            {
                return;
            }
            
        }
        public static async void xulylangngheTrunghang(DataGridView dtv, int idcuamay)
        {
            clientFirebase = new FireSharp.FirebaseClient(configFirebase);
            FirebaseResponse layngay = await clientFirebase.GetAsync("updatetrunghang/" + tencuahang);
            update kq = layngay.ResultAs<update>();
            int idSV = kq.id.name;
            if (idcuamay != idSV)
            {
                dtv.Invoke(new MethodInvoker(delegate ()
                {
                    taobang(kq.ngaychon.tenngay, dtv);
                }));
            }
        }
        public static async void langngheTrungHang(DataGridView dtv, int id)
        {
            clientFirebase = new FireSharp.FirebaseClient(configFirebase);
            EventStreamResponse trunghangListener = await clientFirebase.OnAsync("updatetrunghang/" + tencuahang,
                changed:
                (sender, args, context) =>
                {
                    xulylangngheTrunghang(dtv, id);
                });
        }
    }
}
