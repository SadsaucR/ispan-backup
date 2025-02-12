namespace Lab250227_MVC
{
    public class Product
    {
        public string ProductName { get; set; }
        public string ProductPrice { get; set; }
        public Product()
        {
            ProductName = string.Empty;
            ProductPrice = string.Empty;
        }

        public Product(string pdname,string pdprice)
        {
            ProductName = pdname;
            ProductPrice = pdprice;
        }
    }
}
