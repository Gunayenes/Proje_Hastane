﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    internal class Sqlbaglantisi
    {
        public SqlConnection baglanti ()
        {
            SqlConnection baglan=new SqlConnection ("Data Source=DESKTOP-UH0CHU2\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");
            baglan.Open ();
            return baglan;
        }
    }
}
