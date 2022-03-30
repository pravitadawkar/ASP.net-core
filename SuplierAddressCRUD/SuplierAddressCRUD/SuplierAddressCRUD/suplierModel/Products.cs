namespace SuplierAddressCRUD.suplierModel
{
    public class Products
    {
        
    public int Id { get; set; }
        public int ProductName { get; set; }
        public int UnitPrice { get; set; }
        //navigation properties
        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
