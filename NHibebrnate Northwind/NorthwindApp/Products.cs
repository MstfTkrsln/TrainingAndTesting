namespace NorthwindClient
{
   public class Products
    {
        public virtual int ProductID{ get; set; }
        public virtual string ProductName { get; set; }
        public virtual int SupplierID { get; set; }
        public virtual int CategoryID { get; set; }
        public virtual string QuantityPerUnit { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual int UnitsInStock { get; set; }
        public virtual int UnitsOnOrder { get; set; }
        public virtual int ReorderLevel { get; set; }
        public virtual bool Discontinued { get; set; }

    }
}
