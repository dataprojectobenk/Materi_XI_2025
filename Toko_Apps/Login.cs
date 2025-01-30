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
    public partial class Login : Form
    {
        String configDb = "Server=localhost;User=root;port=3306;Database=toko_app";
        public Login()
        {
            InitializeComponent();
        }
    }
}
