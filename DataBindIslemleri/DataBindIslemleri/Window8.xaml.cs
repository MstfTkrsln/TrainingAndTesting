using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace DataBindIslemleri
{
    public partial class Window8 : Window
    {
        private string conStr = "data source=.;database=AdventureWorks;integrated security=SSPI";
        private string kategoriSorgusu = "Select ProductSubCategoryID,Name From Production.ProductSubCategory";
        private string urunSorgusu = "Select ProductID,ProductSubCategoryID,Name,ListPrice From Production.Product";

        private void VerileriCek()
        {
            using (SqlConnection conn = new SqlConnection(conStr))
            {
                SqlDataAdapter daKategori = new SqlDataAdapter(kategoriSorgusu, conn);
                DataTable dtKategori = new DataTable();
                daKategori.Fill(dtKategori);

                SqlDataAdapter daUrun = new SqlDataAdapter(urunSorgusu, conn);
                DataTable dtUrun = new DataTable();
                daUrun.Fill(dtUrun);

                DataSet ds = new DataSet();
                ds.Tables.Add(dtUrun);
                ds.Tables.Add(dtKategori);

                DataRelation iliski = new DataRelation("SubCatToProduct", dtKategori.Columns["ProductSubCategoryID"], dtUrun.Columns["ProductSubCategoryID"]);
                ds.Relations.Add(iliski);

                DataContext = dtKategori;
            }
        }
        public Window8()
        {
            InitializeComponent();
            VerileriCek();
        }
    }
}
