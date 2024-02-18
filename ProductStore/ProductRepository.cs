namespace ProductStore
{
    public class ProductRepository
    {
        private static ProductRepository? _instance;
        private List<string> _products;

        private ProductRepository()
        {
            _products = new List<string>();
        }

        public static ProductRepository Instance 
        { 
            get 
            {
                if (_instance is null)
                    _instance = new ProductRepository();
                return _instance;
            } 
        }

        public void AddProduct(string product)
        {
            _products.Add(product);
        }

        public void DisplayProducts()
        {
            Console.WriteLine("Products available: ");
            foreach (string product in _products)
                Console.WriteLine(product);
        }

    }
}
