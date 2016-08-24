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
    public partial class Window7 : Window
    {
        string sqlConn = "data source=.;database=AdventureWorks;integrated security=SSPI";
        string sorgu = @"SELECT PRD.ProductID, PRD.Name AS ProductName, PRD.SafetyStockLevel , PRD.StandardCost,PRD.ListPrice, PH.ThumbNailPhoto FROM Production.Product PRD INNER JOIN Production.ProductProductPhoto PPH ON PRD.ProductID = PPH.ProductID INNER JOIN Production.ProductPhoto PH ON PPH.ProductPhotoID = PH.ProductPhotoID";

        private void VeriyiCek()
        {
            DataTable dtUrunler = new DataTable();
            using (SqlConnection conn = new SqlConnection(sqlConn))
            {
                SqlDataAdapter da = new SqlDataAdapter(sorgu, conn);
                da.Fill(dtUrunler);
            }
            DataContext = dtUrunler;
        }

        public Window7()
        {
            InitializeComponent();
            VeriyiCek();
        }
    }
}
