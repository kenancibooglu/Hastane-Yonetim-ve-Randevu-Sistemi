using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // sql baglantisi için kütüphane

namespace Hastane_Yonetim
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti ()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-TONG9CH\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True;");
            baglan.Open ();
            return baglan; // baglandan geriye dönen değer
        }
    }
}
