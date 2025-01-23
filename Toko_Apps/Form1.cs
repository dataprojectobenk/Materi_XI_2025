using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Toko_Apps
{
    public partial class Form1 : Form
    {
        String config = "Server=localhost;User=root;port=3306;Database=toko_app";
        MySqlConnection conn = null;
        public Form1()
        {
            InitializeComponent();
        }
        private AutoCompleteStringCollection getBookData()
        {
            conn = new MySqlConnection(connectionString: config);

            AutoCompleteStringCollection book = new AutoCompleteStringCollection();
            try
            {
                conn.Open();
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from books ";
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        book.Add(reader.GetString(1)); ;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return book;
        }

        private void kode_buku_Enter(object sender, EventArgs e)
        {
            kode_buku.AutoCompleteMode = AutoCompleteMode.Suggest;
            kode_buku.AutoCompleteCustomSource = getBookData();
            kode_buku.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void kode_buku_KeyUp(object sender, KeyEventArgs e)
        {


        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("TOKO Bheka", new Font("Calibri", 12, FontStyle.Bold),Brushes.Black,new Point(10,10));
            e.Graphics.DrawString("TOKO Bheka", new Font("Calibri", 12, FontStyle.Bold), Brushes.Black, new Point(10, 22));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("a4", 300, 600);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Show();
        }
    }
}
