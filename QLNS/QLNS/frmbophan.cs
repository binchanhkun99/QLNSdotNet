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
    public partial class frmbophan : Form
    {
        public QLNS1DataContext QLNS1DataContext { get; private set; }
        public object TenBoPhan { get; private set; }

        Clsdatabase cls = new Clsdatabase();
        public frmbophan()
        {
            InitializeComponent();
        }

        private void frmbophan_Load(object sender, EventArgs e)
        {
            QLNS1DataContext db = new QLNS1DataContext();

            dataGridView1.DataSource = from u in db.TblBoPhans
                                       select u;
            dateTimePicker1.CustomFormat = " MM / dd / yyyy ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (Control ctr in this.groupBox1.Controls)
            {
                if ((ctr is TextBox) || (ctr is DateTimePicker) || (ctr is ComboBox))
                {
                    ctr.Text = "";
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLNS1DataContext db = new QLNS1DataContext();
            var sql = from u in db.TblBoPhans
                      select TenBoPhan;
            try
            {
                if (!cls.kttrungkhoa(textBox1.Text, "select TenBoPhan from TblBoPhan"))
                {
                    
                    db.MaBoPhan = textBox1.Text;
                    db.TenBoPhan = textBox2.Text;
                    db.NgayThanhLap = dateTimePicker1.Text;
                    db.GhiChu = textBox3.Text;
                    db.SubmitChanges();
                    frmbophan_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Bộ phận này đã tòn tại ", "Trùng bộ phân", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                QLNS1DataContext db = new QLNS1DataContext();

                string tenbp = dataGridView1.SelectedCells[0].OwningRow.Cells["textBox2"].Value.ToString();
                DateTime ngaytl = DateTime.Parse(dataGridView1.SelectedCells[0].OwningRow.Cells["dateTimePicker1"].Value.ToString());
                string ghichu = dataGridView1.SelectedCells[0].OwningRow.Cells["textBox3"].Value.ToString();
                TblBoPhan edit = db.TblBoPhans.Where(p => p.MaBoPhan.Equals(textBox1)).SingleOrDefault();
                edit.TenBoPhan = tenbp;
                edit.NgayThanhLap = ngaytl;
                edit.GhiChu = ghichu;
                db.SubmitChanges();
                frmbophan_Load(sender, e);
                MessageBox.Show("Sửa thành công");
            }
            catch
            {
                MessageBox.Show("Dữ liệu đầu vào không đúng");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            QLNS1DataContext db = new QLNS1DataContext();
            string id = dataGridView1.SelectedCells[0].OwningRow.Cells["textBox1"].Value.ToString();
            TblBoPhan delete = db.TblBoPhans.Where(p => p.MaBoPhan.Equals(textBox1)).SingleOrDefault();
            TblPhongBan delete2 = db.TblPhongBans.Where(p => p.MaBoPhan.Equals(textBox1)).SingleOrDefault();
           
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không", "Xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
       
                    db.TblPhongBans.DeleteOnSubmit(delete2);
                    db.TblBoPhans.DeleteOnSubmit(delete);
                    db.SubmitChanges();
                    dataGridView1.DataSource = from i in db.TblBoPhans
                                               select i;
                    
                }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources._133;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackgroundImage = Properties.Resources.xanh;
        }
    }
}
