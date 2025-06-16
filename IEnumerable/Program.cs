

//var students = new Dictionary<string, int>() {
//    {"Nada",92 },
//    {"Sama",80 },
//    {"Basma",85 },{"Gawaher",100}


//};

//IEnumerable<string> TopStudents= GetTopStudents(students);
//foreach (var item in TopStudents)
//{
//    Console.WriteLine($"{item} ");
//}







//static IEnumerable<string> GetTopStudents (Dictionary<string, int> students)

//{
//    foreach (var student in students)
//    {
//        if (student.Value > 85)
//        {
//            yield return student.Key;
//        }
//    }


//}





Product p1 = new Product("cola",20);

Product p2 = new Product("Tshirt", 200);
Product p3 = new Product("pants", 100);
Product p4 = new Product("chips", 10);
IEnumerable<Product> products = new List<Product>() { p1,p2,p3,p4};

IEnumerable<Product> ProductsLessThan100= GetAffordableProducts(products);
foreach (var item in ProductsLessThan100)
{
    Console.WriteLine($"{item.Name} ");
}

static IEnumerable<Product> GetAffordableProducts(IEnumerable<Product> products)
{
    foreach (Product product in products)
    {
        if (product.Price <= 100)
        {
            yield return product;
        }
    }
}
public class Product
{
    public string Name { get; set; }    
    public double Price { get; set; }

    public Product(string name,double price)
    {
        Name = name; Price = price;
    }
    
}
