



///*
// * 
// * :

//🛍️ سيناريو: متجر إلكتروني مصغّر
//🧠 هدف التمرين:
//نتعلم استخدام:

//Dictionary لتخزين المنتجات وأسعارها

//Queue لطابور الزبائن

//Stack لتخزين عمليات الشراء الخاصة بكل زبون (undo)

//List لعرض المنتجات الأكثر مبيعًا (top-selling)

//LinkedList كمخزن مرن للمنتجات المعروضة حاليًا



//=== Mini Store System ===
//1. Add Customer to Queue
//2. Serve Next Customer
//3. Show Top Selling Products
//4. Show Displayed Products
//5. Exit
//Choose: 1
//Enter customer name: Sama
//Sama added to the queue.

//=== Mini Store System ===
//1. Add Customer to Queue
//2. Serve Next Customer
//3. Show Top Selling Products
//4. Show Displayed Products
//5. Exit
//Choose: 1
//Enter customer name: Nada
//Nada added to the queue.

//=== Mini Store System ===
//1. Add Customer to Queue
//2. Serve Next Customer
//3. Show Top Selling Products
//4. Show Displayed Products
//5. Exit
//Choose: 4

//Currently Displayed Products:
//Laptop
//Mouse
//Keyboard
//Monitor
//Headphones

//=== Mini Store System ===
//1. Add Customer to Queue
//2. Serve Next Customer
//3. Show Top Selling Products
//4. Show Displayed Products
//5. Exit
//Choose: 2

//Serving Sama...
//Available Products:
//Laptop: 20000 EGP
//Mouse: 300 EGP
//Keyboard: 800 EGP
//Monitor: 5000 EGP
//Headphones: 1500 EGP
//Choose product to buy or type 'undo' or 'done':
//Laptop
//Added Laptop to Sama's purchases.
//Available Products:
//Laptop: 20000 EGP
//Mouse: 300 EGP
//Keyboard: 800 EGP
//Monitor: 5000 EGP
//Headphones: 1500 EGP
//Choose product to buy or type 'undo' or 'done':
//Mouse
//Added Mouse to Sama's purchases.
//Available Products:
//Laptop: 20000 EGP
//Mouse: 300 EGP
//Keyboard: 800 EGP
//Monitor: 5000 EGP
//Headphones: 1500 EGP
//Choose product to buy or type 'undo' or 'done':
//undo
//Invalid product.
//Available Products:
//Laptop: 20000 EGP
//Mouse: 300 EGP
//Keyboard: 800 EGP
//Monitor: 5000 EGP
//Headphones: 1500 EGP
//Choose product to buy or type 'undo' or 'done':
//undo
//Removed last purchase: Mouse
//Available Products:
//Laptop: 20000 EGP
//Mouse: 300 EGP
//Keyboard: 800 EGP
//Monitor: 5000 EGP
//Headphones: 1500 EGP
//Choose product to buy or type 'undo' or 'done':
//Headphones
//Added Headphones to Sama's purchases.
//Available Products:
//Laptop: 20000 EGP
//Mouse: 300 EGP
//Keyboard: 800 EGP
//Monitor: 5000 EGP
//Headphones: 1500 EGP
//Choose product to buy or type 'undo' or 'done':
//done

//Sama's final purchases:
//- Laptop
//- Headphones

//=== Mini Store System ===
//1. Add Customer to Queue
//2. Serve Next Customer
//3. Show Top Selling Products
//4. Show Displayed Products
//5. Exit
//Choose: 3

//Top Selling Products:
//Laptop: Sold 1 times
//Mouse: Sold 1 times
//Headphones: Sold 1 times

//=== Mini Store System ===
//1. Add Customer to Queue
//2. Serve Next Customer
//3. Show Top Selling Products
//4. Show Displayed Products
//5. Exit
//Choose: 2

//Serving Nada...
//Available Products:
//Laptop: 20000 EGP
//Mouse: 300 EGP
//Keyboard: 800 EGP
//Monitor: 5000 EGP
//Headphones: 1500 EGP
//Choose product to buy or type 'undo' or 'done':
//Keyboard
//Added Keyboard to Nada's purchases.
//Available Products:
//Laptop: 20000 EGP
//Mouse: 300 EGP
//Keyboard: 800 EGP
//Monitor: 5000 EGP
//Headphones: 1500 EGP
//Choose product to buy or type 'undo' or 'done':
//Laptop
//Added Laptop to Nada's purchases.
//Available Products:
//Laptop: 20000 EGP
//Mouse: 300 EGP
//Keyboard: 800 EGP
//Monitor: 5000 EGP
//Headphones: 1500 EGP
//Choose product to buy or type 'undo' or 'done':
//Mouse
//Added Mouse to Nada's purchases.
//Available Products:
//Laptop: 20000 EGP
//Mouse: 300 EGP
//Keyboard: 800 EGP
//Monitor: 5000 EGP
//Headphones: 1500 EGP
//Choose product to buy or type 'undo' or 'done':
//done

//Nada's final purchases:
//- Keyboard
//- Laptop
//- Mouse

//=== Mini Store System ===
//1. Add Customer to Queue
//2. Serve Next Customer
//3. Show Top Selling Products
//4. Show Displayed Products
//5. Exit
//Choose: 3

//Top Selling Products:
//Laptop: Sold 2 times
//Mouse: Sold 2 times
//Headphones: Sold 1 times
//Keyboard: Sold 1 times

//=== Mini Store System ===
//1. Add Customer to Queue
//2. Serve Next Customer
//3. Show Top Selling Products
//4. Show Displayed Products
//5. Exit
//Choose: 4

//Currently Displayed Products:
//Laptop
//Mouse
//Keyboard
//Monitor
//Headphones

//=== Mini Store System ===
//1. Add Customer to Queue
//2. Serve Next Customer
//3. Show Top Selling Products
//4. Show Displayed Products
//5. Exit
//Choose:

//*/


//var products = new Dictionary<string, double>()
//{
//    {"Laptop", 20000},
//    {"Mouse", 300},
//    {"Keyboard", 800},
//    {"Monitor", 5000},
//    {"Headphones", 1500}
//};
//var customers = new Queue<string>();
//Dictionary<string, Stack<string>> purchaseHistory = new Dictionary<string, Stack<string>>();
//List<string> topSelling = new List<string>();
//LinkedList<string> displayedProducts = new LinkedList<string>(products.Keys);
//List<string> Customers = new List<string>();

//do
//{
//    Console.WriteLine("\n=== Mini Store System ===");
//    Console.WriteLine("1. Add Customer to Queue");
//    Console.WriteLine("2. Serve Next Customer");
//    Console.WriteLine("3. Show Top Selling Products");
//    Console.WriteLine("4. Show Displayed Products");
//    Console.WriteLine("5. Show Orders For Customers");

//    Console.WriteLine("0. Exit");
//    Console.Write("Choose: ");
//    string choice = Console.ReadLine();

//    switch (choice)
//    {
//        case "1":
//            AddCustomer();
//            break;
//        case "2":
//            ServeCustomer();
//            break;
//        case "5":
//            ShowOrdersForCustomer(); 
//            break;
//        case "3":
//            ShowTopSelling();
//            break;
//        case "4":
//            ShowDisplayedProducts();
//            break;
//        case "0":
//            return;
//        default:
//            Console.WriteLine("Invalid choice.");
//            break;
//    }

//} while (true);

//void ShowDisplayedProducts()
//{
//    Console.WriteLine("----------Currently Displayed Products:----------");
//    //foreach (var product in products.Keys)
//    //{
//    //    Console.WriteLine($"Product Name : {product}");
//    //}
//    foreach (var item in displayedProducts)
//    {
//        Console.WriteLine($"{item}");
//    }
//}
//void AddCustomer()
//{
//    Console.Write("Enter The Customer Name : ");
//    string newCustomer = Console.ReadLine();

//    customers.Enqueue(newCustomer);
//    Customers.Add(newCustomer);
//    Console.WriteLine($"{newCustomer} Added Successfully to the queue!");
//}
//void ServeCustomer()
//{
//    // عشان اعمل serve محتاج ايه 
//    /*
//     * احدد العميل customer   peek()
//     * اخزن order بتاعه باسمه  stack عشان اقدر اعمل undo بس هربط ازاي customer ب order 
//     * done dequeue()
//     * undo  pop()
//     * 
//     * 
//     * 
//     * 
//Serving Sama...
//Available Products:
//Laptop: 20000 EGP
//Mouse: 300 EGP
//Keyboard: 800 EGP
//Monitor: 5000 EGP
//Headphones: 1500 EGP
//Choose product to buy or type 'undo' or 'done':
//Laptop
//Added Laptop to Sama's purchases.
//Available Products:
//Laptop: 20000 EGP
//Mouse: 300 EGP
//Keyboard: 800 EGP
//Monitor: 5000 EGP
//Headphones: 1500 EGP
//Choose product to buy or type 'undo' or 'done':
//Mouse
//Added Mouse to Sama's purchases.
//Available Products:
//Laptop: 20000 EGP
//Mouse: 300 EGP
//Keyboard: 800 EGP
//Monitor: 5000 EGP
//Headphones: 1500 EGP
//Choose product to buy or type 'undo' or 'done':
//undo
//Invalid product.
//Available Products:
//Laptop: 20000 EGP
//Mouse: 300 EGP
//Keyboard: 800 EGP
//Monitor: 5000 EGP
//Headphones: 1500 EGP
//Choose product to buy or type 'undo' or 'done':
//undo
//Removed last purchase: Mouse
//Available Products:
//Laptop: 20000 EGP
//Mouse: 300 EGP
//Keyboard: 800 EGP
//Monitor: 5000 EGP
//Headphones: 1500 EGP
//Choose product to buy or type 'undo' or 'done':
//Headphones
//Added Headphones to Sama's purchases.
//Available Products:
//Laptop: 20000 EGP
//Mouse: 300 EGP
//Keyboard: 800 EGP
//Monitor: 5000 EGP
//Headphones: 1500 EGP
//Choose product to buy or type 'undo' or 'done':
//done

//Sama's final purchases:
//- Laptop
//- Headphones
//     * 
//     * */
//    // if no one in queue
//    if (customers.Count == 0)
//    {
//        Console.WriteLine("No Customers Founded!");
//    }
//    else
//    {
//        Console.WriteLine($"{customers.Peek()} Serving.....");
//        Stack<string> orderForCustomer = new Stack<string>();
//        bool result = true;
//        do
//        {
//            Console.WriteLine(" Available Products: ");
//            foreach (var product in products)
//            {
//                Console.WriteLine($"{product.Key} : {product.Value}");
//            }

//            Console.WriteLine("----------Choose Product or type undo or done----------");

//            var res = Console.ReadLine();
//            if (products.ContainsKey(res))
//            {


//                orderForCustomer.Push(res);
//                Console.WriteLine($"Added {res} to {customers.Peek()}'s purchases.\r\n");

//                result = true;
//            }
//            else if (res.ToLower() == "undo")
//            {
//                if (orderForCustomer.Count > 0)
//                {
//                    string removedItem = orderForCustomer.Pop();
//                    Console.WriteLine($"Removed last purchase: {removedItem}");
//                }
//                else
//                {
//                    Console.WriteLine("Nothing to undo.");
//                }
//                result = true;
//            }
//            else if (res.ToLower() == "done")
//            {
//                purchaseHistory.Add(customers.Peek(), orderForCustomer);
//                topSelling.AddRange([.. orderForCustomer]);
//                Console.WriteLine($"{customers.Peek()}'s final purchases: ");
//                double sumOfOrder = 0;
//                foreach (var order in orderForCustomer.Reverse())
//                {
//                    Console.WriteLine($"- {order} : {products[order]}");
//                    sumOfOrder += products[order];
//                }

//                Console.WriteLine($"Total Price is: {sumOfOrder}");
//                customers.Dequeue();
//                result = false;

//            }
//            else
//            {
//                Console.WriteLine("Invalid product.");
//            }
//        } while (result);
//    }
//}
//void ShowTopSelling()
//{
//    //    Top Selling Products:
//    //Laptop: Sold 2 times
//    //Mouse: Sold 2 times
//    //Headphones: Sold 1 times
//    //Keyboard: Sold 1 times
//    if (topSelling.Count > 0)
//    {
//        var numberOfElemnts = new Dictionary<string, int>();
//        foreach (var product in topSelling)
//        {
//            if (numberOfElemnts.ContainsKey(product))
//            {
//                numberOfElemnts[product] += 1;
//            }
//            else
//            {
//                numberOfElemnts.Add(product, 1);
//            }
//        }
//        numberOfElemnts.Order();
//        Console.WriteLine("Top Selling Products: ");

//        foreach (var item in numberOfElemnts)
//        {
//            Console.WriteLine($"{item.Key}: Sold {item.Value} times");
//        }

//    }
//    else
//    {
//        Console.WriteLine("No Orders Yet!");
//    }
//}
//void ShowOrdersForCustomer()
//{
//    //Customers List
//    //purchaseHistory
//    Console.Write("Enter the Customer Name For Search:");
//    string customerName = Console.ReadLine();
//    if (Customers.Contains(customerName))
//    {

//            Console.WriteLine(@$"Customer Name : {customerName}");
//        foreach (var product in purchaseHistory[customerName])
//        {
//            Console.WriteLine($"                - {product} ");
//        }

//    }
//    else
//    {
//        Console.WriteLine("No Customer Founded  By this Name");
//    }
//}
//void ShowAllOrders()
//{
//    if (purchaseHistory.Count > 0)
//    {
//        foreach (var item in purchaseHistory)
//        {
//            Console.WriteLine(@$"Customer Name : {item.Key}");
//            foreach (var product in item.Value)
//            {
//                Console.WriteLine($"        - {product} ");
//            }

//        }
//    }
//    else
//    {
//        Console.WriteLine("No Ordered Yet!");
//    }
//}


















































































using System;
using System.Collections.Generic;
using System.Linq;

var products = new Dictionary<string, double>()
{
    {"Laptop", 20000},
    {"Mouse", 300},
    {"Keyboard", 800},
    {"Monitor", 5000},
    {"Headphones", 1500}
};

var customers = new Queue<string>();
Dictionary<string, Stack<string>> purchaseHistory = new Dictionary<string, Stack<string>>();
List<string> topSelling = new List<string>();
LinkedList<string> displayedProducts = new LinkedList<string>(products.Keys);
List<string> Customers = new List<string>();

do
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("\n=== 🛍️ Mini Store System ===");
    Console.ResetColor();
    Console.WriteLine("1. Add Customer to Queue");
    Console.WriteLine("2. Serve Next Customer");
    Console.WriteLine("3. Show Top Selling Products");
    Console.WriteLine("4. Show Displayed Products");
    Console.WriteLine("5. Show Orders For Customers");
    Console.WriteLine("6. Show All Orders ");
    Console.WriteLine("0. Exit");
    Console.Write("Choose: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            AddCustomer();
            break;
        case "2":
            ServeCustomer();
            break;
        case "3":
            ShowTopSelling();
            break;
        case "4":
            ShowDisplayedProducts();
            break;
        case "5":
            ShowOrdersForCustomer();
            break;
        case "6":
            ShowAllOrders();
            break;
        case "0":
            return;
        default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("❌ Invalid choice.");
            Console.ResetColor();
            break;
    }

} while (true);

void AddCustomer()
{
    Console.Write("Enter the customer name: ");
    string newCustomer = Console.ReadLine();

    customers.Enqueue(newCustomer);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"✅ {newCustomer} added to the queue.");
    Console.ResetColor();
}

void ShowDisplayedProducts()
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("\n🧾 Currently Displayed Products:");
    Console.ResetColor();
    foreach (var item in displayedProducts)
    {
        Console.WriteLine($"- {item}");
    }
}

void ServeCustomer()
{
    if (customers.Count == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("⚠️ No customers in queue!");
        Console.ResetColor();
        return;
    }

    string currentCustomer = customers.Peek();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"\n👤 Serving {currentCustomer}...");
    Console.ResetColor();

    Stack<string> orderForCustomer = new Stack<string>();
    bool shopping = true;

    do
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("\n🛒 Available Products:");
        Console.ResetColor();

        foreach (var product in products)
        {
            Console.WriteLine($"{product.Key}: {product.Value} EGP");
        }

        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("Type a product name to add it to your order.");
        Console.WriteLine("Type 'undo' to remove last product, 'done' to finish.");
        Console.ResetColor();

        string input = Console.ReadLine();

        if (products.ContainsKey(input))
        {
            orderForCustomer.Push(input);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"✅ Added {input} to {currentCustomer}'s purchases.");
            Console.ResetColor();
        }
        else if (input.ToLower() == "undo")
        {
            if (orderForCustomer.Count > 0)
            {
                string removedItem = orderForCustomer.Pop();
                //topSelling.Remove(removedItem); // 🛠️ Fix: Remove from topSelling
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"↩️ Removed last purchase: {removedItem}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("⚠️ Nothing to undo.");
                Console.ResetColor();
            }
        }
        else if (input.ToLower() == "done")
        {
            if (orderForCustomer.Count == 0)
            {

                orderForCustomer.Clear();
            }
            else
            {
                Customers.Add(customers.Peek());

                purchaseHistory[currentCustomer] = orderForCustomer;
                topSelling.AddRange(orderForCustomer);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\n🧾 {currentCustomer}'s Final Purchases:");
                Console.ResetColor();

                double total = 0;
                foreach (var item in orderForCustomer.Reverse())
                {
                    Console.WriteLine($"- {item} : {products[item]} EGP");
                    total += products[item];
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"💰 Total: {total} EGP");
                Console.ResetColor();
            }
            customers.Dequeue();
            shopping = false;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("❌ Invalid product.");
            Console.ResetColor();
        }

    } while (shopping);
}

void ShowTopSelling()
{
    if (topSelling.Count == 0)
    {
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("📦 No sales yet!");
        Console.ResetColor();
        return;
    }

    var sellingCounts = new Dictionary<string, int>();
    foreach (var product in topSelling)
    {
        if (sellingCounts.ContainsKey(product))
            sellingCounts[product]++;
        else
            sellingCounts[product] = 1;
    }

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("\n🔥 Top Selling Products:");
    Console.ResetColor();
    foreach (var item in sellingCounts.OrderByDescending(i => i.Value))
    {
        Console.WriteLine($"{item.Key}: Sold {item.Value} times");
    }
}

void ShowOrdersForCustomer()
{
    Console.Write("Enter customer name: ");
    string customerName = Console.ReadLine();
    if (Customers.Contains(customerName))
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"\n🧾 Orders for {customerName}:");
        Console.ResetColor();

        foreach (var item in purchaseHistory[customerName])
        {
            Console.WriteLine($"- {item}");
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("❌ No customer found with that name.");
        Console.ResetColor();
    }
}
void ShowAllOrders()
{
    if (purchaseHistory.Count > 0)
    {
        foreach (var item in purchaseHistory)
        {
            Console.WriteLine(@$"Customer Name : {item.Key}");
            foreach (var product in item.Value)
            {
                Console.WriteLine($"              - {product} ");
            }

        }
    }
    else
    {
        Console.WriteLine("No Ordered Yet!");
    }
}
