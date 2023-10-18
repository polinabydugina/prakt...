using Newtonsoft.Json;
Product apple = new Product("30g", "20", "5", "apple", "no");
Product potatoes = new Product("1kg", "55", "2", "potatoes", "no");
Product lemon = new Product("150g", "50", "3", "lemon", "no");
Product glass = new Product("300g", "50", "200ml", "glass", "yes");
Product table = new Product("1.5kg", "2000", "12", "table", "no");
Product vaza = new Product("2kg", "1500", "2l", "vaza", "yes");
Product milk = new Product("500ml", "100", "500ml", "milk", "no");
Product flower = new Product("300g", "350", "12", "flower", "yes");
Product limonade = new Product("1l", "100", "1l", "limonade", "no");
Product cake = new Product("600g", "400", "200", "cake", "no");

List<Product> products = new List<Product>();
products.Add(apple);
products.Add(potatoes);
products.Add(lemon);
products.Add(glass);
products.Add(table);
products.Add(vaza);
products.Add(milk);
products.Add(flower);
products.Add(limonade);
products.Add(cake);

foreach (Product c in products)
{
    string json = JsonConvert.SerializeObject(c);
    Console.WriteLine(json);
}
class Product
{
    public string weight;
    public string cost;
    public string volume;
    public string name;
    public string fragility;

    public Product(string weight, string cost, string volume, string name, string fragility)
    {

        this.weight = weight;
        this.cost = cost;
        this.volume = volume;
        this.name = name;
        this.fragility = fragility;
    }
}