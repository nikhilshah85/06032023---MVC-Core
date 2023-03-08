namespace MVCshoppingAPP.Models
{
    public class ProductsModel
    {
        public int pId { get; set; }
        public string pName { get; set; }
        public string pCategory { get; set; }
        public double pPrice { get; set; }
        public bool pIsInStock { get; set; }


        static List<ProductsModel> pList = new List<ProductsModel>()
        {
            new ProductsModel() { pId=101, pName="Pepsi", pCategory="Cold-Drink", pIsInStock=true, pPrice=50},
            new ProductsModel() { pId=102, pName="Maggie", pCategory="Fast-Food", pIsInStock=false, pPrice=50},
            new ProductsModel() { pId=103, pName="IPhone", pCategory="Electronics", pIsInStock=true, pPrice=50},
            new ProductsModel() { pId=104, pName="Dell Lattitude", pCategory="Electronics", pIsInStock=false, pPrice=50},
            new ProductsModel() { pId=105, pName="FossilQ", pCategory="Watch", pIsInStock=true, pPrice=50}
        };

        public List<ProductsModel> GetAllProducts()
        {
           
            return pList;
        }

        public ProductsModel SearchById(int id)
        {
            var pr = pList.Find(p => p.pId == id);
            if (pr!= null)
            {
                return pr;
            }
            throw new Exception("Product Not Found");
        }

        public string AddNewProduct(ProductsModel newProduct)
        {
            pList.Add(newProduct);
            return "Product Added Successfully";
        }
    }
}





