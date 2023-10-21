using Newtonsoft.Json;
using class1;

Product apple = Factory.Create(30, "20", "5", "apple", "no");
Product potatoes = Factory.Create(1, "55", "2", "potatoes", "no");
Product lemon = Factory.Create(150, "50", "3", "lemon", "no");
Product glass = Factory.Create(300, "50", "200ml", "glass", "yes");
Product table = Factory.Create(1, "2000", "12", "table", "no");
Product vaza = Factory.Create(2, "1500", "2l", "vaza", "yes");
Product milk = Factory.Create(500, "100", "500ml", "milk", "no");
Product flower = Factory.Create(300, "350", "12", "flower", "yes");
Product limonade = Factory.Create(1, "100", "1l", "limonade", "no");
Product cake = Factory.Create(600, "400", "250", "cake", "no");

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

Console.WriteLine("Обычный список");
Print(jsonConvert(products));
Console.WriteLine();
Console.WriteLine("Отсортированный по весу список:");
SortByWeight(products);

List<string> jsonConvert(List<Product> products)
{
    List<string> list = new List<string>();
    foreach (Product c in products)
{
    string json = JsonConvert.SerializeObject(c);
    Console.WriteLine(json);
}
    return list;
}
void Print(List<string> list)
{
    foreach (string item in list)
    {
        Console.WriteLine(item);
    }
}
void SortByWeight(List<Product> products)
{
    for (int j = 0; j < products.Count; j++)
    {
        for (int i = 0; i < products.Count; i++)
        {
            if (i < 9 && products[i].weight < products[i + 1].weight)
            {
                var temp = products[i];
                products[i] = products[i + 1];
                products[i + 1] = temp;
            }
        }
    }
    Print(jsonConvert(products));
    }
