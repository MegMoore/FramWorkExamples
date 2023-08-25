
using FramWorkExamples;


var _context = new AppDbContext();

var custOrders = from c in _context.Customers
                 join o in _context.Orders
                    on c.Id equals o.CustomerId
                 join ol in _context.OrderLines
                    on o.Id equals ol.OrdersId
                 where c.Id = 1
                 select new
                 {
                     OrderDate = o.Date,
                     o.Description,
                     Customer = c.Name,
                     ol.Product,
                     ol.Price,
                     ol.Quantity,
                     LineTotal = ol.Quantity * ol.Price

                 };
custOrders.ToList().ForEach(c => Console.WriteLine($"{c.OrderDate} | {c.Description} | {c.Customer} | {ol.Product}" +
    "| {ol.Price} | {ol.Quantity} | {ol.LineTotal}"));



//joining columns and printing results
//var custOrders = from c in _context.Customers
//               join o in _context.Orders
//                on c.Id equals o.CustomerId
//           select new
//         {
//           OrderDate = o.Date,
//         o.Description,
//       Customer = c.Name
//
// };
//custOrders.ToList().ForEach(c => Console.WriteLine($"{c.OrderDate} | {c.Description} | {c.Customer}"));


//get orders
//var orders = _context.Orders.ToList();
//orders.ForEach(o => Console.WriteLine(o));





//query syntax
//var customers = from c in _context.Customers
//              where c.City == "Cincinnati"
//            orderby c.Name
//          select c;

//query method //get all customers
//foreach(var cust in _context.Customers.ToList())
//{
//  Console.WriteLine(cust);
//}
//get by primary key
//Console.WriteLine(_context.Customers.Find(1));

//insert customer
//var newCust = new Customer()
//{
//  Id = 0,
//Code = "MTT",
//Active = true,
//City = "Mason",
//Name = "Max",
//State = "OH"
//};
//_context.Customers.Add(newCust);
//_context.SaveChanges(); // must use this to save changes to the database

//update customer
//var updCustomer = _context.Customers.Find(42);
//if (updCustomer == null) return; 
//updCustomer.Code = "Meg2";
//_context.SaveChanges();

//delete customer
//int id = 50;
//var delCust = _context.Customers.Find(id);
//if (delCust == null) return;
//_context.Remove(delCust);
//_context.SaveChanges();

