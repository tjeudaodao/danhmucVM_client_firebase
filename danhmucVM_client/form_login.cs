using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace danhmucVM_client
{
    public partial class form_login : Form
    {
        dangnhap usdangnhap = new dangnhap();
        Thread chay3giay;

        private ManualResetEvent dieukhien = new ManualResetEvent(true);

        public form_login()
        {
            InitializeComponent();
        }
        void hamload()
        {
            
                usdangnhap.Location = new Point(150, 260);
                usdangnhap.Name = "usdangnhap";
                this.Controls.Add(usdangnhap);

                usdangnhap.Show();
                usdangnhap.BringToFront();
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void form_login_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(Application.StartupPath + @"\luuanh"))
                {
                    Directory.CreateDirectory(Application.StartupPath + @"\luuanh");
                }
                var con = ketnoisqlite.khoitao();
                string ghinho = con.laygiatri_ghinho();

                
                if (ghinho != "OK")
                {
                    hamload();
                }
                else if (ghinho == "OK")
                {
                    string[] tentk = con.laytaikhoan();
                    bool check = await xulyFirebase.kiemtraTK(tentk[0], tentk[1]);
                    if (check)
                    {
                        lbchaomung.Text = "WELCOME ... " + tentk[0].ToUpper();


                        chay3giay = new Thread(ham3giay);
                        chay3giay.IsBackground = true;
                        chay3giay.Start();
                    }
                }
                else
                {
                   MessageBox.Show("Xem lại tài khoản và mật khẩu");
                 
                    usdangnhap.Location = new Point(150, 260);
                    usdangnhap.Name = "usdangnhap";
                    this.Controls.Add(usdangnhap);

                    usdangnhap.Show();
                    usdangnhap.BringToFront();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi");
                return;
            }
            
        }
        void ham3giay()
        {
            pbavatar.Image = Properties.Resources.loading1;
            for (int i = 2; i > 0; i--)
            {
                lblogin.Invoke(new MethodInvoker(delegate ()
                {
                    lblogin.Text = "Đăng nhập trong ... " + i.ToString();
                }));
                Thread.Sleep(1000);
                dieukhien.WaitOne(Timeout.Infinite);
            }
            Program.moFrom = true;
            this.Invoke(new MethodInvoker(delegate ()
            {
                ((Form)this.TopLevelControl).Close();
            }));

            dieukhien.WaitOne(Timeout.Infinite);
        }
        private void btn_home_Click(object sender, EventArgs e)
        {
            
            dieukhien.Reset();
            usdangnhap.Location = new Point(150, 260);
            usdangnhap.Name = "usdangnhap";
            this.Controls.Add(usdangnhap);

            usdangnhap.Show();
            usdangnhap.BringToFront();
        }
    }
}
