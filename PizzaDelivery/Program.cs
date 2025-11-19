using PizzaDelivery.Data;
using PizzaDelivery.Models;

using PizzaContext context = new PizzaContext();

////Inputting data to databases ////////////////////////
//Product veggieSpecial = new Product()
//{
//    Name = "Veggie Special Pizza",
//    Price = 9.99M
//};
//context.Products.Add(veggieSpecial);

//Product pepperoniPizza = new Product()
//{
//    Name = "Pepperoni Pizza",
//    Price = 11.99M
//};
//context.Add(pepperoniPizza);

//context.SaveChanges();




////Quering data from database ///////////////////////

////Using Fluent API syntax
//var products = context.Products
//                .Where(p => p.Price < 10.00M)
//                .OrderBy(p => p.Name)
//                .ToList();

////using LINQ query syntax
//var products = from product in context.Products
//               where product.Price > 10.00M
//               orderby product.Name
//               select product;

//foreach (Product p in products)
//{ 
//    Console.WriteLine($"Id: {p.Id}");
//    Console.WriteLine($"Name: {p.Name}");
//    Console.WriteLine($"Price: {p.Price}");
//    Console.WriteLine(new string('_', 20));
//}


////Updating a data in database ///////////////////////
//var veggieSpecial = context.Products
//                        .Where(p => p.Name == "Veggie Special Pizza")
//                        .FirstOrDefault();

//if (veggieSpecial is Product)
//{ 
//    veggieSpecial.Price = 10.99M;
//}

//context.SaveChanges();


////Deleting a data from database ///////////////////////
var veggieSpecial = context.Products
                        .Where(p => p.Name == "Veggie Special Pizza")
                        .FirstOrDefault();

if (veggieSpecial is Product)
{
    context.Remove(veggieSpecial);
}

context.SaveChanges();

foreach (Product p in context.Products)
{
    Console.WriteLine($"Id: {p.Id} and Name: {p.Name}");
}



