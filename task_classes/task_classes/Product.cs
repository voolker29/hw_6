
namespace task_classes
{
    internal class Product
    {
        public string Id { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }

        public Product(string id, int count, int price)
        {
           Id    = id;
           Count = count;
           Price = price;

        }
        public Product() 
        {
        }

    }


}
