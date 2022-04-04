using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLNS
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public int k = 1;
        public void truyen()
        {
        }
        public static string quyen;
        private void FrmMain_Load(object sender, EventArgs e)
        {
            
            if (quyen == "Admin")
            {
                menuItem2.Enabled = true;
                menuItem3.Enabled = true;
                menuItem14.Enabled = true;
                menuItem5.Enabled = true;
            }
            else if(quyen=="user")
            {
                menuItem2.Enabled = true;
                menuItem3.Enabled = true;
                menuItem14.Enabled = true;
                menuItem5.Enabled = false;
            }




        }



 


        private void menuItem11_Click(object sender, EventArgs e)
        {
            frmtimkiem ftk = new frmtimkiem();
            panel_show.Show();
            panel_show.Controls.Clear();
            ftk.TopLevel = false;
            ftk.Dock = DockStyle.Fill;
            panel_show.Controls.Add(ftk);
            ftk.Show();
        }



        private void menuItem19_Click(object sender, EventArgs e)
        {

        }

        private void menuItem20_Click(object sender, EventArgs e)
        {

        }


        private void cmd_exit_MouseMove(object sender, MouseEventArgs e)
        {
            cmd_exit.BackgroundImage = Properties.Resources.butbut;
        }

        private void cmd_exit_MouseLeave(object sender, EventArgs e)
        {
            cmd_exit.BackgroundImage = Properties.Resources._133;
        }
 
        private void cmd_taiKhoan_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources._133;
        }

        private void cmd_taiKhoan_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.xanh;
        }

        private void cmd_dangnhap_Click(object sender, EventArgs e)
        {


            this.Hide();
            frmdangnhap f1 = new frmdangnhap();
            f1.ShowDialog();
            this.Close();

        }

        private void cmd_dangnhap_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.btuufon112;
        }

        private void cmd_dangnhap_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.b1;
        }

        private void cmd_dangky_Click(object sender, EventArgs e)
        {


        }


        private void cmd_nhansu_Click(object sender, EventArgs e)
        {

        }

        private void cmd_thongticanhan_Click(object sender, EventArgs e)
        {
            frmthongtincanhan ft = new frmthongtincanhan();

            panel_show.Show();
            panel_show.Controls.Clear();
            ft.TopLevel = false;
            ft.Dock = DockStyle.Fill;
            panel_show.Controls.Add(ft);
            ft.Show();

        }

        private void cmd_chedo_Click(object sender, EventArgs e)
        {
            frmchedo fcd = new frmchedo();
            panel_show.Show();
            panel_show.Controls.Clear();
            fcd.TopLevel = false;
            fcd.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fcd);
            fcd.Show();
        }

        private void cmd_tienluong_Click(object sender, EventArgs e)
        {
            frmluong fl = new frmluong();

            panel_show.Show();
            panel_show.Controls.Clear();
            fl.TopLevel = false;
            fl.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fl);
            fl.Show();
        }

        private void cmd_tracuu_Click(object sender, EventArgs e)
        {
            frmtimkiem ftk = new frmtimkiem();
            panel_show.Show();
            panel_show.Controls.Clear();
            ftk.TopLevel = false;
            ftk.Dock = DockStyle.Fill;
            panel_show.Controls.Add(ftk);
            ftk.Show();
        }

        private void cmd_Qlphongban_Click(object sender, EventArgs e)
        {
            frmphongban fpb = new frmphongban();
            panel_show.Show();
            panel_show.Controls.Clear();
            fpb.TopLevel = false;//khi nhấp vào thì hiển thị
            fpb.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fpb);
            fpb.Show();

        }

        private void cmd_Qlbophan_Click(object sender, EventArgs e)
        {
            frmbophan frb = new frmbophan();
            panel_show.Show();
            panel_show.Controls.Clear();
            frb.TopLevel = false;
            frb.Dock = DockStyle.Fill;
            panel_show.Controls.Add(frb);
            frb.Show();
        }



        private void cmd_qlbangcong_Click(object sender, EventArgs e)
        {
            frmbangcong fbc = new frmbangcong();

            panel_show.Show();
            panel_show.Controls.Clear();
            fbc.TopLevel = false;
            fbc.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fbc);
            fbc.Show();
        }

        private void btntracuu_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmtimkiem ftk = new frmtimkiem();
            panel_show.Show();
            panel_show.Controls.Clear();
            ftk.TopLevel = false;
            ftk.Dock = DockStyle.Fill;
            panel_show.Controls.Add(ftk);
            ftk.Show();
        }

        private void btndmk_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmdoimatkhau fdm = new frmdoimatkhau();
            panel_show.Show();
            panel_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fdm);
            fdm.Show();

        }

        private void btnchedo_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmchedo fcd = new frmchedo();
            panel_show.Show();
            panel_show.Controls.Clear();
            fcd.TopLevel = false;
            fcd.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fcd);
            fcd.Show();
        }

        private void btnluong_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmluong fl = new frmluong();

            panel_show.Show();
            panel_show.Controls.Clear();
            fl.TopLevel = false;
            fl.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fl);
            fl.Show();
        }

        private void bubblenhansu_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmthongtincanhan ft = new frmthongtincanhan();

            panel_show.Show();
            panel_show.Controls.Clear();
            ft.TopLevel = false;
            ft.Dock = DockStyle.Fill;
            panel_show.Controls.Add(ft);//show thong tin ca nhan
            ft.Show();
        }

        private void bubblebophan_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmbophan frb = new frmbophan();
            panel_show.Show();
            panel_show.Controls.Clear();
            frb.TopLevel = false;
            frb.Dock = DockStyle.Fill;
            panel_show.Controls.Add(frb);// show bo phan
            frb.Show();
        }

        private void bubblephongban_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmphongban fpb = new frmphongban();
            panel_show.Show();
            panel_show.Controls.Clear();
            fpb.TopLevel = false;
            fpb.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fpb);//show phong ban
            fpb.Show();
        }

        private void bubbleBcnhanvien_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {

        }

        private void cmd_minimax_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void cmd_maximax_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).Size = new Size(26, 25);
        }

        private void cmd_maximax_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).Size = new Size(24, 23);
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }

        private void panel_show_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            frmdangnhap dn = new frmdangnhap();
            this.Hide();
            dn.ShowDialog();
            dn.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

     

        private void menuItem1_Click(object sender, EventArgs e)
        {

        }

        private void menuItemdmk_Click_1(object sender, EventArgs e)
        {
            frmdoimatkhau fdm = new frmdoimatkhau();
            panel_show.Show();
            panel_show.Controls.Clear();
            fdm.TopLevel = false;
            fdm.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fdm);
            fdm.Show();

        }

        private void menuItem7_Click(object sender, EventArgs e)
        {
        
        }

        private void menuItem8_Click(object sender, EventArgs e)
        {
            frmthongtincanhan ft = new frmthongtincanhan();

            panel_show.Show();
            panel_show.Controls.Clear();
            ft.TopLevel = false;
            ft.Dock = DockStyle.Fill;
            panel_show.Controls.Add(ft);
            ft.Show();
        }

        private void menuItem9_Click(object sender, EventArgs e)
        {
            frmchedo fcd = new frmchedo();
            panel_show.Show();
            panel_show.Controls.Clear();
            fcd.TopLevel = false;
            fcd.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fcd);
            fcd.Show();
        }


        private void menuItem15_Click(object sender, EventArgs e)
        {
            frmphongban fpb = new frmphongban();
            panel_show.Show();
            panel_show.Controls.Clear();
            fpb.TopLevel = false;
            fpb.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fpb);
            fpb.Show();
        }

        private void menuItem16_Click(object sender, EventArgs e)
        {
            frmbophan frb = new frmbophan();
            panel_show.Show();
            panel_show.Controls.Clear();
            frb.TopLevel = false;
            frb.Dock = DockStyle.Fill;
            panel_show.Controls.Add(frb);
            frb.Show();
        }

        private void menuItem17_Click(object sender, EventArgs e)
        {
            frmbangcong fhtv = new frmbangcong();
            panel_show.Show();
            panel_show.Controls.Clear();
            fhtv.TopLevel = false;
            fhtv.Dock = DockStyle.Fill;
            panel_show.Controls.Add(fhtv);
            fhtv.Show();
        }

        private void menuItem18_Click(object sender, EventArgs e)
        {
            frmluong aa = new frmluong();
            panel_show.Show();
            panel_show.Controls.Clear();
            aa.TopLevel = false;
            aa.Dock = DockStyle.Fill;
            panel_show.Controls.Add(aa);
            aa.Show();

        }

        private void menuItem19_Click_1(object sender, EventArgs e)
        {

        }

        private void menuItem20_Click_1(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            panel_show.Show();
            panel_show.Controls.Clear();
            a.TopLevel = false;
            a.Dock = DockStyle.Fill;
            panel_show.Controls.Add(a);
            a.Show();
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            frmdangki b = new frmdangki();
            panel_show.Show();
            panel_show.Controls.Clear();
            b.TopLevel = false;
            b.Dock = DockStyle.Fill;
            panel_show.Controls.Add(b);
            b.Show();
        }

        private void menuItem13_Click(object sender, EventArgs e)
        {
            frmtrogiup x = new frmtrogiup();
            panel_show.Show();
            panel_show.Controls.Clear();
            x.TopLevel = false;
            x.Dock = DockStyle.Fill;
            panel_show.Controls.Add(x);
            x.Show();
        }

       


    }
}
