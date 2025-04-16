using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toko_Apps
{
    public class Book
    {
        public  int id_buku { get; set; }
        public  string kode_buku { get; set; }
        public  string judul { get; set; }
        public  string pengarang { get; set; }
        public  string penerbit { get; set; }
        public  float harga { get; set; }
        public  int stok { get; set; }

        public Book(int id_buku, string kode_buku, string judul, string pengarang, string penerbit, float harga, int stok)
        {
            this.id_buku = id_buku;
            this.kode_buku = kode_buku;
            this.judul = judul;
            this.pengarang = pengarang;
            this.penerbit = penerbit;
            this.harga = harga;
            this.stok = stok;
        }
        public Book() { }

        public static List<Book> books { get; set; }

        public static void getBooks()
        {
            using (MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;User=root;Database=toko_app"))
            {
                List<Book> temp = new List<Book>();
                conn.Open();
                using (MySqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "select * from books";
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        temp.Add(new Book(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetFloat(5), reader.GetInt32(6)));
                    }
                    books = temp;
                }
            }
        }
    }
}
