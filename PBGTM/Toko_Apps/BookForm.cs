using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toko_Apps
{
    public partial class BookForm : Form
    {
        public Book buku;


        public BookForm()
        {
            InitializeComponent();
        }

        private void BookForm_Shown(object sender, EventArgs e)
        {
            textKodeBuku.Text = buku.kode_buku;
            textJudul.Text = buku.judul;
            textPengarang.Text= buku.pengarang;
            textPenerbit.Text = buku.penerbit;
            textHarga.Text = buku.harga.ToString("N");
            textStok.Text = buku.stok.ToString();
        }
    }
}
