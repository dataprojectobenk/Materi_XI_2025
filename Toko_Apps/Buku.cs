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
    public partial class Buku : Form
    {
        public Buku()
        {
            InitializeComponent();
            Book.getBooks();
            refreshTabel();
        }

        public void refreshTabel()
        {
            int no = 1;
            dataGridView1.Rows.Clear();
            foreach (var item in Book.books)
            {
                dataGridView1.Rows.Add(no, item.kode_buku, item.judul, item.pengarang, item.penerbit, item.harga.ToString("N"), item.stok);
                no++;
            }
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

       
        
        private  void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BookForm bookForm = new BookForm();
            foreach (var item in Book.books)
            {
                if (item.kode_buku.Equals(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()))
                {
                    bookForm.buku = item;
                }
            }
            bookForm.ShowDialog();
        }
    }
}
