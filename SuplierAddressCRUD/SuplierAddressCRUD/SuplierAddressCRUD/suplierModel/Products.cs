namespace SuplierAddressCRUD.suplierModel
{
    public class Products
    {
        public int Id { get; set; }
        public int ProductName { get; set; }
        public int UnitPrice { get; set; }
        public virtual Suplier Suplier { get; set; }
    }
}
