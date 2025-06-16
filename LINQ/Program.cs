
//Product p1 = new Product("Pants",500);
//Product p2 = new Product("T-Shirts", 200);
//Product p3 = new Product("Sweaters", 600);
//Product p4 = new Product("Sweatshirt", 250);

//List<Product> products = [p1, p2, p3, p4];


//var cheapProducts= products.Where(product => product.Price <=250).ToList();
////from product in products
////               where product.Price <=250
////               select product;

//var names=products.Select(product=>product.Name).ToList();
//var firstCheapProduct= cheapProducts.First(product=> product.Price<250);

//var orderedProducts=products.OrderBy(product=>product.Price).ToList();
//Console.WriteLine("firstCheapProduct");
//Console.WriteLine(firstCheapProduct.Name);
//Console.WriteLine("--------cheapProducts------------");

//foreach (var item in cheapProducts)
//{
//    Console.WriteLine($"{item.Name} ");
//}
//Console.WriteLine("--------names------------");

//foreach (var item in names)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("--------orderedProducts------------");
//foreach (var item in orderedProducts)
//{
//    Console.WriteLine(item.Name);
//}








Students s1 = new Students("Sama",95);


Students s2 = new Students("Nada", 100);

Students s3 = new Students("Basma", 85);
Students s4 = new Students("Gawaher", 75);

List<Students> students =new List<Students>() {s1, s2, s3, s4};


IEnumerable<Students> topStudents=from  student in students
                                 where student.Grade >85
                                 select student;
foreach (var item in topStudents)
{
    Console.WriteLine($"Student Name:{item.Name} - Student Grade :{item.Grade}");
}

IEnumerable<string> StudentNames=students.Select(student => student.Name);
foreach (var item in StudentNames)
{
    Console.WriteLine($"Student Name:{item}");
}
var orderedStudents=students.OrderByDescending(student=>student.Grade);
foreach (var item in orderedStudents)
{
    Console.WriteLine($"Student Name:{item.Name} - Student Grade :{item.Grade}");

}
var countOfLowStudents = students.Count(student => student.Grade < 80);
Console.WriteLine($"Student get Less Than 80: {countOfLowStudents}");


var AvgGrades=students.Average(student => student.Grade);
Console.WriteLine($"Average of Students Grades: {AvgGrades}");



var topStudent = students.FirstOrDefault(student => student.Grade == 100);
Console.WriteLine($"The Top Student is : {topStudent.Name} with {topStudent.Grade}");

var lowStudent = students.Any(student => student.Grade <= 75);

Console.WriteLine($" {lowStudent}");







public class Product
{
    public string Name { get; set; } 
    public int Price { get; set; }

    public Product(string name, int price)
    {
        Name = name;
        Price = price;
    }
}





public class Students
{
    public string Name { get; set; }
    public double Grade { get; set; }
    public Students(string name, double grade)
    {
        Name = name;
        Grade = grade;
    }
}