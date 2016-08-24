using System.Collections.Generic;
using System.Linq;
using NorthwindLibrary;
using SurrogeteLibrary;

namespace NorthwindServiceLibrary
{
    public class ProductService : IProductService
    {
        public SurrogateProduct[] GetProducts(int categoryId)
        {
            List<SurrogateProduct> products = new List<SurrogateProduct>();

            using (NORTHWNDEntities model = new NORTHWNDEntities())
            {
                products = (from product in model.Products
                            where product.CategoryID == categoryId
                            select new SurrogateProduct
                            {
                                CategoryId = product.CategoryID,
                                ProductName = product.ProductName,
                                ProductId = product.ProductID
                            }).ToList<SurrogateProduct>();

            }


            return products.ToArray();
        }

        public SurrogateProduct[] GetProductByName(string firstLetter)
        {
            List<SurrogateProduct> products = new List<SurrogateProduct>();

            using (NORTHWNDEntities model = new NORTHWNDEntities())
            {
                products = (from p in model.Products
                            where p.ProductName.ToUpper().Contains(firstLetter.ToUpper())
                            select new SurrogateProduct
                            {
                                ProductId = p.ProductID,
                                CategoryId = p.CategoryID,
                                ProductName = p.ProductName
                            }).ToList<SurrogateProduct>();
            }

            return products.ToArray();
        }
    }
}
