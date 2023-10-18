using Newtonsoft.Json;
using class1;

Product apple = Factory.Create("30g", "20", "5", "apple", "no");
Product potatoes = Factory.Create("1kg", "55", "2", "potatoes", "no");
Product lemon = Factory.Create("150g", "50", "3", "lemon", "no");
Product glass = Factory.Create("300g", "50", "200ml", "glass", "yes");
Product table = Factory.Create("1.5kg", "2000", "12", "table", "no");
Product vaza = Factory.Create("2kg", "1500", "2l", "vaza", "yes");
Product milk = Factory.Create("500ml", "100", "500ml", "milk", "no");
Product flower = Factory.Create("300g", "350", "12", "flower", "yes");
Product limonade = Factory.Create("1l", "100", "1l", "limonade", "no");
Product cake = Factory.Create("600g", "400", "200", "cake", "no");

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
